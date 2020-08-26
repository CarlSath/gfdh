using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Products.Entities;
using MetaShare.Common.Core.Services;
using Products.Daos.Interfaces;
using Products.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services
{
	public class EnterpriseService : Service<Enterprise>, IEnterpriseService
	{
		public EnterpriseService() : base(typeof (IEnterpriseDao))
		{
			ServiceAggregationInfo organizationUnitsServiceAggregation = this.ServiceAggregationInfo.AddCompositeCollectionChild("OrganizationUnits", typeof(Products.Entities.OrganizationUnit), typeof(Products.Daos.Interfaces.IOrganizationUnitDao), "Organization");
			ServiceAggregationInfo productCatalogServiceAggregationInfo =  this.ServiceAggregationInfo.AddReferenceChild("ProductCatalog", typeof(Products.Entities.Catalog), typeof(Products.Daos.Interfaces.ICatalogDao));
		}

		public List<Enterprise> SelectAllWithReferenceData(List<Enterprise> items)
        {
            if (items != null && items.Count > 0)
            {
                return this.SelectBy(items, this.CreateReferenceInfoAggregation());
            }
            return items;
        }

        private ServiceAggregationInfo CreateReferenceInfoAggregation()
        {
            ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(Enterprise), typeof(IEnterpriseDao));
		    aggregation.AddReferenceChild("ProductCatalog", typeof(Products.Entities.Catalog), typeof(Products.Daos.Interfaces.ICatalogDao));

		    return aggregation;
        }

		public List<Enterprise> SelectEnterpriseByProductCatalogs(int[] productCatalogIds, bool isAggregatedChildren = false)
        {
            List<Enterprise> items = this.SelectByColumnIds("ProductCatalogId",productCatalogIds,isAggregatedChildren);
            return items;
        }
		public List<Enterprise> SelectEnterpriseByProductCatalogs(Pager pager, int[] productCatalogIds, bool isAggregatedChildren = false)
        {
            List<Enterprise> items = this.SelectByColumnIds(pager,"ProductCatalogId",productCatalogIds,isAggregatedChildren);
            return items;
        }
		public List<Enterprise> SelectByProductCatalog(int pageIndex,int pageSize,int productCatalogId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Enterprise> items = this.SelectBy(pager,new Enterprise { ProductCatalog = new Products.Entities.Catalog{ Id = productCatalogId } },new List<string> { "ProductCatalogId" });
            return items;
        }
		public List<Enterprise> SelectByProductCatalog(int productCatalogId)
        {
            List<Enterprise> items = this.SelectBy(new Enterprise { ProductCatalog = new Products.Entities.Catalog{ Id = productCatalogId } },new List<string> { "ProductCatalogId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
