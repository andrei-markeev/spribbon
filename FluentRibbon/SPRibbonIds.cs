

namespace FluentRibbon
{

public class SPRibbonIds
{

		/// <summary>'Browse' tab.</summary>
		public class Read
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Read";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
			}
		}
		/// <summary>'Edit' tab.</summary>
		public class BDCAdmin
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.BDCAdmin";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'BDC Models' control group.</summary>
				public class ApplicationModelManagement
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.BDCAdmin.ApplicationModelManagement";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ImportModel = "Ribbon.BDCAdmin.ApplicationManagement.ImportModel";
						public const string DeleteModel = "Ribbon.BDCAdmin.ApplicationManagement.DeleteModel";
						public const string ExportModel = "Ribbon.BDCAdmin.ApplicationManagement.ExportModel";
					}
				}
				/// <summary>'Permissions' control group.</summary>
				public class PermissionManagement
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.BDCAdmin.PermissionManagement";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string SetPermissions = "Ribbon.BDCAdmin.PermissionManagement.SetPermissions";
						public const string AssignAdmins = "Ribbon.BDCAdmin.PermissionManagement.AssignAdmins";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class ApplicationManagement
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.BDCAdmin.ApplicationManagement";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string LobSystemSettings = "Ribbon.BDCAdmin.ApplicationManagement.LobSystemSettings";
						public const string DeleteLobSystem = "Ribbon.BDCAdmin.ApplicationManagement.DeleteLobSystem";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class ActionManagement
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.BDCAdmin.ActionManagement";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Add = "Ribbon.BDCAdmin.ActionManagement.Add";
						public const string Edit = "Ribbon.BDCAdmin.ActionManagement.Edit";
						public const string Delete = "Ribbon.BDCAdmin.ActionManagement.Delete";
					}
				}
				/// <summary>'View' control group.</summary>
				public class ViewManagement
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.BDCAdmin.ViewManagement";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Views = "Ribbon.BDCAdmin.ViewManagement.Views";
					}
				}
			}
		}
		/// <summary>'Edit' tab.</summary>
		public class DocLibListForm_Edit
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.DocLibListForm.Edit";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Commit' control group.</summary>
				public class Commit
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.DocLibListForm.Edit.Commit";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Publish = "Ribbon.DocLibListForm.Edit.Commit.Publish";
						public const string CheckIn = "Ribbon.DocLibListForm.Edit.Commit.CheckIn";
						public const string Cancel = "Ribbon.DocLibListForm.Edit.Commit.Cancel";
					}
				}
				/// <summary>'Clipboard' control group.</summary>
				public class Clipboard
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.DocLibListForm.Edit.Clipboard";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Paste = "Ribbon.DocLibListForm.Edit.Clipboard.Paste";
						public const string Cut = "Ribbon.DocLibListForm.Edit.Clipboard.Cut";
						public const string Copy = "Ribbon.DocLibListForm.Edit.Clipboard.Copy";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.DocLibListForm.Edit.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string DeleteItem = "Ribbon.DocLibListForm.Edit.Actions.DeleteItem";
						public const string CheckIn = "Ribbon.DocLibListForm.Edit.Actions.CheckIn";
						public const string CheckOut = "Ribbon.DocLibListForm.Edit.Actions.CheckOut";
						public const string VersionHistory = "Ribbon.DocLibListForm.Edit.Actions.VersionHistory";
						public const string ExportWebPart = "Ribbon.DocLibListForm.Edit.Actions.ExportWebPart";
						public const string ViewWebPartXml = "Ribbon.DocLibListForm.Edit.Actions.ViewWebPartXml";
						public const string ManagePermissions = "Ribbon.DocLibListForm.Edit.Actions.ManagePermissions";
					}
				}
			}
		}
		/// <summary>'View' tab.</summary>
		public class ListForm_Display
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.ListForm.Display";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Display.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditItem = "Ribbon.ListForm.Display.Manage.EditItem";
						public const string EditSeries = "Ribbon.ListForm.Display.Manage.EditSeries";
						public const string VersionHistory = "Ribbon.ListForm.Display.Manage.VersionHistory";
						public const string ManagePermissions = "Ribbon.ListForm.Display.Manage.ManagePermissions";
						public const string DeleteItem = "Ribbon.ListForm.Display.Manage.DeleteItem";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Display.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string CheckIn = "Ribbon.ListForm.Display.Manage.CheckIn";
						public const string CheckOut = "Ribbon.ListForm.Display.Manage.CheckOut";
						public const string Alert = "Ribbon.ListForm.Display.Manage.Alert";
						public const string ApproveReject = "Ribbon.ListForm.Display.Manage.ApproveReject";
						public const string ManageCopies = "Ribbon.ListForm.Display.Manage.ManageCopies";
						public const string Workflows = "Ribbon.ListForm.Display.Manage.Workflows";
						public const string EnterFolder = "Ribbon.ListForm.Display.Manage.EnterFolder";
						public const string ClaimReleaseTask = "Ribbon.ListForm.Display.Manage.ClaimReleaseTask";
						public const string DistributionListsApproval = "Ribbon.ListForm.Display.Manage.DistributionListsApproval";
						public const string DeleteItemVersion = "Ribbon.ListForm.Display.Manage.DeleteItemVersion";
						public const string RestoreItemVersion = "Ribbon.ListForm.Display.Manage.RestoreItemVersion";
					}
				}
				/// <summary>'Health' control group.</summary>
				public class HealthActions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Display.HealthActions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string HealthRuleRunNow = "Ribbon.ListForm.Display.HealthActions.HealthRuleRunNow";
						public const string HealthReportRunNow = "Ribbon.ListForm.Display.HealthActions.HealthReportRunNow";
						public const string HealthReportRepair = "Ribbon.ListForm.Display.HealthActions.HealthReportRepair";
					}
				}
				/// <summary>'Commands' control group.</summary>
				public class Solution
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Display.Solution";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Activate = "Ribbon.ListForm.Display.Solution.Activate";
						public const string Deactivate = "Ribbon.ListForm.Display.Solution.Deactivate";
						public const string Upgrade = "Ribbon.ListForm.Display.Solution.Upgrade";
					}
				}
			}
		}
		/// <summary>'Edit' tab.</summary>
		public class ListForm_Edit
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.ListForm.Edit";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Commit' control group.</summary>
				public class Commit
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Edit.Commit";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Publish = "Ribbon.ListForm.Edit.Commit.Publish";
						public const string Cancel = "Ribbon.ListForm.Edit.Commit.Cancel";
					}
				}
				/// <summary>'Clipboard' control group.</summary>
				public class Clipboard
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Edit.Clipboard";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Paste = "Ribbon.ListForm.Edit.Clipboard.Paste";
						public const string Cut = "Ribbon.ListForm.Edit.Clipboard.Cut";
						public const string Copy = "Ribbon.ListForm.Edit.Clipboard.Copy";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListForm.Edit.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string DeleteItem = "Ribbon.ListForm.Edit.Actions.DeleteItem";
						public const string EditSeries = "Ribbon.ListForm.Edit.Actions.EditSeries";
						public const string ClaimReleaseTask = "Ribbon.ListForm.Edit.Actions.ClaimReleaseTask";
						public const string AttachFile = "Ribbon.ListForm.Edit.Actions.AttachFile";
						public const string DistributionListsApproval = "Ribbon.ListForm.Edit.Actions.DistributionListsApproval";
					}
				}
			}
		}
		/// <summary>'Edit' tab.</summary>
		public class PostListForm_Edit
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.PostListForm.Edit";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Commit' control group.</summary>
				public class Commit
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.PostListForm.Edit.Commit";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Publish = "Ribbon.PostListForm.Edit.Commit.Publish";
						public const string SaveAsDraft = "Ribbon.PostListForm.Edit.Commit.SaveAsDraft";
						public const string Cancel = "Ribbon.PostListForm.Edit.Commit.Cancel";
					}
				}
				/// <summary>'Clipboard' control group.</summary>
				public class Clipboard
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.PostListForm.Edit.Clipboard";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Paste = "Ribbon.PostListForm.Edit.Clipboard.Paste";
						public const string Cut = "Ribbon.PostListForm.Edit.Clipboard.Cut";
						public const string Copy = "Ribbon.PostListForm.Edit.Clipboard.Copy";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.PostListForm.Edit.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string DeleteItem = "Ribbon.PostListForm.Edit.Actions.DeleteItem";
						public const string EditSeries = "Ribbon.PostListForm.Edit.Actions.EditSeries";
					}
				}
			}
		}
		/// <summary>'Service Applications' tab.</summary>
		public class SvcApp
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.SvcApp";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Create' control group.</summary>
				public class Create
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SvcApp.Create";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string New = "Ribbon.SvcApp.Create.New";
						public const string Connect = "Ribbon.SvcApp.Create.Connect";
					}
				}
				/// <summary>'Operations' control group.</summary>
				public class Operations
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SvcApp.Operations";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Delete = "Ribbon.SvcApp.Operations.Delete";
						public const string Manage = "Ribbon.SvcApp.Operations.Manage";
						public const string Administrators = "Ribbon.SvcApp.Operations.Administrators";
						public const string Properties = "Ribbon.SvcApp.Operations.Properties";
					}
				}
				/// <summary>'Sharing' control group.</summary>
				public class Sharing
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SvcApp.Sharing";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Publish = "Ribbon.SvcApp.Sharing.Publish";
						public const string Permissions = "Ribbon.SvcApp.Sharing.Permissions";
					}
				}
			}
		}
		/// <summary>'Solutions' tab.</summary>
		public class Solution
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Solution";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'New' control group.</summary>
				public class New
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Solution.New";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Upload = "Ribbon.Solution.All.Upload";
					}
				}
				/// <summary>'Commands' control group.</summary>
				public class All
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Solution.All";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Delete = "Ribbon.Solution.All.Delete";
						public const string Activate = "Ribbon.Solution.All.Activate";
						public const string Deactivate = "Ribbon.Solution.All.Deactivate";
						public const string Upgrade = "Ribbon.Solution.All.Upgrade";
					}
				}
			}
		}
		/// <summary>'Analyze' tab.</summary>
		public class UsageReport
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.UsageReport";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Date Range' control group.</summary>
				public class DateRange
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.UsageReport.DateRange";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Day = "Ribbon.UsageReport.DateRange.Day";
						public const string Month = "Ribbon.UsageReport.DateRange.Month";
					}
				}
			}
		}
		/// <summary>'Page' tab.</summary>
		public class WikiPageTab
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.WikiPageTab";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Edit' control group.</summary>
				public class EditAndCheckout
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WikiPageTab.EditAndCheckout";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string SaveEdit = "Ribbon.WikiPageTab.EditAndCheckout.SaveEdit";
						public const string Checkout = "Ribbon.WikiPageTab.EditAndCheckout.Checkout";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WikiPageTab.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string PageProperties = "Ribbon.WikiPageTab.Manage.PageProperties";
						public const string RenamePage = "Ribbon.WikiPageTab.Manage.RenamePage";
						public const string VersionDiff = "Ribbon.WikiPageTab.Manage.VersionDiff";
						public const string Permissions = "Ribbon.WikiPageTab.Manage.Permissions";
						public const string DeletePage = "Ribbon.WikiPageTab.Manage.DeletePage";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WikiPageTab.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailPageLink = "Ribbon.WikiPageTab.Share.EmailPageLink";
						public const string AlertMe = "Ribbon.WikiPageTab.Share.AlertMe";
					}
				}
				/// <summary>'Page Actions' control group.</summary>
				public class PageActions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WikiPageTab.PageActions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string SetHomePage = "Ribbon.WikiPageTab.PageActions.SetHomePage";
						public const string IncomingLinks = "Ribbon.WikiPageTab.PageActions.IncomingLinks";
					}
				}
				/// <summary>'Page Library' control group.</summary>
				public class LibrarySettings
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WikiPageTab.LibrarySettings";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string LibSettings = "Ribbon.WikiPageTab.LibrarySettings.LibSettings";
						public const string LibraryPermissions = "Ribbon.WikiPageTab.LibrarySettings.LibraryPermissions";
						public const string ViewAllPages = "Ribbon.WikiPageTab.LibrarySettings.ViewAllPages";
					}
				}
			}
		}
		/// <summary>'Publish' tab.</summary>
		public class PublishTab
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.PublishTab";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Publishing' control group.</summary>
				public class Publishing
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.PublishTab.Publishing";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Publish = "Ribbon.PublishTab.Publishing.Publish";
						public const string Approve = "Ribbon.PublishTab.Publishing.Approve";
						public const string Reject = "Ribbon.PublishTab.Publishing.Reject";
					}
				}
				/// <summary>'Workflows' control group.</summary>
				public class Workflow
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.PublishTab.Workflow";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ManageWorkflow = "Ribbon.PublishTab.Workflow.ManageWorkflow";
					}
				}
			}
		}
		/// <summary>'Page' tab.</summary>
		public class WebPartPage
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.WebPartPage";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Edit' control group.</summary>
				public class Edit
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Edit";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Edit = "Ribbon.WebPartPage.Edit.Edit";
					}
				}
				
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditProperties = "Ribbon.WebPartPage.Manage.EditProperties";
						public const string Versions = "Ribbon.WebPartPage.Manage.Versions";
						public const string Permissions = "Ribbon.WebPartPage.Manage.Permissions";
						public const string Delete = "Ribbon.WebPartPage.Manage.Delete";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailPageLink = "Ribbon.WebPartPage.Share.EmailPageLink";
						public const string AlertMe = "Ribbon.WebPartPage.Share.AlertMe";
					}
				}
				/// <summary>'Approval' control group.</summary>
				public class Approval
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Approval";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Approve = "Ribbon.WebPartPage.Approval.Approve";
						public const string Reject = "Ribbon.WebPartPage.Approval.Reject";
					}
				}
				
				public class Workflow
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Workflow";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ManageWorkflow = "Ribbon.WebPartPage.Workflow.ManageWorkflow";
					}
				}
				/// <summary>'Page Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartPage.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditMobilePage = "Ribbon.WebPartPage.Actions.EditMobilePage";
						public const string MakeHomePage = "Ribbon.WebPartPage.Actions.MakeHomePage";
						public const string EditTitleBar = "Ribbon.WebPartPage.Actions.EditTitleBar";
					}
				}
			}
		}
		/// <summary>'Web Applications' tab.</summary>
		public class WebApp
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.WebApp";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Contribute' control group.</summary>
				public class Contribute
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebApp.Contribute";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string New = "Ribbon.WebApp.Contribute.New";
						public const string Extend = "Ribbon.WebApp.Contribute.Extend";
						public const string Delete = "Ribbon.WebApp.Contribute.Delete";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebApp.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Settings = "Ribbon.WebApp.Manage.Settings";
						public const string Features = "Ribbon.WebApp.Manage.Features";
						public const string Paths = "Ribbon.WebApp.Manage.Paths";
						public const string Connections = "Ribbon.WebApp.Manage.Connections";
					}
				}
				/// <summary>'Security' control group.</summary>
				public class Security
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebApp.Security";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Controls_AuthProviders = "Ribbon.WebApp.Security.Controls.AuthProviders";
						public const string Controls_SelfSite = "Ribbon.WebApp.Security.Controls.SelfSite";
						public const string Controls_BlockedFiles = "Ribbon.WebApp.Security.Controls.BlockedFiles";
						public const string Controls_UserPermissions = "Ribbon.WebApp.Security.Controls.UserPermissions";
						public const string Controls_WebPart = "Ribbon.WebApp.Security.Controls.WebPart";
					}
				}
				/// <summary>'Policy' control group.</summary>
				public class Policy
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebApp.Policy";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Controls_GeneralPolicy = "Ribbon.WebApp.Policy.Controls.GeneralPolicy";
						public const string Controls_Anonymous = "Ribbon.WebApp.Policy.Controls.Anonymous";
						public const string Controls_PermissionPolicy = "Ribbon.WebApp.Policy.Controls.PermissionPolicy";
					}
				}
			}
		}
		/// <summary>'Site Collections' tab.</summary>
		public class SiteCollections
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.SiteCollections";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Contribute' control group.</summary>
				public class Contribute
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SiteCollections.Contribute";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string CreateSite = "Ribbon.SiteCollections.Contribute.CreateSite";
						public const string Delete = "Ribbon.SiteCollections.Contribute.Delete";
					}
				}
				/// <summary>'Review' control group.</summary>
				public class Review
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SiteCollections.Review";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewProperties = "Ribbon.SiteCollections.Review.ViewProperties";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.SiteCollections.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Owners = "Ribbon.SiteCollections.Manage.Owners";
						public const string DiskQuota = "Ribbon.SiteCollections.Manage.DiskQuota";
					}
				}
			}
		}
		/// <summary>'Trust Relationships' tab.</summary>
		public class ManageTrust
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.ManageTrust";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Manage' control group.</summary>
				public class Operations
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ManageTrust.Operations";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Create = "Ribbon.ManageTrust.Create";
						public const string Edit = "Ribbon.ManageTrust.Operations.Edit";
						public const string Delete = "Ribbon.ManageTrust.Operations.Delete";
					}
				}
			}
		}
		/// <summary>'Custom Commands' tab.</summary>
		public class CustomCommands
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.CustomCommands";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Custom Commands' control group.</summary>
				public class Commands
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.CustomCommands.Commands";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
					}
				}
			}
		}
		/// <summary>'Format Text' tab.</summary>
		public class EditingTools_CPEditTab
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.EditingTools.CPEditTab";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Edit' control group.</summary>
				public class EditAndCheckout
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.EditAndCheckout";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string SaveEdit = "Ribbon.EditingTools.CPEditTab.EditAndCheckout.SaveEdit";
						public const string Checkout = "Ribbon.EditingTools.CPEditTab.EditAndCheckout.Checkout";
					}
				}
				/// <summary>'Clipboard' control group.</summary>
				public class Clipboard
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Clipboard";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Paste = "Ribbon.EditingTools.CPEditTab.Clipboard.Paste";
						public const string Cut = "Ribbon.EditingTools.CPEditTab.Clipboard.Cut";
						public const string Copy = "Ribbon.EditingTools.CPEditTab.Clipboard.Copy";
						public const string Undo = "Ribbon.EditingTools.CPEditTab.Clipboard.Undo";
					}
				}
				/// <summary>'Font' control group.</summary>
				public class Font
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Font";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Fonts = "Ribbon.EditingTools.CPEditTab.Font.Fonts";
						public const string FontSize = "Ribbon.EditingTools.CPEditTab.Font.FontSize";
						public const string Bold = "Ribbon.EditingTools.CPEditTab.Font.Bold";
						public const string Italics = "Ribbon.EditingTools.CPEditTab.Font.Italics";
						public const string Underline = "Ribbon.EditingTools.CPEditTab.Font.Underline";
						public const string Strikethrough = "Ribbon.EditingTools.CPEditTab.Font.Strikethrough";
						public const string Subscript = "Ribbon.EditingTools.CPEditTab.Font.Subscript";
						public const string Superscript = "Ribbon.EditingTools.CPEditTab.Font.Superscript";
						public const string FontBackgroundColor = "Ribbon.EditingTools.CPEditTab.Font.FontBackgroundColor";
						public const string FontColor = "Ribbon.EditingTools.CPEditTab.Font.FontColor";
						public const string ClearFormat = "Ribbon.EditingTools.CPEditTab.Font.ClearFormat";
					}
				}
				/// <summary>'Paragraph' control group.</summary>
				public class Paragraph
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Paragraph";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Bullets = "Ribbon.EditingTools.CPEditTab.Paragraph.Bullets";
						public const string Numbering = "Ribbon.EditingTools.CPEditTab.Paragraph.Numbering";
						public const string Outdent = "Ribbon.EditingTools.CPEditTab.Paragraph.Outdent";
						public const string Indent = "Ribbon.EditingTools.CPEditTab.Paragraph.Indent";
						public const string LTR = "Ribbon.EditingTools.CPEditTab.Paragraph.LTR";
						public const string RTL = "Ribbon.EditingTools.CPEditTab.Paragraph.RTL";
						public const string AlignLeft = "Ribbon.EditingTools.CPEditTab.Paragraph.AlignLeft";
						public const string AlignCenter = "Ribbon.EditingTools.CPEditTab.Paragraph.AlignCenter";
						public const string AlignRight = "Ribbon.EditingTools.CPEditTab.Paragraph.AlignRight";
						public const string AlignJustify = "Ribbon.EditingTools.CPEditTab.Paragraph.AlignJustify";
					}
				}
				/// <summary>'Styles' control group.</summary>
				public class Styles
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Styles";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Styles = "Ribbon.EditingTools.CPEditTab.Styles.Styles";
					}
				}
				/// <summary>'Layout' control group.</summary>
				public class Layout
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Layout";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string PageLayout = "Ribbon.EditingTools.CPEditTab.Layout.PageLayout";
					}
				}
				/// <summary>'Markup' control group.</summary>
				public class Markup
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPEditTab.Markup";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ElementWithStyle = "Ribbon.EditingTools.CPEditTab.Markup.ElementWithStyle";
						public const string LanguagesLabel = "Ribbon.EditingTools.CPEditTab.Markup.LanguagesLabel";
						public const string Languages = "Ribbon.EditingTools.CPEditTab.Markup.Languages";
						public const string Select = "Ribbon.EditingTools.CPEditTab.Markup.Select";
						public const string Html = "Ribbon.EditingTools.CPEditTab.Markup.Html";
					}
				}
			}
		}
		/// <summary>'Insert' tab.</summary>
		public class EditingTools_CPInsert
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.EditingTools.CPInsert";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Tables' control group.</summary>
				public class Tables
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPInsert.Tables";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Table = "Ribbon.EditingTools.CPInsert.Tables.Table";
					}
				}
				/// <summary>'Media' control group.</summary>
				public class Media
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPInsert.Media";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Image = "Ribbon.EditingTools.CPInsert.Media.Image";
					}
				}
				/// <summary>'Links' control group.</summary>
				public class Links
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPInsert.Links";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Link = "Ribbon.EditingTools.CPInsert.Links.Link";
						public const string UploadFile = "Ribbon.EditingTools.CPInsert.Links.UploadFile";
					}
				}
				/// <summary>'Web Parts' control group.</summary>
				public class WebParts
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.EditingTools.CPInsert.WebParts";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string WebPart = "Ribbon.EditingTools.CPInsert.WebParts.WebPart";
						public const string ExistingList = "Ribbon.EditingTools.CPInsert.WebParts.ExistingList";
						public const string InsertNewList = "Ribbon.EditingTools.CPInsert.WebParts.InsertNewList";
					}
				}
			}
		}
		/// <summary>'Design' tab.</summary>
		public class Image_Image
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Image.Image";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Select' control group.</summary>
				public class Edit
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Image.Image.Edit";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Edit = "Ribbon.Image.Image.Edit.Edit";
					}
				}
				/// <summary>'Properties' control group.</summary>
				public class Properties
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Image.Image.Properties";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string URLLabel = "Ribbon.Image.Image.Properties.URLLabel";
						public const string URL = "Ribbon.Image.Image.Properties.URL";
						public const string AltTextLabel = "Ribbon.Image.Image.Properties.AltTextLabel";
						public const string AltText = "Ribbon.Image.Image.Properties.AltText";
					}
				}
				/// <summary>'Styles' control group.</summary>
				public class Styles
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Image.Image.Styles";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ImageStyles = "Ribbon.Image.Image.Styles.ImageStyles";
					}
				}
				/// <summary>'Arrange' control group.</summary>
				public class Arrange
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Image.Image.Arrange";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ImageArrange = "Ribbon.Image.Image.Arrange.ImageArrange";
					}
				}
				/// <summary>'Size' control group.</summary>
				public class Size
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Image.Image.Size";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string HorizontalSizeLabel = "Ribbon.Image.Image.Size.HorizontalSizeLabel";
						public const string HorizontalSize = "Ribbon.Image.Image.Size.HorizontalSize";
						public const string VertSizeLabel = "Ribbon.Image.Image.Size.VertSizeLabel";
						public const string VerticalSize = "Ribbon.Image.Image.Size.VerticalSize";
						public const string LockAspect = "Ribbon.Image.Image.Size.LockAspect";
					}
				}
			}
		}
		/// <summary>'Documents' tab.</summary>
		public class Document
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Document";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'New' control group.</summary>
				public class New
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.New";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string NewDocument = "Ribbon.Documents.New.NewDocument";
						public const string AddDocument = "Ribbon.Documents.New.AddDocument";
						public const string NewFolder = "Ribbon.Documents.New.NewFolder";
					}
				}
				/// <summary>'Open & Check Out' control group.</summary>
				public class EditCheckout
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.EditCheckout";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditDocument = "Ribbon.Documents.EditCheckout.EditDocument";
						public const string CheckOut = "Ribbon.Documents.EditCheckout.CheckOut";
						public const string CheckIn = "Ribbon.Documents.EditCheckout.CheckIn";
						public const string DiscardCheckOut = "Ribbon.Documents.EditCheckout.DiscardCheckOut";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewProperties = "Ribbon.Documents.Manage.ViewProperties";
						public const string EditProperties = "Ribbon.Documents.Manage.EditProperties";
						public const string ViewVersions = "Ribbon.Documents.Manage.ViewVersions";
						public const string ManagePermissions = "Ribbon.Documents.Manage.ManagePermissions";
						public const string Delete = "Ribbon.Documents.Manage.Delete";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailItemLink = "Ribbon.Documents.Share.EmailItemLink";
						public const string AlertMe = "Ribbon.Documents.Share.AlertMe";
					}
				}
				/// <summary>'Copies' control group.</summary>
				public class Copies
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.Copies";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Download = "Ribbon.Documents.Copies.Download";
						public const string SendTo = "Ribbon.Documents.Copies.SendTo";
						public const string ManageCopies = "Ribbon.Documents.Copies.ManageCopies";
						public const string GoToSourceItem = "Ribbon.Documents.Copies.GoToSourceItem";
					}
				}
				/// <summary>'Workflows' control group.</summary>
				public class Workflow
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.Workflow";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewWorkflows = "Ribbon.Documents.Workflow.ViewWorkflows";
						public const string Publish = "Ribbon.Documents.Workflow.Publish";
						public const string Unpublish = "Ribbon.Documents.Workflow.Unpublish";
						public const string Moderate = "Ribbon.Documents.Workflow.Moderate";
						public const string CancelApproval = "Ribbon.Documents.Workflow.CancelApproval";
					}
				}
				/// <summary>'Quick Steps' control group.</summary>
				public class QuickSteps
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.QuickSteps";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class FormActions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Documents.FormActions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string RepairItems = "Ribbon.Documents.FormActions.RepairItems";
						public const string RepairAllItems = "Ribbon.Documents.FormActions.RepairAllItems";
						public const string MergeDocuments = "Ribbon.Documents.FormActions.MergeDocuments";
					}
				}
			}
		}
		/// <summary>'Library' tab.</summary>
		public class Library
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Library";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'View Format' control group.</summary>
				public class ViewFormat
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.ViewFormat";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Standard = "Ribbon.Library.ViewFormat.Standard";
						public const string Datasheet = "Ribbon.Library.ViewFormat.Datasheet";
					}
				}
				/// <summary>'Datasheet' control group.</summary>
				public class Datasheet
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.Datasheet";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string NewRow = "Ribbon.Library.Datasheet.NewRow";
						public const string ShowTaskPane = "Ribbon.Library.Datasheet.ShowTaskPane";
						public const string ShowTotals = "Ribbon.Library.Datasheet.ShowTotals";
						public const string RefreshData = "Ribbon.Library.Datasheet.RefreshData";
					}
				}
				/// <summary>'Manage Views' control group.</summary>
				public class CustomViews
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.CustomViews";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AllMeetings = "Ribbon.Library.Actions.AllMeetings";
						public const string CreateView = "Ribbon.Library.CustomViews.CreateView";
						public const string ModifyView = "Ribbon.Library.CustomViews.ModifyView";
						public const string CreateColumn = "Ribbon.Library.CustomViews.CreateColumn";
						public const string NavigateUp = "Ribbon.Library.CustomViews.NavigateUp";
						public const string CurrentView = "Ribbon.Library.CustomViews.CurrentView";
						public const string DisplayView = "Ribbon.Library.CustomViews.DisplayView";
						public const string PreviousPage = "Ribbon.Library.CustomViews.PreviousPage";
						public const string CurrentPage = "Ribbon.Library.CustomViews.CurrentPage";
						public const string NextPage = "Ribbon.Library.CustomViews.NextPage";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailLibraryLink = "Ribbon.Library.Share.EmailLibraryLink";
						public const string AlertMe = "Ribbon.Library.Share.AlertMe";
						public const string ViewRSSFeed = "Ribbon.Library.Share.ViewRSSFeed";
					}
				}
				/// <summary>'Connect & Export' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TakeOfflineToClient = "Ribbon.Library.Actions.TakeOfflineToClient";
						public const string ConnectToClient = "Ribbon.Library.Actions.ConnectToClient";
						public const string ExportToSpreadsheet = "Ribbon.Library.Actions.ExportToSpreadsheet";
						public const string OpenWithExplorer = "Ribbon.Library.Actions.OpenWithExplorer";
					}
				}
				/// <summary>'Customize Library' control group.</summary>
				public class CustomizeLibrary
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.CustomizeLibrary";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditDefaultForms = "Ribbon.Library.CustomizeLibrary.EditDefaultForms";
						public const string EditList = "Ribbon.Library.CustomizeLibrary.EditList";
						public const string AddButton = "Ribbon.Library.CustomizeLibrary.AddButton";
					}
				}
				/// <summary>'Settings' control group.</summary>
				public class Settings
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Library.Settings";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string DocumentLibrarySettings = "Ribbon.Library.Settings.DocumentLibrarySettings";
						public const string LibraryPermissions = "Ribbon.Library.Settings.LibraryPermissions";
						public const string ManageWorkflows = "Ribbon.Library.Settings.ManageWorkflows";
					}
				}
			}
		}
		/// <summary>'Items' tab.</summary>
		public class ListItem
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.ListItem";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'New' control group.</summary>
				public class New
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.New";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string NewListItem = "Ribbon.ListItem.New.NewListItem";
						public const string NewFolder = "Ribbon.ListItem.New.NewFolder";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewProperties = "Ribbon.ListItem.Manage.ViewProperties";
						public const string EditProperties = "Ribbon.ListItem.Manage.EditProperties";
						public const string ViewVersions = "Ribbon.ListItem.Manage.ViewVersions";
						public const string ManagePermissions = "Ribbon.ListItem.Manage.ManagePermissions";
						public const string Delete = "Ribbon.ListItem.Manage.Delete";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AttachFile = "Ribbon.ListItem.Actions.AttachFile";
						public const string ChangeItemOrder = "Ribbon.ListItem.Actions.ChangeItemOrder";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AlertMe = "Ribbon.ListItem.Share.AlertMe";
					}
				}
				/// <summary>'Workflows' control group.</summary>
				public class Workflow
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.Workflow";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewWorkflows = "Ribbon.ListItem.Workflow.ViewWorkflows";
						public const string Moderate = "Ribbon.ListItem.Workflow.Moderate";
					}
				}
				/// <summary>'Quick Steps' control group.</summary>
				public class QuickSteps
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.ListItem.QuickSteps";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
					}
				}
			}
		}
		/// <summary>'List' tab.</summary>
		public class List
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.List";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'View Format' control group.</summary>
				public class ViewFormat
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.ViewFormat";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Standard = "Ribbon.List.ViewFormat.Standard";
						public const string Datasheet = "Ribbon.List.ViewFormat.Datasheet";
					}
				}
				/// <summary>'Datasheet' control group.</summary>
				public class Datasheet
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.Datasheet";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string NewRow = "Ribbon.List.Datasheet.NewRow";
						public const string ShowTaskPane = "Ribbon.List.Datasheet.ShowTaskPane";
						public const string ShowTotals = "Ribbon.List.Datasheet.ShowTotals";
						public const string RefreshData = "Ribbon.List.Datasheet.RefreshData";
					}
				}
				/// <summary>'Gantt View' control group.</summary>
				public class GanttView
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.GanttView";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ZoomIn = "Ribbon.List.GanttView.ZoomIn";
						public const string ZoomOut = "Ribbon.List.GanttView.ZoomOut";
						public const string ScrollToTask = "Ribbon.List.GanttView.ScrollToTask";
					}
				}
				/// <summary>'Manage Views' control group.</summary>
				public class CustomViews
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.CustomViews";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AllMeetings = "Ribbon.List.Actions.AllMeetings";
						public const string CreateView = "Ribbon.List.CustomViews.CreateView";
						public const string ModifyView = "Ribbon.List.CustomViews.ModifyView";
						public const string CreateColumn = "Ribbon.List.CustomViews.CreateColumn";
						public const string NavigateUp = "Ribbon.List.CustomViews.NavigateUp";
						public const string CurrentView = "Ribbon.List.CustomViews.CurrentView";
						public const string DisplayView = "Ribbon.List.CustomViews.DisplayView";
						public const string PreviousPage = "Ribbon.List.CustomViews.PreviousPage";
						public const string CurrentPage = "Ribbon.List.CustomViews.CurrentPage";
						public const string NextPage = "Ribbon.List.CustomViews.NextPage";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailLibraryLink = "Ribbon.List.Share.EmailLibraryLink";
						public const string AlertMe = "Ribbon.List.Share.AlertMe";
						public const string ViewRSSFeed = "Ribbon.List.Share.ViewRSSFeed";
					}
				}
				/// <summary>'Connect & Export' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TakeOfflineToClient = "Ribbon.List.Actions.TakeOfflineToClient";
						public const string ConnectToClient = "Ribbon.List.Actions.ConnectToClient";
						public const string ExportToSpreadsheet = "Ribbon.List.Actions.ExportToSpreadsheet";
						public const string CreateVisioDiagram = "Ribbon.List.Actions.CreateVisioDiagram";
						public const string OpenWithAccess = "Ribbon.List.Actions.OpenWithAccess";
						public const string ExportToProject = "Ribbon.List.Actions.ExportToProject";
					}
				}
				/// <summary>'Customize List' control group.</summary>
				public class CustomizeList
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.CustomizeList";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditDefaultForms = "Ribbon.List.CustomizeList.EditDefaultForms";
						public const string EditList = "Ribbon.List.CustomizeList.EditList";
						public const string AddButton = "Ribbon.List.CustomizeList.AddButton";
					}
				}
				/// <summary>'Settings' control group.</summary>
				public class Settings
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.List.Settings";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ListSettings = "Ribbon.List.Settings.ListSettings";
						public const string ListPermissions = "Ribbon.List.Settings.ListPermissions";
						public const string ManageWorkflows = "Ribbon.List.Settings.ManageWorkflows";
					}
				}
			}
		}
		/// <summary>'Format' tab.</summary>
		public class Link_Link
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Link.Link";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Link' control group.</summary>
				public class Link
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Link.Link.Link";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string RemoveLink = "Ribbon.Link.Link.Link.RemoveLink";
					}
				}
				/// <summary>'Properties' control group.</summary>
				public class Properties
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Link.Link.Properties";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string LinkAddressLabel = "Ribbon.Link.Link.Properties.LinkAddressLabel";
						public const string LinkAddress = "Ribbon.Link.Link.Properties.LinkAddress";
						public const string LinkTooltipLabel = "Ribbon.Link.Link.Properties.LinkTooltipLabel";
						public const string LinkTooltip = "Ribbon.Link.Link.Properties.LinkTooltip";
					}
				}
				/// <summary>'Behavior' control group.</summary>
				public class Behavior
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Link.Link.Behavior";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string PopUp = "Ribbon.Link.Link.Behavior.PopUp";
						public const string DisplayIcon = "Ribbon.Link.Link.Behavior.DisplayIcon";
					}
				}
			}
		}
		/// <summary>'Layout' tab.</summary>
		public class Table_Layout
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Table.Layout";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Table' control group.</summary>
				public class Table
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Layout.Table";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TableGridLines = "Ribbon.Table.Layout.Table.TableGridLines";
					}
				}
				/// <summary>'Merge' control group.</summary>
				public class Cells
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Layout.Cells";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string MergeCells = "Ribbon.Table.Layout.Cells.MergeCells";
						public const string Split = "Ribbon.Table.Layout.Cells.Split";
					}
				}
				/// <summary>'Rows & Columns' control group.</summary>
				public class RowsCols
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Layout.RowsCols";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string InsertAbove = "Ribbon.Table.Layout.RowsCols.InsertAbove";
						public const string InsertBelow = "Ribbon.Table.Layout.RowsCols.InsertBelow";
						public const string InsertLeft = "Ribbon.Table.Layout.RowsCols.InsertLeft";
						public const string InsertRight = "Ribbon.Table.Layout.RowsCols.InsertRight";
						public const string Delete = "Ribbon.Table.Layout.RowsCols.Delete";
					}
				}
				/// <summary>'Width & Height' control group.</summary>
				public class Properties
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Layout.Properties";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TableWidthLabel = "Ribbon.Table.Layout.Properties.TableWidthLabel";
						public const string TableHeightLabel = "Ribbon.Table.Layout.Properties.TableHeightLabel";
						public const string TableWidth = "Ribbon.Table.Layout.Properties.TableWidth";
						public const string TableHeight = "Ribbon.Table.Layout.Properties.TableHeight";
						public const string ColumnWidthLabel = "Ribbon.Table.Layout.Properties.ColumnWidthLabel";
						public const string RowHeightLabel = "Ribbon.Table.Layout.Properties.RowHeightLabel";
						public const string ColumnWidth = "Ribbon.Table.Layout.Properties.ColumnWidth";
						public const string RowHeight = "Ribbon.Table.Layout.Properties.RowHeight";
					}
				}
				/// <summary>'Properties' control group.</summary>
				public class Summary
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Layout.Summary";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string SummaryLabel = "Ribbon.Table.Layout.Summary.SummaryLabel";
						public const string Summary = "Ribbon.Table.Layout.Summary.Summary";
					}
				}
			}
		}
		/// <summary>'Design' tab.</summary>
		public class Table_Design
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Table.Design";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Table Style Options' control group.</summary>
				public class StyleOptions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Design.StyleOptions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TableHead = "Ribbon.Table.Design.StyleOptions.TableHead";
						public const string TableFirstCol = "Ribbon.Table.Design.StyleOptions.TableFirstCol";
						public const string TableLastRow = "Ribbon.Table.Design.StyleOptions.TableLastRow";
						public const string TableLastCol = "Ribbon.Table.Design.StyleOptions.TableLastCol";
					}
				}
				/// <summary>'Table Styles' control group.</summary>
				public class Style
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Table.Design.Style";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string TableStyles = "Ribbon.Table.Design.Style.TableStyles";
					}
				}
			}
		}
		/// <summary>'Insert' tab.</summary>
		public class WebPartInsert_Tab
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.WebPartInsert.Tab";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Text' control group.</summary>
				public class Text
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartInsert.Text";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Text = "Ribbon.WebPartInsert.Text.Text";
					}
				}
				/// <summary>'Media' control group.</summary>
				public class Media
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartInsert.Media";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Image = "Ribbon.WebPartInsert.Media.Image";
					}
				}
				/// <summary>'Relationships' control group.</summary>
				public class InsertRelatedDataToListForm
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartInsert.InsertRelatedDataToListForm";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string RelatedWebPart = "Ribbon.WebPartInsert.InsertRelatedDataToListForm.RelatedWebPart";
					}
				}
				/// <summary>'Web Parts' control group.</summary>
				public class WebParts
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartInsert.WebParts";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string WebPart = "Ribbon.WebPartInsert.WebParts.WebPart";
						public const string ExistingList = "Ribbon.WebPartInsert.WebParts.ExistingList";
					}
				}
			}
		}
		/// <summary>'Options' tab.</summary>
		public class WebPartOption
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.WebPartOption";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Properties' control group.</summary>
				public class Properties
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartOption.Properties";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Modify = "Ribbon.WebPartOption.Commands.Modify";
					}
				}
				/// <summary>'Relationships' control group.</summary>
				public class InsertRelatedDataToListView
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartOption.InsertRelatedDataToListView";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string RelatedWebPart = "Ribbon.WebPartOption.InsertRelatedDataToListView.RelatedWebPart";
					}
				}
				/// <summary>'State' control group.</summary>
				public class Commands
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.WebPartOption.Commands";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string Minimize = "Ribbon.WebPartOption.Commands.Minimize";
						public const string Restore = "Ribbon.WebPartOption.Commands.Restore";
						public const string Delete = "Ribbon.WebPartOption.Commands.Delete";
					}
				}
			}
		}
		/// <summary>'Events' tab.</summary>
		public class Calendar_Events
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Calendar.Events";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'New' control group.</summary>
				public class New
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Events.New";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string NewListItem = "Ribbon.Calendar.Events.New.NewListItem";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Events.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewProperties = "Ribbon.Calendar.Events.Manage.ViewProperties";
						public const string EditProperties = "Ribbon.Calendar.Events.Manage.EditProperties";
						public const string ViewVersions = "Ribbon.Calendar.Events.Manage.ViewVersions";
						public const string ManagePermissions = "Ribbon.Calendar.Events.Manage.ManagePermissions";
						public const string Delete = "Ribbon.Calendar.Events.Manage.Delete";
					}
				}
				/// <summary>'Actions' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Events.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AttachFile = "Ribbon.Calendar.Events.Actions.AttachFile";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Events.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AlertMe = "Ribbon.Calendar.Events.Share.AlertMe";
					}
				}
				/// <summary>'Workflows' control group.</summary>
				public class Workflow
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Events.Workflow";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ViewWorkflows = "Ribbon.Calendar.Events.Workflow.ViewWorkflows";
						public const string Moderate = "Ribbon.Calendar.Events.Workflow.Moderate";
					}
				}
			}
		}
		/// <summary>'Calendar' tab.</summary>
		public class Calendar_Calendar
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Calendar.Calendar";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Selector' control group.</summary>
				public class Selector
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Selector";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string People = "Ribbon.Calendar.Calendar.Selector.People";
						public const string Resource = "Ribbon.Calendar.Calendar.Selector.Resource";
					}
				}
				/// <summary>'Scope' control group.</summary>
				public class Scope
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Scope";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string DayGroup = "Ribbon.Calendar.Calendar.Scope.DayGroup";
						public const string WeekGroup = "Ribbon.Calendar.Calendar.Scope.WeekGroup";
						public const string Day = "Ribbon.Calendar.Calendar.Scope.Day";
						public const string Week = "Ribbon.Calendar.Calendar.Scope.Week";
						public const string Month = "Ribbon.Calendar.Calendar.Scope.Month";
					}
				}
				/// <summary>'Expand' control group.</summary>
				public class Expander
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Expander";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ExpandAll = "Ribbon.Calendar.Calendar.Expander.ExpandAll";
						public const string CollapseAll = "Ribbon.Calendar.Calendar.Expander.CollapseAll";
					}
				}
				/// <summary>'Manage Views' control group.</summary>
				public class CustomViews
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.CustomViews";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AddCalendar = "Ribbon.Calendar.Calendar.CustomViews.AddCalendar";
						public const string CreateView = "Ribbon.Calendar.Calendar.CustomViews.CreateView";
						public const string ModifyView = "Ribbon.Calendar.Calendar.CustomViews.ModifyView";
						public const string CreateColumn = "Ribbon.Calendar.Calendar.CustomViews.CreateColumn";
						public const string CurrentView = "Ribbon.Calendar.Calendar.CustomViews.CurrentView";
						public const string DisplayView = "Ribbon.Calendar.Calendar.CustomViews.DisplayView";
					}
				}
				/// <summary>'Share & Track' control group.</summary>
				public class Share
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Share";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EmailLibraryLink = "Ribbon.Calendar.Calendar.Share.EmailLibraryLink";
						public const string AlertMe = "Ribbon.Calendar.Calendar.Share.AlertMe";
						public const string ViewRSSFeed = "Ribbon.Calendar.Calendar.Share.ViewRSSFeed";
					}
				}
				/// <summary>'Connect & Export' control group.</summary>
				public class Actions
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Actions";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ConnectToClient = "Ribbon.Calendar.Calendar.Actions.ConnectToClient";
						public const string ExportToSpreadsheet = "Ribbon.Calendar.Calendar.Actions.ExportToSpreadsheet";
						public const string OpenWithAccess = "Ribbon.Calendar.Calendar.Actions.OpenWithAccess";
					}
				}
				/// <summary>'Customize List' control group.</summary>
				public class CustomizeList
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.CustomizeList";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditList = "Ribbon.Calendar.Calendar.CustomizeList.EditList";
						public const string EditDefaultForms = "Ribbon.Calendar.Calendar.CustomizeList.EditDefaultForms";
					}
				}
				/// <summary>'Settings' control group.</summary>
				public class Settings
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Calendar.Calendar.Settings";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ListSettings = "Ribbon.Calendar.Calendar.Settings.ListSettings";
						public const string ManageWorkflows = "Ribbon.Calendar.Calendar.Settings.ManageWorkflows";
						public const string ListPermissions = "Ribbon.Calendar.Calendar.Settings.ListPermissions";
					}
				}
			}
		}
		/// <summary>'Edit' tab.</summary>
		public class Permission
		{
			//<summary>Id of the tab</summary>
			public const string Id = "Ribbon.Permission";
			//<summary>Inner groups of controls</summary>
			public class Groups
			{
				/// <summary>'Inheritance' control group.</summary>
				public class Parent
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Permission.Parent";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string ManageParent = "Ribbon.Permission.Parent.ManageParent";
						public const string Inherit = "Ribbon.Permission.Manage.Inherit";
						public const string StopInherit = "Ribbon.Permission.Manage.StopInherit";
					}
				}
				/// <summary>'Grant' control group.</summary>
				public class Add
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Permission.Add";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AddUser = "Ribbon.Permission.Add.AddUser";
						public const string NewGroup = "Ribbon.Permission.Add.NewGroup";
					}
				}
				/// <summary>'Modify' control group.</summary>
				public class Modify
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Permission.Modify";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string EditUsrPerm = "Ribbon.Permission.Modify.EditUsrPerm";
						public const string RemovePerms = "Ribbon.Permission.Modify.RemovePerms";
					}
				}
				/// <summary>'Check' control group.</summary>
				public class Check
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Permission.Check";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string CheckUsrPerm = "Ribbon.Permission.Check.CheckUsrPerm";
					}
				}
				/// <summary>'Manage' control group.</summary>
				public class Manage
				{
					//<summary>Id of the group</summary>
					public const string Id = "Ribbon.Permission.Manage";
					//<summary>Ids of controls inside the group. Inner controls are not presented for now</summary>
					public class ControlIds
					{
						public const string AnonyAccess = "Ribbon.Permission.Manage.AnonyAccess";
						public const string PermLevels = "Ribbon.Permission.Manage.PermLevels";
						public const string ManageAccReq = "Ribbon.Permission.Manage.ManageAccReq";
						public const string SiteColAdmin = "Ribbon.Permission.Manage.SiteColAdmin";
					}
				}
			}
		}


}
}