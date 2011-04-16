using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using RibbonUtils.Definitions.Controls;
using RibbonUtils.Libraries;
using RibbonUtils.Definitions;

namespace RibbonUtils.Elementary.Features.Feature1
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

            var button = new ButtonDefinition()
            {
                Id = "MyButton",
                Title = "Hello world!",
                Image = ImageLibrary.GetStandardImage(0, 0),
                ToolTip = new ToolTipDefinition()
                {
                    Title = "Simple test",
                    Description = "This is simple test button which must be displayed in generic list 'Items' contextual tabs."
                },
                CommandJavaScript = "SP.UI.Notify.addNotification('hello from ribbon!');",
                TemplateAlias = "o1"
            };

            var group = new GroupDefinition()
            {
                Id = "MyGroup",
                Title = "Custom controls",
                Template = Libraries.GroupTemplateLibrary.SimpleTemplate,
                Controls = new ControlDefinition[]
                {
                    new ButtonDefinition()
                    {
                        Id = "TestInGroup",
                        Title = "Test button in group",
                        CommandJavaScript = "alert('test from group!')",
                        Image = Libraries.ImageLibrary.GetStandardImage(0, 1)
                    },
                    new ButtonDefinition()
                    {
                        Id = "TestInGroup2",
                        Title = "Test button in group2",
                        CommandJavaScript = "alert('test from group2!')",
                        Image = Libraries.ImageLibrary.GetStandardImage(0, 2)
                    }
                }
            };

            var tab = new TabDefinition()
            {
                Id = "CustomListTab",
                Title = "Custom List tab",
                Groups = new GroupDefinition[]
                {
                    group,
                    new GroupDefinition()
                    {
                        Id = "SecondGroup",
                        Title = "Three row group",
                        Template = GroupTemplateLibrary.ThreeRowTemplate,
                        Controls = new ControlDefinition[]
                        {
                            button,
                            new TextBoxDefinition()
                            {
                                Id="TestTextBox"
                            }
                        }

                    }
                }
            };

            var ribbonCustomAction = new RibbonCustomAction();

            ribbonCustomAction.ReplaceTab(tab, "Ribbon.List");
            ribbonCustomAction.AddControl(button, "Ribbon.ListItem.Manage", 1);
            ribbonCustomAction.AddControlGroup(group, "Ribbon.ListItem", 25);

            ribbonCustomAction.Provision(ReceiverGuid, web, ListTypes.GenericList);

        }


        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPWeb web = (properties.Feature.Parent as SPSite).RootWeb;
            RibbonCustomAction.RemoveAllCustomizations(web, ReceiverGuid);
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
