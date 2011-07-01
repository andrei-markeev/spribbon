using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace FluentRibbon
{
    public partial class RibbonCustomAction
    {
        private Guid ProvisionWeb(Guid featureUniqueGuid, SPWeb web, string templateId, ListForms whichForms, SPBasePermissions? rights)
        {
            var id = Provision(featureUniqueGuid, web.UserCustomActions, templateId, whichForms, rights);
            web.Update();
            return id;
        }

        private Guid ProvisionList(Guid featureUniqueGuid, SPList list, string templateId, ListForms whichForms, SPBasePermissions? rights)
        {
            var id = Provision(featureUniqueGuid, list.UserCustomActions, templateId, whichForms, rights);
            list.Update();
            return id;
        }

        #region List

        /// <summary>
        /// Provision all pending customizations to specified list.
        /// Customizations will be shown on all list pages.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RemoveAllCustomizations"/> method.</param>
        /// <param name="web">Web, where ribbon will be added</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPList list)
        {
            return ProvisionList(featureUniqueGuid, list, string.Empty, ListForms.All, null);
        }

        /// <summary>
        /// Provision all pending customizations to specified list.
        /// Customizations will be shown on specified list pages for lists with specified ID.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="list">SPList, where a ribbon will be added</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPList list, ListForms whichForms)
        {
            return ProvisionList(featureUniqueGuid, list, string.Empty, whichForms, null);
        }

        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on specified list pages, only to users with appropriate rights.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="list">SPList, where a ribbon will be added</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="rights">Minimal privilegies, needed to see the ribbon elements</param>
        /// <returns>Id of Provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPList list, ListForms whichForms, SPBasePermissions rights)
        {
            return ProvisionList(featureUniqueGuid, list, string.Empty, whichForms, rights);
        }

        #endregion

        #region Web

        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on all list pages.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RemoveAllCustomizations"/> method.</param>
        /// <param name="web">Web, where ribbon will be added</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPWeb web)
        {
            return ProvisionWeb(featureUniqueGuid, web, string.Empty, ListForms.All, null);
        }

        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on all pages for lists with specified ID.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPWeb web, ListTypes listType)
        {
            return ProvisionWeb(featureUniqueGuid, web, ((int)listType).ToString(), ListForms.All, null);
        }

        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on specified list pages for lists with specified ID.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPWeb web, ListTypes listType, ListForms whichForms)
        {
            return ProvisionWeb(featureUniqueGuid, web, ((int)listType).ToString(), whichForms, null);
        }

        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on specified list pages, only to users with appropriate rights.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RibbonCustomAction.RemoveAllCustomizations"/> method.</param>
        /// <param name="web">SPWeb, where a ribbon will be added</param>
        /// <param name="listType">One of standard list types, for which ribbon elements will be registered</param>
        /// <param name="whichForms">List forms, which will display the ribbon</param>
        /// <param name="rights">Minimal privilegies, needed to see the ribbon elements</param>
        /// <returns>Id of Provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPWeb web, ListTypes listType, ListForms whichForms, SPBasePermissions rights)
        {
            return ProvisionWeb(featureUniqueGuid, web, ((int)listType).ToString(), whichForms, rights);
        }

        #endregion
    }
}
