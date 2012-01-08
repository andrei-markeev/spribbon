
using System;
using Microsoft.SharePoint.Utilities;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;

namespace FluentRibbon.Libraries
{
	/// <summary>
    /// This library contains control definitions
	/// </summary>
	public partial class ControlLibrary
	{
		/// <summary>
		/// OOTB SharePoint ribbon buttons.
		/// </summary>
		public class StandardButtons
		{

			/// <summary>Buttons on the 'Edit' tab.</summary>
			public class BDCAdmin
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Import' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ApplicationModelManagement_ImportModel(string javascript)
				{
					return ApplicationModelManagement_ImportModel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Import' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ApplicationModelManagement_ImportModel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCImport;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCImport", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCImportAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ApplicationModelManagement_DeleteModel(string javascript)
				{
					return ApplicationModelManagement_DeleteModel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ApplicationModelManagement_DeleteModel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCDelete;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDelete", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDeleteAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Export' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ApplicationModelManagement_ExportModel(string javascript)
				{
					return ApplicationModelManagement_ExportModel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Export' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ApplicationModelManagement_ExportModel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCExport;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCExport", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCExportAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Set Object Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition PermissionManagement_SetPermissions(string javascript)
				{
					return PermissionManagement_SetPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Set Object Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition PermissionManagement_SetPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCSetPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCSetPermissions", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCSetPermissionsAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Set Metadata Store Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition PermissionManagement_AssignAdmins(string javascript)
				{
					return PermissionManagement_AssignAdmins(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Set Metadata Store Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition PermissionManagement_AssignAdmins(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCAssignAdminsLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCAssignAdminsLabel", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCAssignAdminsAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Settings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ApplicationManagement_LobSystemSettings(string javascript)
				{
					return ApplicationManagement_LobSystemSettings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Settings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ApplicationManagement_LobSystemSettings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCSettings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCSettings", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCSettingsAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ApplicationManagement_DeleteLobSystem(string javascript)
				{
					return ApplicationManagement_DeleteLobSystem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ApplicationManagement_DeleteLobSystem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCDelete;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDelete", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDeleteInManageTabAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Add' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ActionManagement_Add(string javascript)
				{
					return ActionManagement_Add(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Add' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ActionManagement_Add(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCAddAction;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 1
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCAddAction", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCAddActionAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ActionManagement_Edit(string javascript)
				{
					return ActionManagement_Edit(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ActionManagement_Edit(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCEditAction;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCEditAction", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCEditActionAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition ActionManagement_Delete(string javascript)
				{
					return ActionManagement_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition ActionManagement_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core, cui_BDCDeleteAction;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDeleteAction", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_BDCDeleteActionAltText", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Edit' tab.</summary>
			public class DocLibListForm_Edit
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Save' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Publish(string javascript)
				{
					return Commit_Publish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Save' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Publish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormSave;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormSave;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormSave;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check In' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_CheckIn(string javascript)
				{
					return Commit_CheckIn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check In' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_CheckIn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckin;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cancel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Cancel(string javascript)
				{
					return Commit_Cancel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cancel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Cancel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormCancel;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Paste' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript)
				{
					return Clipboard_Paste(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Paste' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPasteMenu;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cut' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript)
				{
					return Clipboard_Cut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cut' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCut;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Copy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript)
				{
					return Clipboard_Copy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Copy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 0,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCopy;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript)
				{
					return Actions_DeleteItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDeleteItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check In' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_CheckIn(string javascript)
				{
					return Actions_CheckIn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check In' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_CheckIn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckin;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check Out' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_CheckOut(string javascript)
				{
					return Actions_CheckOut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check Out' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_CheckOut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckout;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Version History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_VersionHistory(string javascript)
				{
					return Actions_VersionHistory(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Version History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_VersionHistory(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Export' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ExportWebPart(string javascript)
				{
					return Actions_ExportWebPart(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Export' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ExportWebPart(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocListFormEditExportWebPart;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocListFormEditExportWebPart;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocListFormEditExportWebPart;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'View Xml' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ViewWebPartXml(string javascript)
				{
					return Actions_ViewWebPartXml(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'View Xml' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ViewWebPartXml(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocListFormEditViewWebPartXml;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocListFormEditViewWebPartXml;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocListFormEditViewWebPartXml;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ManagePermissions(string javascript)
				{
					return Actions_ManagePermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ManagePermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayManagePermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayManagePermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'View' tab.</summary>
			public class ListForm_Display
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_EditItem(string javascript)
				{
					return Manage_EditItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_EditItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayEditItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Series' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_EditSeries(string javascript)
				{
					return Manage_EditSeries(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Series' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_EditSeries(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayEditSeries;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Version History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_VersionHistory(string javascript)
				{
					return Manage_VersionHistory(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Version History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_VersionHistory(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript)
				{
					return Manage_ManagePermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayManagePermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayManagePermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_DeleteItem(string javascript)
				{
					return Manage_DeleteItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_DeleteItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDeleteItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check In' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_CheckIn(string javascript)
				{
					return Actions_CheckIn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check In' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_CheckIn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckin;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check Out' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_CheckOut(string javascript)
				{
					return Actions_CheckOut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check Out' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_CheckOut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckout;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Alert Me' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_Alert(string javascript)
				{
					return Actions_Alert(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Alert Me' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_Alert(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayAlert;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAlertMe;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAlertMe;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve/Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ApproveReject(string javascript)
				{
					return Actions_ApproveReject(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve/Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ApproveReject(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemApproveReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Copies' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ManageCopies(string javascript)
				{
					return Actions_ManageCopies(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Copies' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ManageCopies(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButManageCopies;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButManageCopies;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButManageCopies;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_Workflows(string javascript)
				{
					return Actions_Workflows(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_Workflows(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Open' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_EnterFolder(string javascript)
				{
					return Actions_EnterFolder(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Open' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_EnterFolder(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEnterFolder;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEnterFolder;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayEnterFolder;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Claim Release' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ClaimReleaseTask(string javascript)
				{
					return Actions_ClaimReleaseTask(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Claim Release' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ClaimReleaseTask(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Distribution Approval' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DistributionListsApproval(string javascript)
				{
					return Actions_DistributionListsApproval(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Distribution Approval' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DistributionListsApproval(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item Version' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DeleteItemVersion(string javascript)
				{
					return Actions_DeleteItemVersion(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item Version' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DeleteItemVersion(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDeleteItemVersion;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDeleteItemVersion;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayDeleteItemVersion;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Restore Item Version' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_RestoreItemVersion(string javascript)
				{
					return Actions_RestoreItemVersion(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Restore Item Version' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_RestoreItemVersion(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayRestoreItemVersion;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayRestoreItemVersion;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayRestoreItemVersion;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Run Now' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition HealthActions_HealthRuleRunNow(string javascript)
				{
					return HealthActions_HealthRuleRunNow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Run Now' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition HealthActions_HealthRuleRunNow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthRuleRunNow;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthRuleRunNow;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayHealthRuleRunNow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Reanalyze Now' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition HealthActions_HealthReportRunNow(string javascript)
				{
					return HealthActions_HealthReportRunNow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Reanalyze Now' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition HealthActions_HealthReportRunNow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthReportRunNow;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthReportRunNow;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayHealthReportRunNow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Repair Automatically' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition HealthActions_HealthReportRepair(string javascript)
				{
					return HealthActions_HealthReportRepair(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Repair Automatically' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition HealthActions_HealthReportRepair(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthReportRepair;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayHealthReportRepair;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayHealthReportRepair;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Activate' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Solution_Activate(string javascript)
				{
					return Solution_Activate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Activate' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Solution_Activate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandActivate;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/edit.gif",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandActivate;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandActivate;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Deactivate' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Solution_Deactivate(string javascript)
				{
					return Solution_Deactivate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Deactivate' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Solution_Deactivate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDeactivate;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/edit.gif",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDeactivate;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandDeactivate;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Upgrade' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Solution_Upgrade(string javascript)
				{
					return Solution_Upgrade(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Upgrade' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Solution_Upgrade(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandUpgrade;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/edit.gif",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandUpgrade;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandUpgrade;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Edit' tab.</summary>
			public class ListForm_Edit
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Save' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Publish(string javascript)
				{
					return Commit_Publish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Save' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Publish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormSave;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormSave;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormSave;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cancel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Cancel(string javascript)
				{
					return Commit_Cancel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cancel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Cancel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormCancel;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Paste' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript)
				{
					return Clipboard_Paste(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Paste' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPasteMenu;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cut' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript)
				{
					return Clipboard_Cut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cut' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCut;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Copy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript)
				{
					return Clipboard_Copy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Copy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 0,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCopy;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript)
				{
					return Actions_DeleteItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDeleteItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Series' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_EditSeries(string javascript)
				{
					return Actions_EditSeries(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Series' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_EditSeries(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayEditSeries;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Claim Release' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ClaimReleaseTask(string javascript)
				{
					return Actions_ClaimReleaseTask(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Claim Release' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ClaimReleaseTask(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayClaimReleaseTask;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Attach File' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript)
				{
					return Actions_AttachFile(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Attach File' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAttachFile;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Distribution Approval' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DistributionListsApproval(string javascript)
				{
					return Actions_DistributionListsApproval(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Distribution Approval' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DistributionListsApproval(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayDistributionListsApproval;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Edit' tab.</summary>
			public class PostListForm_Edit
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Publish' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Publish(string javascript)
				{
					return Commit_Publish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Publish' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Publish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPostFormPublish;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPostFormPublish;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPostFormPublish;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Save As Draft' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_SaveAsDraft(string javascript)
				{
					return Commit_SaveAsDraft(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Save As Draft' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_SaveAsDraft(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPostFormSaveAsDraft;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 1
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPostFormSaveAsDraft;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPostFormSaveAsDraft;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cancel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commit_Cancel(string javascript)
				{
					return Commit_Cancel(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cancel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commit_Cancel(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormCancel;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPostFormCancel;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Paste' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript)
				{
					return Clipboard_Paste(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Paste' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Paste(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButPasteMenu;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPasteMenu;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cut' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript)
				{
					return Clipboard_Cut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cut' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCut;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Copy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript)
				{
					return Clipboard_Copy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Copy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 0,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCopy;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript)
				{
					return Actions_DeleteItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_DeleteItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDeleteItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Series' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_EditSeries(string javascript)
				{
					return Actions_EditSeries(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Series' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_EditSeries(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListFormDisplayEditSeries;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListFormDisplayEditSeries;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Service Applications' tab.</summary>
			public class SvcApp
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Delete(string javascript)
				{
					return Operations_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppDeleteText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppDeleteTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppDeleteTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Manage(string javascript)
				{
					return Operations_Manage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Manage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppManageText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppManageTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppManageTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Administrators' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Administrators(string javascript)
				{
					return Operations_Administrators(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Administrators' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Administrators(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppAdministratorsText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppAdministratorsTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppAdministratorsTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Properties(string javascript)
				{
					return Operations_Properties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Properties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppPropertiesText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPropertiesTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPropertiesTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Publish' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Sharing_Publish(string javascript)
				{
					return Sharing_Publish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Publish' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Sharing_Publish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppPublishText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPublishTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPublishTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Sharing_Permissions(string javascript)
				{
					return Sharing_Permissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Sharing_Permissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SvcAppPermissionsText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPermissionsTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_SvcAppPermissionsTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Solutions' tab.</summary>
			public class Solution
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Upload Solution' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition New_Upload(string javascript)
				{
					return New_Upload(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Upload Solution' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition New_Upload(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabUploadSolution;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/edit.gif",
							Url32 = "/_layouts/images/MenuUploadDocument.gif"
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabUploadSolution;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabUploadSolution;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition All_Delete(string javascript)
				{
					return All_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition All_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDelete;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDelete;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandDelete;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Activate' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition All_Activate(string javascript)
				{
					return All_Activate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Activate' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition All_Activate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandActivate;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/SolutionActivate_16x16.png",
							Url32 = "/_layouts/images/SolutionActivate_32x32.png"
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandActivate;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandActivate;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Deactivate' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition All_Deactivate(string javascript)
				{
					return All_Deactivate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Deactivate' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition All_Deactivate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDeactivate;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/SolutionDeactivate_16x16.png",
							Url32 = "/_layouts/images/SolutionDeactivate_32x32.png"
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandDeactivate;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandDeactivate;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Upgrade' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition All_Upgrade(string javascript)
				{
					return All_Upgrade(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Upgrade' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition All_Upgrade(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandUpgrade;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/images/SolutionUpgrade_16x16.png",
							Url32 = "/_layouts/images/SolutionUpgrade_32x32.png"
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SolutionTabCommandUpgrade;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_SolutionTabCommandUpgrade;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Page' tab.</summary>
			public class WikiPageTab
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Rename Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_RenamePage(string javascript)
				{
					return Manage_RenamePage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Rename Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_RenamePage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButRenamePage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButRenamePage;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRenamePage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Page History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_VersionDiff(string javascript)
				{
					return Manage_VersionDiff(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Page History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_VersionDiff(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButVersionDiff;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButVersionDiff;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButVersionDiff;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Page Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Permissions(string javascript)
				{
					return Manage_Permissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Page Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Permissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPagePermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_DeletePage(string javascript)
				{
					return Manage_DeletePage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_DeletePage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,DeletePage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,DeletePage;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_DeletePage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailPageLink(string javascript)
				{
					return Share_EmailPageLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailPageLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkPage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Make Homepage' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition PageActions_SetHomePage(string javascript)
				{
					return PageActions_SetHomePage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Make Homepage' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition PageActions_SetHomePage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButSetHomePage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButSetHomePage;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButSetHomePage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Incoming Links' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition PageActions_IncomingLinks(string javascript)
				{
					return PageActions_IncomingLinks(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Incoming Links' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition PageActions_IncomingLinks(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButIncomingLinks;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButIncomingLinks;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButIncomingLinks;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Library Settings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition LibrarySettings_LibSettings(string javascript)
				{
					return LibrarySettings_LibSettings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Library Settings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition LibrarySettings_LibSettings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibSettings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibSettings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButLibSettings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Library Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition LibrarySettings_LibraryPermissions(string javascript)
				{
					return LibrarySettings_LibraryPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Library Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition LibrarySettings_LibraryPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibraryPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibraryPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButLibraryPermissions_page;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'View All Pages' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition LibrarySettings_ViewAllPages(string javascript)
				{
					return LibrarySettings_ViewAllPages(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'View All Pages' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition LibrarySettings_ViewAllPages(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewAllPages;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewAllPages;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewAllPages;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Publish' tab.</summary>
			public class PublishTab
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Publishing_Approve(string javascript)
				{
					return Publishing_Approve(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Publishing_Approve(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButApprove;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButApprove;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButApprove;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Publishing_Reject(string javascript)
				{
					return Publishing_Reject(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Publishing_Reject(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButReject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButReject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_ManageWorkflow(string javascript)
				{
					return Workflow_ManageWorkflow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_ManageWorkflow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPageManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Page' tab.</summary>
			public class WebPartPage
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Versions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Versions(string javascript)
				{
					return Manage_Versions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Versions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Versions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,versions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,versions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Permissions(string javascript)
				{
					return Manage_Permissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Permissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,permissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,permissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPagePermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Delete(string javascript)
				{
					return Manage_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,DeletePage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,DeletePage;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_DeletePage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailPageLink(string javascript)
				{
					return Share_EmailPageLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailPageLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkPage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Approval_Approve(string javascript)
				{
					return Approval_Approve(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Approval_Approve(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_PageStateApproveLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_PageStateApproveLabel;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButApprove;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Approval_Reject(string javascript)
				{
					return Approval_Reject(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Approval_Reject(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_PageStateRejectLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_PageStateRejectLabel;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_ManageWorkflow(string javascript)
				{
					return Workflow_ManageWorkflow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_ManageWorkflow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPageManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Make Homepage' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_MakeHomePage(string javascript)
				{
					return Actions_MakeHomePage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Make Homepage' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_MakeHomePage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,make_home_page;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,make_home_page;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButSetHomePage;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Title Bar Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_EditTitleBar(string javascript)
				{
					return Actions_EditTitleBar(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Title Bar Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_EditTitleBar(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButEditTitleBar;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButEditTitleBar;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditTitleBar;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Web Applications' tab.</summary>
			public class WebApp
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Contribute_New(string javascript)
				{
					return Contribute_New(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Contribute_New(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppNewText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppNewTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppNewDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Extend' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Contribute_Extend(string javascript)
				{
					return Contribute_Extend(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Extend' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Contribute_Extend(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppExtendText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppExtendTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppExtendDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Features' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Features(string javascript)
				{
					return Manage_Features(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Features' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Features(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppFeaturesText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppFeaturesTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppFeaturesDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Managed Paths' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Paths(string javascript)
				{
					return Manage_Paths(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Managed Paths' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Paths(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppPathsText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppPathsTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppPathsDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Service Connections' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Connections(string javascript)
				{
					return Manage_Connections(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Service Connections' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Connections(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppConnectionsText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppConnectionsTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppConnectionsDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Authentication Providers' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Security_Controls_AuthProviders(string javascript)
				{
					return Security_Controls_AuthProviders(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Authentication Providers' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Security_Controls_AuthProviders(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppAuthProvidersText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppAuthProvidersTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppAuthProvidersDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Self-Service Site Creation' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Security_Controls_SelfSite(string javascript)
				{
					return Security_Controls_SelfSite(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Self-Service Site Creation' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Security_Controls_SelfSite(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppSelfSiteText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppSelfSiteTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppSelfSiteDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Blocked File Types' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Security_Controls_BlockedFiles(string javascript)
				{
					return Security_Controls_BlockedFiles(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Blocked File Types' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Security_Controls_BlockedFiles(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppBlockedFilesText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppBlockedFilesTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppBlockedFilesDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'User Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Security_Controls_UserPermissions(string javascript)
				{
					return Security_Controls_UserPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'User Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Security_Controls_UserPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppUserPermissionsText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppUserPermissionsTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppUserPermissionsDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Web Part Security' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Security_Controls_WebPart(string javascript)
				{
					return Security_Controls_WebPart(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Web Part Security' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Security_Controls_WebPart(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppWebPartText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppWebPartTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppWebPartDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'User Policy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Policy_Controls_GeneralPolicy(string javascript)
				{
					return Policy_Controls_GeneralPolicy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'User Policy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Policy_Controls_GeneralPolicy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppGeneralPolicyText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppGeneralPolicyTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppGeneralPolicyDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Anonymous Policy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Policy_Controls_Anonymous(string javascript)
				{
					return Policy_Controls_Anonymous(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Anonymous Policy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Policy_Controls_Anonymous(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppAnonymousText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppAnonymousTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppAnonymousDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Permission Policy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Policy_Controls_PermissionPolicy(string javascript)
				{
					return Policy_Controls_PermissionPolicy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Permission Policy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Policy_Controls_PermissionPolicy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppPermissionPolicyText;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_WebAppPermissionPolicyTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_WebAppPermissionPolicyDesc", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Site Collections' tab.</summary>
			public class SiteCollections
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Contribute_CreateSite(string javascript)
				{
					return Contribute_CreateSite(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Contribute_CreateSite(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_new;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_newtooltiptitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_tenantadmin_sites_newtooltipdescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Contribute_Delete(string javascript)
				{
					return Contribute_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Contribute_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_delete;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_deletetooltiptitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_tenantadmin_sites_deletetooltipdescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Review_ViewProperties(string javascript)
				{
					return Review_ViewProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Review_ViewProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_properties;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_propertiestooltiptitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_tenantadmin_sites_propertiestooltipdescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Owners' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Owners(string javascript)
				{
					return Manage_Owners(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Owners' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Owners(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_owners;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_ownerstooltiptitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_tenantadmin_sites_ownerstooltipdescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Disk Quota' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_DiskQuota(string javascript)
				{
					return Manage_DiskQuota(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Disk Quota' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_DiskQuota(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_diskquota;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_tenantadmin_sites_diskquotatooltiptitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_tenantadmin_sites_diskquotatooltipdescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Trust Relationships' tab.</summary>
			public class ManageTrust
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Create(string javascript)
				{
					return Operations_Create(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Create(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_NewTrustLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_NewTrustTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_NewTrustTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Edit(string javascript)
				{
					return Operations_Edit(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Edit(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_EditTrustLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_EditTrustTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_EditTrustTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Operations_Delete(string javascript)
				{
					return Operations_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Operations_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_DeleteTrustLabel;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_DeleteTrustTooltipTitle", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_DeleteTrustTooltipDescription", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Format Text' tab.</summary>
			public class EditingTools_CPEditTab
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Cut' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript)
				{
					return Clipboard_Cut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cut' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Cut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 1,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCut;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCut;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Copy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript)
				{
					return Clipboard_Copy(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Copy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Clipboard_Copy(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							X = 0,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCopy;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCopy;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'ClearFormat' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Font_ClearFormat(string javascript)
				{
					return Font_ClearFormat(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'ClearFormat' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Font_ClearFormat(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButClearFormatTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButClearFormat;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Outdent' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Paragraph_Outdent(string javascript)
				{
					return Paragraph_Outdent(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Outdent' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Paragraph_Outdent(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButOutdentTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButOutdent;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Indent' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Paragraph_Indent(string javascript)
				{
					return Paragraph_Indent(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Indent' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Paragraph_Indent(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButIndentTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButIndent;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Insert' tab.</summary>
			public class EditingTools_CPInsert
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Links_Link(string javascript)
				{
					return Links_Link(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Links_Link(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButInsertLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButInsertLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertLink;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Upload File' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Links_UploadFile(string javascript)
				{
					return Links_UploadFile(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Upload File' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Links_UploadFile(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButInsertDocument;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButInsertDocument;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertDocument;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Web Part' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition WebParts_WebPart(string javascript)
				{
					return WebParts_WebPart(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Web Part' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition WebParts_WebPart(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertWebPart;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertWebPart;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertWebPart;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Existing List' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition WebParts_ExistingList(string javascript)
				{
					return WebParts_ExistingList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Existing List' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition WebParts_ExistingList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertExistingList;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertExistingList;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertExistingList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'New List' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition WebParts_InsertNewList(string javascript)
				{
					return WebParts_InsertNewList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New List' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition WebParts_InsertNewList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertNewList;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertNewList;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertNewList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Documents' tab.</summary>
			public class Document
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New Folder' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition New_NewFolder(string javascript)
				{
					return New_NewFolder(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Folder' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition New_NewFolder(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewFolder;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewFolder;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNewLibraryFolder;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Document' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition EditCheckout_EditDocument(string javascript)
				{
					return EditCheckout_EditDocument(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Document' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition EditCheckout_EditDocument(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditDocument;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditDocument;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditDocument;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check Out' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition EditCheckout_CheckOut(string javascript)
				{
					return EditCheckout_CheckOut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check Out' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition EditCheckout_CheckOut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckout;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckout;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check In' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition EditCheckout_CheckIn(string javascript)
				{
					return EditCheckout_CheckIn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check In' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition EditCheckout_CheckIn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButCheckin;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCheckin;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Discard Check Out' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition EditCheckout_DiscardCheckOut(string javascript)
				{
					return EditCheckout_DiscardCheckOut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Discard Check Out' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition EditCheckout_DiscardCheckOut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButDiscardCheckout;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButDiscardCheckout;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDiscardCheckout;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'View Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript)
				{
					return Manage_ViewProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'View Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButViewProperties;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButViewProperties;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewDocumentProperties;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript)
				{
					return Manage_EditProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButEditProperties;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButEditProperties;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditDocumentProperties;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Version History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript)
				{
					return Manage_ViewVersions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Version History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButVersionHistory;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButVersionHistory;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Document Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript)
				{
					return Manage_ManagePermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Document Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocumentPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDocumentPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Document' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Delete(string javascript)
				{
					return Manage_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Document' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteDocument;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteDocument;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDeleteDocument;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailItemLink(string javascript)
				{
					return Share_EmailItemLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailItemLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkDocument;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Download a Copy' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Copies_Download(string javascript)
				{
					return Copies_Download(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Download a Copy' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Copies_Download(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDownloadCopy;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDownloadCopy;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDownloadCopy;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Copies' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Copies_ManageCopies(string javascript)
				{
					return Copies_ManageCopies(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Copies' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Copies_ManageCopies(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButManageCopies;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButManageCopies;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButManageCopies;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Go To Source' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Copies_GoToSourceItem(string javascript)
				{
					return Copies_GoToSourceItem(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Go To Source' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Copies_GoToSourceItem(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGoToSource;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGoToSource;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButGoToSource;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript)
				{
					return Workflow_ViewWorkflows(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Publish' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_Publish(string javascript)
				{
					return Workflow_Publish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Publish' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_Publish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButPublish;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButPublish;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButPublish;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Unpublish' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_Unpublish(string javascript)
				{
					return Workflow_Unpublish(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Unpublish' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_Unpublish(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButUnpublish;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButUnpublish;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButUnpublish;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve/Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript)
				{
					return Workflow_Moderate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve/Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDocumentApproveReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Cancel Approval' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_CancelApproval(string javascript)
				{
					return Workflow_CancelApproval(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Cancel Approval' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_CancelApproval(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCancelApproval;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCancelApproval;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCancelApproval;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Relink' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition FormActions_RepairItems(string javascript)
				{
					return FormActions_RepairItems(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Relink' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition FormActions_RepairItems(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRepairItems;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRepairItems;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRepairItems;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Relink All' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition FormActions_RepairAllItems(string javascript)
				{
					return FormActions_RepairAllItems(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Relink All' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition FormActions_RepairAllItems(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRepairAllItems;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRepairAllItems;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRepairAllItems;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Merge' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition FormActions_MergeDocuments(string javascript)
				{
					return FormActions_MergeDocuments(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Merge' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition FormActions_MergeDocuments(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButMergeDocuments;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButMergeDocuments;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButMergeDocuments;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Library' tab.</summary>
			public class Library
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New Row' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_NewRow(string javascript)
				{
					return Datasheet_NewRow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Row' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_NewRow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewRow;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewRow;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNewRow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Show Task Pane' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_ShowTaskPane(string javascript)
				{
					return Datasheet_ShowTaskPane(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Show Task Pane' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_ShowTaskPane(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTaskPane", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTaskPane;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButShowTaskPane;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Show Totals' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_ShowTotals(string javascript)
				{
					return Datasheet_ShowTotals(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Show Totals' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_ShowTotals(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTotals;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTotals;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButShowTotals;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Refresh Data' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_RefreshData(string javascript)
				{
					return Datasheet_RefreshData(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Refresh Data' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_RefreshData(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRefreshData;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRefreshData;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRefreshData;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'All Meetings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_AllMeetings(string javascript)
				{
					return CustomViews_AllMeetings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'All Meetings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_AllMeetings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAllMeetings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAllMeetings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAllMeetings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create View' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript)
				{
					return CustomViews_CreateView(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create View' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateView;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create Column' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript)
				{
					return CustomViews_CreateColumn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create Column' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateColumn;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Navigate Up' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_NavigateUp(string javascript)
				{
					return CustomViews_NavigateUp(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Navigate Up' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_NavigateUp(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNavigateUp;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNavigateUp;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNavigateUp;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Previous Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_PreviousPage(string javascript)
				{
					return CustomViews_PreviousPage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Previous Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_PreviousPage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPreviousPage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Next Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_NextPage(string javascript)
				{
					return CustomViews_NextPage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Next Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_NextPage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNextPage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript)
				{
					return Share_EmailLibraryLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkLibrary;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'RSS Feed' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript)
				{
					return Share_ViewRSSFeed(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'RSS Feed' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewRSSFeedLibrary;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Sync to SharePoint Workspace' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_TakeOfflineToClient(string javascript)
				{
					return Actions_TakeOfflineToClient(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Sync to SharePoint Workspace' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_TakeOfflineToClient(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButSyncToComputer;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButSyncToComputer;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButSyncLibraryToComputer;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Connect to Outlook' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript)
				{
					return Actions_ConnectToClient(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Connect to Outlook' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButConnectToClient;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Export to Excel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript)
				{
					return Actions_ExportToSpreadsheet(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Export to Excel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButExportListToSpreadsheet;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Open with Explorer' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_OpenWithExplorer(string javascript)
				{
					return Actions_OpenWithExplorer(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Open with Explorer' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_OpenWithExplorer(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithExplorer;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithExplorer;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButOpenWithExplorer;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Library' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomizeLibrary_EditList(string javascript)
				{
					return CustomizeLibrary_EditList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Library' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomizeLibrary_EditList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditLibrary;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_STT_Title_ButEditLibrary;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditLibrary;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'New Quick Step' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomizeLibrary_AddButton(string javascript)
				{
					return CustomizeLibrary_AddButton(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Quick Step' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomizeLibrary_AddButton(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAddButton;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAddButton;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemAddButton;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Library Settings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_DocumentLibrarySettings(string javascript)
				{
					return Settings_DocumentLibrarySettings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Library Settings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_DocumentLibrarySettings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibSettings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibSettings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButLibrarySettings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Library Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_LibraryPermissions(string javascript)
				{
					return Settings_LibraryPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Library Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_LibraryPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibraryPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButLibraryPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButLibraryPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Items' tab.</summary>
			public class ListItem
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New Folder' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition New_NewFolder(string javascript)
				{
					return New_NewFolder(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Folder' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition New_NewFolder(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewFolder;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 10,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewFolder;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNewListFolder;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'View Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript)
				{
					return Manage_ViewProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'View Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript)
				{
					return Manage_EditProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Version History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript)
				{
					return Manage_ViewVersions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Version History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Item Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript)
				{
					return Manage_ManagePermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Item Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButItemPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButItemPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Item' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Delete(string javascript)
				{
					return Manage_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Item' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteItem;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDeleteItem;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Attach File' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript)
				{
					return Actions_AttachFile(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Attach File' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAttachFile;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Change Item Order' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ChangeItemOrder(string javascript)
				{
					return Actions_ChangeItemOrder(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Change Item Order' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ChangeItemOrder(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButChangeItemOrder;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButChangeItemOrder;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButChangeItemOrder;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript)
				{
					return Workflow_ViewWorkflows(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve/Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript)
				{
					return Workflow_Moderate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve/Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemApproveReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'List' tab.</summary>
			public class List
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'New Row' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_NewRow(string javascript)
				{
					return Datasheet_NewRow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Row' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_NewRow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewRow;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNewRow;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNewRow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Show Task Pane' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_ShowTaskPane(string javascript)
				{
					return Datasheet_ShowTaskPane(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Show Task Pane' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_ShowTaskPane(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTaskPane", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTaskPane;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButShowTaskPane;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Show Totals' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_ShowTotals(string javascript)
				{
					return Datasheet_ShowTotals(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Show Totals' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_ShowTotals(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTotals;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButShowTotals;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButShowTotals;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Refresh Data' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Datasheet_RefreshData(string javascript)
				{
					return Datasheet_RefreshData(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Refresh Data' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Datasheet_RefreshData(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRefreshData;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButRefreshData;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRefreshData;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Zoom In' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition GanttView_ZoomIn(string javascript)
				{
					return GanttView_ZoomIn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Zoom In' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition GanttView_ZoomIn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttZoomIn;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttZoomIn;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButGanttZoomIn;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Zoom Out' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition GanttView_ZoomOut(string javascript)
				{
					return GanttView_ZoomOut(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Zoom Out' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition GanttView_ZoomOut(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttZoomOut;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttZoomOut;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButGanttZoomOut;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Scroll to Task' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition GanttView_ScrollToTask(string javascript)
				{
					return GanttView_ScrollToTask(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Scroll to Task' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition GanttView_ScrollToTask(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttScrollToTask;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButGanttScrollToTask;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButGanttScrollToTask;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'All Meetings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_AllMeetings(string javascript)
				{
					return CustomViews_AllMeetings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'All Meetings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_AllMeetings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAllMeetings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAllMeetings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAllMeetings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create View' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript)
				{
					return CustomViews_CreateView(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create View' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateView;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create Column' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript)
				{
					return CustomViews_CreateColumn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create Column' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateColumn;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Navigate Up' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_NavigateUp(string javascript)
				{
					return CustomViews_NavigateUp(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Navigate Up' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_NavigateUp(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNavigateUp;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNavigateUp;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButNavigateUp;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Previous Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_PreviousPage(string javascript)
				{
					return CustomViews_PreviousPage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Previous Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_PreviousPage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButPreviousPage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Next Page' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_NextPage(string javascript)
				{
					return CustomViews_NextPage(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Next Page' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_NextPage(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButNextPage;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = ""
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript)
				{
					return Share_EmailLibraryLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'RSS Feed' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript)
				{
					return Share_ViewRSSFeed(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'RSS Feed' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewRSSFeedList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Sync to SharePoint Workspace' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_TakeOfflineToClient(string javascript)
				{
					return Actions_TakeOfflineToClient(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Sync to SharePoint Workspace' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_TakeOfflineToClient(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButSyncToComputer;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 7,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButSyncToComputer;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButSyncListToComputer;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Connect to Outlook' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript)
				{
					return Actions_ConnectToClient(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Connect to Outlook' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButConnectToClient;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Export to Excel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript)
				{
					return Actions_ExportToSpreadsheet(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Export to Excel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButExportListToSpreadsheet;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create Visio Diagram' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_CreateVisioDiagram(string javascript)
				{
					return Actions_CreateVisioDiagram(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create Visio Diagram' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_CreateVisioDiagram(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateVisioDiagram;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateVisioDiagram;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateVisioDiagram;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Open with Access' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_OpenWithAccess(string javascript)
				{
					return Actions_OpenWithAccess(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Open with Access' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_OpenWithAccess(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithAccess;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithAccess;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButOpenWithAccess;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Open Schedule' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ExportToProject(string javascript)
				{
					return Actions_ExportToProject(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Open Schedule' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ExportToProject(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToProject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToProject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButExportToProject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit List' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomizeList_EditList(string javascript)
				{
					return CustomizeList_EditList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit List' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomizeList_EditList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditList;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_STT_Title_ButEditList;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'New Quick Step' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomizeList_AddButton(string javascript)
				{
					return CustomizeList_AddButton(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'New Quick Step' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomizeList_AddButton(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAddButton;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 10
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAddButton;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemAddButton;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'List Settings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_ListSettings(string javascript)
				{
					return Settings_ListSettings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'List Settings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_ListSettings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListSettings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListSettings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListSettings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'List Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_ListPermissions(string javascript)
				{
					return Settings_ListPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'List Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_ListPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Format' tab.</summary>
			public class Link_Link
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Remove Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Link_RemoveLink(string javascript)
				{
					return Link_RemoveLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Remove Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Link_RemoveLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButRemoveLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButRemoveLinkAlt;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButRemoveLink;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Layout' tab.</summary>
			public class Table_Layout
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Insert Above' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition RowsCols_InsertAbove(string javascript)
				{
					return RowsCols_InsertAbove(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Insert Above' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition RowsCols_InsertAbove(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertAbove;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertAbove;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_ButRowsColumnsMenuInsertRowsAboveTooltip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Insert Below' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition RowsCols_InsertBelow(string javascript)
				{
					return RowsCols_InsertBelow(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Insert Below' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition RowsCols_InsertBelow(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertBelow;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 13
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertBelow;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_ButRowsColumnsMenuInsertRowsBelowTooltip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Insert Left' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition RowsCols_InsertLeft(string javascript)
				{
					return RowsCols_InsertLeft(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Insert Left' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition RowsCols_InsertLeft(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertLeft;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertLeft;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_ButRowsColumnsMenuInsertColumnsLeftTooltip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Insert Right' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition RowsCols_InsertRight(string javascript)
				{
					return RowsCols_InsertRight(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Insert Right' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition RowsCols_InsertRight(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertRight;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButTableRowsColsInsertRight;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_ButRowsColumnsMenuInsertColumnsRightTooltip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Insert' tab.</summary>
			public class WebPartInsert_Tab
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Text' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Text_Text(string javascript)
				{
					return Text_Text(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Text' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Text_Text(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,Text;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 1
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,Text;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_Text;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Image' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Media_Image(string javascript)
				{
					return Media_Image(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Image' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Media_Image(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,image;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,image;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_image;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Web Part' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition WebParts_WebPart(string javascript)
				{
					return WebParts_WebPart(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Web Part' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition WebParts_WebPart(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,webpart;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,webpart;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertWebPart;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Existing List' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition WebParts_ExistingList(string javascript)
				{
					return WebParts_ExistingList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Existing List' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition WebParts_ExistingList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertExistingList;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 1,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,ButInsertExistingList;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInsertExistingList_wpp;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Options' tab.</summary>
			public class WebPartOption
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Web Part Properties' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Properties_Modify(string javascript)
				{
					return Properties_Modify(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Web Part Properties' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Properties_Modify(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,wp_props;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,wp_props;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_wp_props;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Minimize' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commands_Minimize(string javascript)
				{
					return Commands_Minimize(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Minimize' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commands_Minimize(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,minimize;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,minimize;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_minimize;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Restore' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commands_Restore(string javascript)
				{
					return Commands_Restore(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Restore' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commands_Restore(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,restore;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,restore;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_restore;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Commands_Delete(string javascript)
				{
					return Commands_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Commands_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,deleteButton;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,deleteButton;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_deleteButton;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Events' tab.</summary>
			public class Calendar_Events
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'View Event' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript)
				{
					return Manage_ViewProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'View Event' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewEvent;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewEvent;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewEvent;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit Event' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript)
				{
					return Manage_EditProperties(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit Event' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_EditProperties(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditEvent;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditEvent;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditEvent;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Version History' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript)
				{
					return Manage_ViewVersions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Version History' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ViewVersions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButVersionHistory;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEventVersionHistory;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Event Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript)
				{
					return Manage_ManagePermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Event Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ManagePermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEventPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEventPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEventPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Delete Event' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_Delete(string javascript)
				{
					return Manage_Delete(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Delete Event' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_Delete(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteEvent;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButDeleteEvent;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButDeleteEvent;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Attach File' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript)
				{
					return Actions_AttachFile(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Attach File' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_AttachFile(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButAttachFile;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButAttachFile;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Workflows' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript)
				{
					return Workflow_ViewWorkflows(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Workflows' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_ViewWorkflows(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 6
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButWorkflows;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEventManageWorkflow;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Approve/Reject' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript)
				{
					return Workflow_Moderate(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Approve/Reject' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Workflow_Moderate(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 14
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButApproveReject;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButItemApproveReject;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Calendar' tab.</summary>
			public class Calendar_Calendar
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Resource' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Selector_Resource(string javascript)
				{
					return Selector_Resource(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Resource' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Selector_Resource(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_CalendarResource;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 3,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarResourceSelect;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarResourceSelectDesc;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Expand All' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Expander_ExpandAll(string javascript)
				{
					return Expander_ExpandAll(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Expand All' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Expander_ExpandAll(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_CalendarExpand;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarExpand;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarExpandDesc;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Collapse All' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Expander_CollapseAll(string javascript)
				{
					return Expander_CollapseAll(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Collapse All' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Expander_CollapseAll(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_CalendarCollapse;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 8,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarCollapse;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarCollapseDesc;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Calendars Overlay' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_AddCalendar(string javascript)
				{
					return CustomViews_AddCalendar(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Calendars Overlay' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_AddCalendar(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_CalendarAddCalendar;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarAddCalendar;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_stt_CalendarAddCalendarDesc;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create View' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript)
				{
					return CustomViews_CreateView(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create View' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateView(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateView;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateView;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create Column' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript)
				{
					return CustomViews_CreateColumn(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create Column' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomViews_CreateColumn(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButCreateColumn;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButCreateColumn;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'E-mail a Link' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript)
				{
					return Share_EmailLibraryLink(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'E-mail a Link' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_EmailLibraryLink(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 14,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEmailLink;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEmailLinkList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'RSS Feed' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript)
				{
					return Share_ViewRSSFeed(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'RSS Feed' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Share_ViewRSSFeed(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 7
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButViewRSSFeed;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButViewRSSFeedList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Connect to Outlook' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript)
				{
					return Actions_ConnectToClient(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Connect to Outlook' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ConnectToClient(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButConnectToClient;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButConnectToClient;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Export to Excel' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript)
				{
					return Actions_ExportToSpreadsheet(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Export to Excel' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_ExportToSpreadsheet(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButExportToSpreadsheet;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButExportListToSpreadsheet;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Open with Access' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Actions_OpenWithAccess(string javascript)
				{
					return Actions_OpenWithAccess(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Open with Access' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Actions_OpenWithAccess(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithAccess;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 0,
							Y = 9
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButOpenWithAccess;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButOpenWithAccess;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit List' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition CustomizeList_EditList(string javascript)
				{
					return CustomizeList_EditList(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit List' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition CustomizeList_EditList(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButEditList;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 11,
							Y = 12
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_STT_Title_ButEditList;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButEditList;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'List Settings' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_ListSettings(string javascript)
				{
					return Settings_ListSettings(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'List Settings' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_ListSettings(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListSettings;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListSettings;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListSettings;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'List Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Settings_ListPermissions(string javascript)
				{
					return Settings_ListPermissions(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'List Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Settings_ListPermissions(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListPermissions;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 13,
							Y = 0
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButListPermissions;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButListPermissions;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
			/// <summary>Buttons on the 'Edit' tab.</summary>
			public class Permission
			{
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Parent' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Parent_ManageParent(string javascript)
				{
					return Parent_ManageParent(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Parent' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Parent_ManageParent(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ManageParent;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ManageParentToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_ManageParentToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Inherit Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Parent_Inherit(string javascript)
				{
					return Parent_Inherit(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Inherit Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Parent_Inherit(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_Inherit;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 2
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButInherit;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButInherit;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Stop Inheriting Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Parent_StopInherit(string javascript)
				{
					return Parent_StopInherit(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Stop Inheriting Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Parent_StopInherit(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_StopInherit;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 1
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButStopInherit;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_STT_ButStopInherit;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Grant Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Add_AddUser(string javascript)
				{
					return Add_AddUser(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Grant Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Add_AddUser(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonAddUser;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 5
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonAddUserToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonAddUserToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Create Group' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Add_NewGroup(string javascript)
				{
					return Add_NewGroup(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Create Group' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Add_NewGroup(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonNewGroup;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 4
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonNewGroupToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_ButtonNewGroupToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Edit User Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Modify_EditUsrPerm(string javascript)
				{
					return Modify_EditUsrPerm(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Edit User Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Modify_EditUsrPerm(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_EditUsrPerm;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 12,
							Y = 3
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_EditUsrPermToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_EditUsrPermToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Remove User Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Modify_RemovePerms(string javascript)
				{
					return Modify_RemovePerms(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Remove User Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Modify_RemovePerms(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_RemovePerms;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 4,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_RemovePermsToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_RemovePermsToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Check Permissions' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Check_CheckUsrPerm(string javascript)
				{
					return Check_CheckUsrPerm(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Check Permissions' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Check_CheckUsrPerm(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_CheckUsrPerm;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 6,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_CheckUsrPermToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_CheckUsrPermToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Anonymous Access' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_AnonyAccess(string javascript)
				{
					return Manage_AnonyAccess(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Anonymous Access' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_AnonyAccess(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_AnonyAccess;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_AnonyAccessToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_AnonyAccessToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Permission Levels' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_PermLevels(string javascript)
				{
					return Manage_PermLevels(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Permission Levels' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_PermLevels(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_PermLevels;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 9,
							Y = 8
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_PermLevelsToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_PermLevelsToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Manage Access Requests' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_ManageAccReq(string javascript)
				{
					return Manage_ManageAccReq(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Manage Access Requests' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_ManageAccReq(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_ManageAccReq;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 2,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_ManageAccReqToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_ManageAccReqToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
				/// <summary>
				/// Button, which will appear identical to the standard 'Site Collection Administrators' button, but with custom javascript attached to it.
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				public static ButtonDefinition Manage_SiteColAdmin(string javascript)
				{
					return Manage_SiteColAdmin(javascript, 1033);
				}
				/// <summary>
				/// Button, which will look exactly like the standard 'Site Collection Administrators' button, but with custom javascript attached to it
				/// </summary>
				/// <param name="javascript">Javascript code, which will be executed, when the button is clicked.</param>
				/// <param name="lcid">Locale id for the current site. If not specified, english locale (1033) will be used.</param>
				public static ButtonDefinition Manage_SiteColAdmin(string javascript, int lcid)
				{
					string id = GetRandom().Next(100, 999).ToString();
            
					var definition = new ButtonDefinition()
					{
						Id = "Button" + id,
						Title = SPUtility.GetLocalizedString("$Resources:core,cui_SiteColAdmin;", "core", (uint)lcid),
						Image = new ImageDefinition()
						{
							Url16 = "/_layouts/$Resources:core,Language;/images/formatmap16x16.png",
							Url32 = "/_layouts/$Resources:core,Language;/images/formatmap32x32.png",
							X = 5,
							Y = 11
						},
						ToolTip = new ToolTipDefinition()
						{
							Title = SPUtility.GetLocalizedString("$Resources:core,cui_SiteColAdminToolTipTitle;", "core", (uint)lcid),
							Description = SPUtility.GetLocalizedString("$Resources:core,cui_SiteColAdminToolTip;", "core", (uint)lcid)
						},
						CommandJavaScript = javascript
					};

					if (definition.Image.Url16.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url16 = SPUtility.GetLocalizedString(definition.Image.Url16, "core", (uint)lcid);
					if (definition.Image.Url32.ToLowerInvariant().Contains("$resources"))
						definition.Image.Url32 = SPUtility.GetLocalizedString(definition.Image.Url32, "core", (uint)lcid);

					return definition;
				}
			}
		}
	}
}