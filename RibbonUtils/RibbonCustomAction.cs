using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using RibbonUtils.Definitions;
using RibbonUtils.Definitions.Controls;
using Microsoft.SharePoint.WebControls;
using RibbonUtils.Libraries;

namespace RibbonUtils
{
    /// <summary>
    /// Manage ribbon creation from feature receivers
    /// </summary>
    
    // So much code in this class, and xml comments as well, so made it partial (and readable, I hope). See "RibbonCustomAction" project folder.
    public partial class RibbonCustomAction
    {

        /// <summary>
        /// Prepared for deployment ribbon definitions
        /// </summary>
        private string RibbonXML { get; set; }

        /// <summary>
        /// Prepared for deployment ribbon commands
        /// </summary>
        private string RibbonCommandsXML { get; set; }

        /// <summary>
        /// Prepared for deployment ribbon commands
        /// </summary>
        private string RibbonTemplatesXML { get; set; }

        /// <summary>
        /// Creates a user custom action for ribbon creation and management.
        /// Custom action is something like a container for your customizations.
        /// </summary>
        public RibbonCustomAction()
        {
            RibbonXML = String.Empty;
            RibbonCommandsXML = String.Empty;
            RibbonTemplatesXML = "<root>" + String.Join("", GroupTemplateLibrary.AllTemplates.Select(t => t.XML).ToArray()) + "</root>";
        }


        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on specified list pages, for lists with specified ID (this can be your custom list template ID), 
        /// to users with appropriate rights.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="templateId">Custom list template Id, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="rights">Rights user needs to access the ribbon</param>
        /// <returns>Id of provisioned custom action</returns>
        
        // Overloads for this method are in "RibbonCustomAction/ProvisionOverloads.cs"
        public Guid Provision(Guid featureUniqueGuid, SPWeb web, string templateId, ListForms whichForms, SPBasePermissions? rights)
        {
            var customAction = web.UserCustomActions.Add();

            customAction.Name = "RibbonUtils._" + featureUniqueGuid.ToString().Replace("-", "") + "._" + Guid.NewGuid().ToString().Replace("-", "");
            customAction.Location = GetRibbonLocationByListForms(whichForms);
            customAction.CommandUIExtension = XmlGenerator.Current.GetCommandUIExtensionXML(RibbonXML, RibbonCommandsXML, RibbonTemplatesXML);
            if (!String.IsNullOrEmpty(templateId))
            {
                customAction.RegistrationType = SPUserCustomActionRegistrationType.List;
                customAction.RegistrationId = templateId;
            }
            if (rights.HasValue)
                customAction.Rights = rights.Value;

            customAction.Update();
            web.Update();

            return customAction.Id;
        }

        #region Templates

        /// <summary>
        /// Add templates, for using with your group definitions. 
        /// Do NOT add standard templates from here! They are added automatically.
        /// </summary>
        /// <param name="definition">Group template definition.</param>
        public void AddTemplate(GroupTemplateDefinition definition)
        {
            RibbonTemplatesXML = ConcatXML(RibbonTemplatesXML, definition.XML);
        }

        #endregion

        /// <summary>
        /// Remove all ribbon customization. Usually done in FeatureDeactivating method.
        /// </summary>
        /// <param name="web">SPWeb object, from which customizations will be removed.</param>
        /// <param name="featureScopedGuid">Guid, which was previosly passed into ribbon creation methods.</param>
        public static void RemoveAllCustomizations(SPWeb web, Guid featureScopedGuid)
        {
            bool isCollectionChanged = false;
            for (int i = web.UserCustomActions.Count - 1; i >= 0; i--)
            {
                var customAction = web.UserCustomActions.ElementAt(i);

                if (customAction.Name.StartsWith("RibbonUtils._" + featureScopedGuid.ToString().Replace("-", "")))
                {
                    isCollectionChanged = true;
                    customAction.Delete();
                }
            }

            if (isCollectionChanged)
                web.Update();
        }


        #region Private

        private string GetCommandsXML(RibbonDefinition definition)
        {
            RibbonCommandRepository.Current.ClearCommands();
            RibbonCommandRepository.Current.AddCommands(definition);
            string commandsXML = String.Empty;

            foreach (var command in RibbonCommandRepository.Current.GetCommands())
            {
                commandsXML += XmlGenerator.Current.GetCommandUIHandlerXML(command);
            }

            RibbonCommandRepository.Current.ClearCommands();
            return "<root>" + commandsXML + "</root>";

        }


        private string GetRibbonLocationByListForms(ListForms whichForms)
        {
            switch (whichForms)
            {
                case ListForms.ListView:
                case ListForms.NewForm:
                case ListForms.EditForm:
                case ListForms.DisplayForm:
                    return "CommandUI.Ribbon" + whichForms.ToString();
                case ListForms.All:
                    return "CommandUI.Ribbon";
                default:
                    throw new Exception("Impossible list forms value.");
            }
        }
        private string ConcatXML(string xml1, string xml2)
        {
            return 
                "<root>" +
                xml1.Replace("<root>", "").Replace("</root>", "") + 
                xml2.Replace("<root>", "").Replace("</root>", "") +
                "</root>";
        }

        #endregion

    }
}
