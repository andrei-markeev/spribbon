using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using FluentRibbon.Libraries;
using FluentRibbon.Definitions;

namespace FluentRibbon.SandboxSample.Features.Feature1
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("2ee4a447-27c2-4def-ad7d-fa3644ca32aa")]
    public class Feature1EventReceiver : SPFeatureReceiver
    {

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWeb web = (properties.Feature.Parent as SPSite).RootWeb;

            var button1 = ControlLibrary.CreateRandomButton();

            var ribbonCustomAction = new RibbonCustomAction();

            // We need assign TemplateAlias manually to buttons, if they will be deployed separately
            button1.TemplateAlias = "o1";
            ribbonCustomAction.AddControl(button1, "Ribbon.ListItem.New", 1);

            ribbonCustomAction.Provision(properties.Feature.DefinitionId, web, ListTypes.GenericList);

        }


        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPWeb web = (properties.Feature.Parent as SPSite).RootWeb;
            RibbonCustomAction.RemoveAllCustomizations(web, properties.Feature.DefinitionId);
        }
    }
}
