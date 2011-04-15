using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using RibbonUtils.Definitions;
using RibbonUtils.Definitions.Controls;
using Microsoft.SharePoint.WebControls;

namespace RibbonUtils
{
    /// <summary>
    /// Manage ribbon creation from feature receivers
    /// </summary>
    public class RibbonFromFeature
    {
        #region Singleton

        private static RibbonFromFeature instance = null;

        /// <summary>
        /// Singleton instance for the class
        /// </summary>
        public static RibbonFromFeature Current
        {
            get
            {
                if (instance == null)
                    instance = new RibbonFromFeature();

                return instance;
            }
        }

        private RibbonFromFeature()
        {
        }

        #endregion


        #region Tabs

        /// <summary>
        /// Registers custom ribbon tab for a list at specified SPWeb.
        /// </summary>
        /// <param name="location">Where ribbon tab needs to be added to.</param>
        /// <param name="tabDefinition">Definition of the ribbon tab.</param>
        /// <returns>Guid of created SPUserCustomAction</returns>
        public Guid AddTab(RibbonLocation location, TabDefinition tabDefinition)
        {
            return CreateRibbonCustomAction(
                location,
                XmlGenerator.Current.GetCommandUIDefinitionXML(
                    "Ribbon.Tabs._children",
                    XmlGenerator.Current.GetTabXML(tabDefinition),
                    GetCommandsXML(tabDefinition)
                    ));
        }

        /// <summary>
        /// Registers custom ribbon tab for a list at specified SPWeb, replacing one of the existing tabs.
        /// </summary>
        /// <param name="location">Where ribbon tab needs to be added to.</param>
        /// <param name="tabDefinition">Definition of the ribbon tab.</param>
        /// <param name="oldTabId">Valid existing ribbon tab id, for tab which will be replaced.</param>
        /// <returns>Guid of created SPUserCustomAction</returns>
        public Guid ReplaceTab(RibbonLocation location, TabDefinition tabDefinition, string oldTabId)
        {
            return CreateRibbonCustomAction(
                location,
                XmlGenerator.Current.GetCommandUIDefinitionXML(
                    oldTabId,
                    XmlGenerator.Current.GetTabXML(tabDefinition),
                    GetCommandsXML(tabDefinition)));
        }

        #endregion

        #region Controls

        /// <summary>
        /// Adds control to existing control group
        /// </summary>
        /// <param name="location">Where ribbon tab needs to be added to.</param>
        /// <param name="controlDefinition">Definition of ribbon control.</param>
        /// <param name="controlGroupId">Id of a control group, where the control will be inserted into. For example: "Ribbon.ListItem.New"</param>
        /// <param name="controlSequence">Sequence value for this control to position it inside the group.</param>
        /// <returns>Guid of created SPUserCustomAction</returns>
        public Guid AddControl(RibbonLocation location, ControlDefinition controlDefinition, string controlGroupId, int controlSequence)
        {
            return CreateRibbonCustomAction(
                location,
                XmlGenerator.Current.GetCommandUIDefinitionXML(
                    controlGroupId + ".Controls._children",
                    XmlGenerator.Current.GetControlXML(controlDefinition, controlSequence, controlGroupId),
                    GetCommandsXML(controlDefinition)));
        }

        /// <summary>
        /// Replaces control with custom one.
        /// </summary>
        /// <param name="location">Where ribbon tab needs to be added to.</param>
        /// <param name="controlDefinition">Definition of ribbon control.</param>
        /// <param name="controlId">Id of the old control, which will be replaced</param>
        /// <param name="controlSequence">Sequence value for this control to position it inside the group.</param>
        /// <returns>Guid of created SPUserCustomAction</returns>
        public Guid ReplaceControl(RibbonLocation location, ControlDefinition controlDefinition, string controlId, int controlSequence)
        {
            return CreateRibbonCustomAction(
                location,
                XmlGenerator.Current.GetCommandUIDefinitionXML(
                    controlId,
                    XmlGenerator.Current.GetControlXML(
                        controlDefinition,
                        controlSequence,
                        controlId.Substring(0, controlId.LastIndexOf('.'))
                        ),
                    GetCommandsXML(controlDefinition)
                    ));
        }
        #endregion


        #region Cleanup

        /// <summary>
        /// Remove all ribbon customization. Usually done in FeatureDeactivating method.
        /// </summary>
        /// <param name="web">SPWeb object, from which customizations will be removed.</param>
        /// <param name="featureScopedGuid">Guid, which was previosly passed into ribbon creation methods.</param>
        public void RemoveAllCustomizations(SPWeb web, Guid featureScopedGuid)
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

        #endregion


        #region Private

        private Guid CreateRibbonCustomAction(RibbonLocation location, string ribbonXML)
        {

            var customAction = location.Web.UserCustomActions.Add();

            customAction.Name = "RibbonUtils._" + location.FeatureScopedGuid.ToString().Replace("-", "") + "._" + Guid.NewGuid().ToString().Replace("-", "");
            customAction.Location = location.WhichForms;
            customAction.CommandUIExtension = ribbonXML;
            if (!String.IsNullOrEmpty(location.TemplateId))
            {
                customAction.RegistrationType = SPUserCustomActionRegistrationType.List;
                customAction.RegistrationId = location.TemplateId;
            }
            if (location.Rights.HasValue)
                customAction.Rights = location.Rights.Value;
            customAction.Update();
            location.Web.Update();

            return customAction.Id;
        }


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
            return commandsXML;

        }

        #endregion
    }
}
