using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace FluentRibbon
{
    public partial class RibbonCustomAction
    {
        /// <summary>
        /// Provision all pending customizations to specified web.
        /// Customizations will be shown on all list pages.
        /// </summary>
        /// <param name="featureUniqueGuid">Guid, needed for feature-scoped cleanup in FeatureDeactivating using <see cref="RemoveAllCustomizations"/> method.</param>
        /// <param name="web">Web, where ribbon will be added</param>
        /// <returns>Id of provisioned custom action</returns>
        public Guid Provision(Guid featureUniqueGuid, SPWeb web)
        {
            return Provision(featureUniqueGuid, web, string.Empty, ListForms.All, null);
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
            return Provision(featureUniqueGuid, web, ((int)listType).ToString(), ListForms.All, null);
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
            return Provision(featureUniqueGuid, web, ((int)listType).ToString(), whichForms, null);
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
            return Provision(featureUniqueGuid, web, ((int)listType).ToString(), whichForms, rights);
        }
    }
}
