using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using FluentRibbon;
using FluentRibbon.Definitions.Controls;
using FluentRibbon.Libraries;
using Microsoft.SharePoint.Utilities;

namespace EmailsButton.Features.EmailsButton
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("14bb08ee-6510-4504-8112-6661d380fe16")]
    public class EmailsButtonEventReceiver : SPFeatureReceiver
    {

public override void FeatureActivated(SPFeatureReceiverProperties properties)
{
    var web = properties.Feature.Parent as SPWeb;

    var button = new ButtonDefinition()
    {
        Id = "EmailsButton",
        Title = "Emails button",
        Image = ImageLibrary.GetStandardImage(14, 4),
        CommandJavaScript = "PopupEmailsDialog();",
        CommandEnableJavaScript = "SP.ListOperation.Selection.getSelectedItems().length > 0",
        TemplateAlias = "o1"
    };

    var ribbonCustomAction = new RibbonCustomAction();
    ribbonCustomAction.AddControl(button, SPRibbonIds.ListItem.Groups.Actions.Id, 10);
    ribbonCustomAction.Provision(properties.Definition.Id, web, ListTypes.ContactsList);
}

public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
{
    var web = properties.Feature.Parent as SPWeb;
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
