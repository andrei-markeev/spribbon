using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;
using FluentRibbon.Libraries;
using FluentRibbon.Commands;

namespace FluentRibbon
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
        /// Removes ribbon element with specified id (it can be control, control group, tab, whatever..)
        /// </summary>
        /// <param name="controlId">Id of control, which will be deleted</param>
        public void RemoveRibbonElement(string controlId)
        {
            RibbonXML = ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(controlId, string.Empty));
        }


        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on specified list pages, for lists with specified ID (this can be your custom list template ID), 
        /// to users with appropriate rights.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="userCustomActions">Collection of custom actions of web or list (web.UserCustomActions or list.UserCustomActions)</param>
        /// <param name="templateId">Custom list template Id, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="rights">Rights user needs to access the ribbon</param>
        /// <returns>Id of provisioned custom action</returns>
        
        // Overloads for this method are in "RibbonCustomAction/ProvisionOverloads.cs"
        public Guid Provision(Guid featureUniqueGuid, SPUserCustomActionCollection userCustomActions, string templateId, ListForms whichForms, SPBasePermissions? rights)
        {
            var customAction = userCustomActions.Add();

            customAction.Name = "FluentRibbon._" + featureUniqueGuid.ToString().Replace("-", "") + "._" + Guid.NewGuid().ToString().Replace("-", "");
            customAction.Location = GetRibbonLocationByListForms(whichForms);
            customAction.CommandUIExtension = XmlGenerator.Current.GetCommandUIExtensionXML(RibbonXML, RibbonCommandsXML, RibbonTemplatesXML);
            if (customAction.Scope != SPUserCustomActionScope.List)
            {
                if (String.IsNullOrEmpty(templateId) || templateId == ((int)ListTypes.All).ToString())
                {
                    customAction.RegistrationType = SPUserCustomActionRegistrationType.ContentType;
                    customAction.RegistrationId = "0x";
                }
                else if (templateId != ((int)ListTypes.None).ToString())
                {
                    customAction.RegistrationType = SPUserCustomActionRegistrationType.List;
                    customAction.RegistrationId = templateId;
                }
            }
            if (rights.HasValue)
                customAction.Rights = rights.Value;

            customAction.Update();

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
        /// Remove all ribbon customizations from specified site. Usually done in FeatureDeactivating method.
        /// </summary>
        /// <param name="site">SPSite object, from which customizations will be removed.</param>
        /// <param name="featureScopedGuid">Guid, which was previosly passed into ribbon creation methods.</param>
        public static void RemoveAllCustomizations(SPSite site, Guid featureScopedGuid)
        {
            for (int i = site.UserCustomActions.Count - 1; i >= 0; i--)
            {
                var customAction = site.UserCustomActions.ElementAt(i);

                if (customAction.Name.StartsWith("FluentRibbon._" + featureScopedGuid.ToString().Replace("-", "")))
                {
                    customAction.Delete();
                }
            }
        }

        /// <summary>
        /// Remove all ribbon customizations from specified web. Usually done in FeatureDeactivating method.
        /// </summary>
        /// <param name="web">SPWeb object, from which customizations will be removed.</param>
        /// <param name="featureScopedGuid">Guid, which was previosly passed into ribbon creation methods.</param>
        public static void RemoveAllCustomizations(SPWeb web, Guid featureScopedGuid)
        {
            bool isCollectionChanged = false;
            for (int i = web.UserCustomActions.Count - 1; i >= 0; i--)
            {
                var customAction = web.UserCustomActions.ElementAt(i);

                if (customAction.Name.StartsWith("FluentRibbon._" + featureScopedGuid.ToString().Replace("-", "")))
                {
                    isCollectionChanged = true;
                    customAction.Delete();
                }
            }

            if (isCollectionChanged)
                web.Update();
        }

        /// <summary>
        /// Remove all ribbon customizations from specified list. Usually done in FeatureDeactivating method.
        /// </summary>
        /// <param name="web">SPList object, from which customizations will be removed.</param>
        /// <param name="featureScopedGuid">Guid, which was previosly passed into ribbon creation methods.</param>
        public static void RemoveAllCustomizations(SPList list, Guid featureScopedGuid)
        {
            bool isCollectionChanged = false;
            for (int i = list.UserCustomActions.Count - 1; i >= 0; i--)
            {
                var customAction = list.UserCustomActions.ElementAt(i);

                if (customAction.Name.StartsWith("FluentRibbon._" + featureScopedGuid.ToString().Replace("-", "")))
                {
                    isCollectionChanged = true;
                    customAction.Delete();
                }
            }

            if (isCollectionChanged)
                list.Update();
        }

        #region Private

        private string GetCommandsXML(RibbonDefinition definition)
        {
            var commands = new RibbonCommandRepository();
            commands.AddCommands(definition);
            string commandsXML = String.Empty;

            foreach (var command in commands.GetCommands())
            {
                commandsXML += XmlGenerator.Current.GetCommandUIHandlerXML(command);
            }

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
                    return "CommandUI.Ribbon." + whichForms.ToString();
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
