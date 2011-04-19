using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon
{
    /// <summary>
    /// Template identifiers for standard SharePoint lists
    /// Helper enumeration for <see cref="RibbonCustomAction"/> class Provision methods.
    /// </summary>
    public enum ListTypes
    {
        /// <summary>
        /// Generic list
        /// </summary>
        GenericList = 100,
        /// <summary>
        /// Generic document library
        /// </summary>
        GenericLibrary = 101,
        /// <summary>
        /// Surveys list
        /// </summary>
        SurveysList = 102,
        /// <summary>
        /// Links list
        /// </summary>
        LinksList = 103,
        /// <summary>
        /// Announcements list
        /// </summary>
        AnnouncementsList = 104,
        /// <summary>
        /// Contacts list
        /// </summary>
        ContactsList = 105,
        /// <summary>
        /// Events calendar
        /// </summary>
        Events = 106,
        /// <summary>
        /// Tasks list
        /// </summary>
        TasksList = 107,
        /// <summary>
        /// Discussion board
        /// </summary>
        DiscussionsList = 108,
        /// <summary>
        /// Picture library with thumbnails preview
        /// </summary>
        PictureLibrary = 109,
        /// <summary>
        /// Data source library
        /// </summary>
        DataSourceLibrary = 110,
        /// <summary>
        /// Library containing site templates
        /// </summary>
        SiteTemplateGallery = 111,
        /// <summary>
        /// User information list
        /// </summary>
        UserInformationList = 112,
        /// <summary>
        /// Gallery of webparts (*.webpart &amp; *.dwp files)
        /// </summary>
        WebPartGallery = 113,
        /// <summary>
        /// Gallery of list templates
        /// </summary>
        ListTemplateGallery = 114,
        /// <summary>
        /// Library containing xml forms
        /// </summary>
        XmlFormLibrary = 115,
        /// <summary>
        /// Gallery of masterpage files
        /// </summary>
        MasterPagesGallery = 116,
        /// <summary>
        /// Nocode workflow library
        /// </summary>
        NoCodeWorkflowLibrary = 117,
        /// <summary>
        /// Workflow process library
        /// </summary>
        WorkflowProcessLibrary = 118,
        /// <summary>
        /// Wiki page library
        /// </summary>
        WikiPageLibrary = 119,
        /// <summary>
        /// Grid list
        /// </summary>
        GridList = 120,
        /// <summary>
        /// Data connection library
        /// </summary>
        DataConnectionLibrary = 130,
        /// <summary>
        /// Workflow history
        /// </summary>
        WorkflowHistory = 140,
        /// <summary>
        /// Tasks list with Gantt diagram
        /// </summary>
        GanttTasks = 150,
        /// <summary>
        /// Meeting series
        /// </summary>
        MeetingSeries = 200,
        /// <summary>
        /// Meeting agenda
        /// </summary>
        MeetingAgenda = 201,
        /// <summary>
        /// Meeting attendees
        /// </summary>
        MeetingAttendees = 202,
        /// <summary>
        /// Meeting decisions
        /// </summary>
        MeetingDecisions = 204,
        /// <summary>
        /// Meeting objectives
        /// </summary>
        MeetingObjectives = 207,
        /// <summary>
        /// Meeting text box
        /// </summary>
        MeetingTextBox = 210,
        /// <summary>
        /// Meeting things to bring
        /// </summary>
        MeetingThingsToBring = 211,
        /// <summary>
        /// Meeting workspace pages
        /// </summary>
        MeetingWorkspacePages = 212,
        /// <summary>
        /// Portal sites
        /// </summary>
        PortalSites = 300,
        /// <summary>
        /// Posts list for the Blog template
        /// </summary>
        BlogPosts = 301,
        /// <summary>
        /// Comments list for the Blog template
        /// </summary>
        BlogComments = 302,
        /// <summary>
        /// Categories list for the Blog template
        /// </summary>
        BlogCategories = 303,
        /// <summary>
        /// Issues list
        /// </summary>
        IssuesList = 1100,
        /// <summary>
        /// Administrator tasks
        /// </summary>
        AdministratorTasks = 1200,
        /// <summary>
        /// Personal document library
        /// </summary>
        PersonalDocumentLibrary = 2002,
        /// <summary>
        /// Private document library
        /// </summary>
        PrivateDocumentLibrary = 2003

    }
}
