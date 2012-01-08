using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using FluentRibbon.Definitions.Controls;
using FluentRibbon.Libraries;
using FluentRibbon.Definitions;

namespace FluentRibbon.Elementary.Features.Feature1
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

[Guid("4e0a75de-9dc0-4e2a-b7c3-2d6932bf7707")]
public class Feature1EventReceiver : SPFeatureReceiver
{
    Guid ReceiverGuid { get { return new Guid("4e0a75de-9dc0-4e2a-b7c3-2d6932bf7707"); } }

    public override void FeatureActivated(SPFeatureReceiverProperties properties)
    {
        SPWeb web = (properties.Feature.Parent as SPSite).RootWeb;

        var button1 = ControlLibrary.CreateRandomButton();
        var button2 = ControlLibrary.CreateRandomButton();
        var button3 = ControlLibrary.CreateRandomButton();

        var group = new GroupDefinition()
        {
            Id = "MyGroup",
            Title = "Custom controls",
            Template = Libraries.GroupTemplateLibrary.SimpleTemplate,
            Controls = new ControlDefinition[]
            {
                button2,
                button3
            }
        };

        var ribbonCustomAction = new RibbonCustomAction();

        ribbonCustomAction.AddControlGroup(group, SPRibbonIds.ListItem.Id, 25);

        // We need assign TemplateAlias manually to buttons, if they will be deployed separately
        button1.TemplateAlias = "o1";
        ribbonCustomAction.AddControl(button1, SPRibbonIds.ListItem.Groups.Manage.Id, 1);
        ribbonCustomAction.Provision(properties.Definition.Id, web, ListTypes.GenericList, ListForms.NewForm);

    }


    public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
    {
        SPWeb web = (properties.Feature.Parent as SPSite).RootWeb;
        RibbonCustomAction.RemoveAllCustomizations(web, properties.Definition.Id);
    }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
