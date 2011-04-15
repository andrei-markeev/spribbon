using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace RibbonUtils
{
    /// <summary>
    /// Defines ribbon customization location
    /// </summary>
    public class RibbonLocation
    {
        /// <summary>
        /// SPWeb, where a ribbon will be added
        /// </summary>
        public SPWeb Web { get; private set; }

        /// <summary>
        /// List template id
        /// </summary>
        public string TemplateId { get; private set; }
        
        /// <summary>
        /// Which forms of a list will display a ribbon
        /// </summary>
        public string WhichForms { get; private set; }

        /// <summary>
        /// Guid of the calling feature receiver class
        /// </summary>
        public string FeatureScopedGuid { get; private set; }

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

        /// <summary>
        /// Rights needed to see the ribbon elements
        /// </summary>
        public SPBasePermissions? Rights { get; private set; }


        #region Constructions

        /// <summary>
        /// Creates ribbon location definition, to use with <see cref="RibbonFromFeature"/> methods.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonFromFeature.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">Web, where ribbon will be added</param>
        public RibbonLocation(Guid featureUniqueGuid, SPWeb web)
        {
            FeatureScopedGuid = featureUniqueGuid.ToString();
            Web = web;
            TemplateId = "";
            WhichForms = GetRibbonLocationByListForms(ListForms.All);
            Rights = null;
        }

        /// <summary>
        /// Creates ribbon location definition, to use with <see cref="RibbonFromFeature"/> methods.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonFromFeature.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        public RibbonLocation(Guid featureUniqueGuid, SPWeb web, ListTypes listType)
        {
            FeatureScopedGuid = featureUniqueGuid.ToString();
            Web = web;
            TemplateId = ((int)listType).ToString();
            WhichForms = GetRibbonLocationByListForms(ListForms.All);
            Rights = null;
        }

        /// <summary>
        /// Creates ribbon location definition, to use with <see cref="RibbonFromFeature"/> methods.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonFromFeature.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        public RibbonLocation(Guid featureUniqueGuid, SPWeb web, ListTypes listType, ListForms whichForms)
        {
            FeatureScopedGuid = featureUniqueGuid.ToString();
            Web = web;
            TemplateId = ((int)listType).ToString();
            WhichForms = GetRibbonLocationByListForms(whichForms);
            Rights = null;
        }
        /// <summary>
        /// Creates ribbon location definition, to use with <see cref="RibbonFromFeature"/> methods.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonFromFeature.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="rights">Rights needed to see the ribbon elements</param>
        public RibbonLocation(Guid featureUniqueGuid, SPWeb web, ListTypes listType, ListForms whichForms, SPBasePermissions rights)
        {
            Web = web;
            TemplateId = ((int)listType).ToString();
            WhichForms = GetRibbonLocationByListForms(whichForms);
            FeatureScopedGuid = featureUniqueGuid.ToString();
            Rights = rights;
        }


        /// <summary>
        /// Creates ribbon location definition for list with a custom template, to use with <see cref="RibbonFromFeature"/> methods.
        /// </summary>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="templateId">Custom list template Id, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonFromFeature.RemoveAllCustomizations"/> method.</param>
        public RibbonLocation(SPWeb web, string templateId, ListForms whichForms, Guid featureUniqueGuid, SPBasePermissions rights)
        {
            Web = web;
            TemplateId = templateId;
            WhichForms = GetRibbonLocationByListForms(whichForms);
            FeatureScopedGuid = featureUniqueGuid.ToString();
            Rights = rights;
        }


        #endregion

    }
}
