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
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
			ServiceAggregationInfo catalogServiceAggregationInfo =  this.ServiceAggregationInfo.AddReferenceChild("Catalog", typeof(Products.Entities.Catalog), typeof(Products.Daos.Interfaces.ICatalogDao));
			ServiceAggregationInfo ownerServiceAggregationInfo =  this.ServiceAggregationInfo.AddReferenceChild("Owner", typeof(Products.Entities.Enterprise), typeof(Products.Daos.Interfaces.IEnterpriseDao));
		}

		public List<Product> SelectAllWithReferenceData(List<Product> items)
        {
            if (items != null && items.Count > 0)
            {
                return this.SelectBy(items, this.CreateReferenceInfoAggregation());
            }
            return items;
        }

        private ServiceAggregationInfo CreateReferenceInfoAggregation()
        {
            ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(Product), typeof(IProductDao));
		    aggregation.AddReferenceChild("Catalog", typeof(Products.Entities.Catalog), typeof(Products.Daos.Interfaces.ICatalogDao));
		    aggregation.AddReferenceChild("Owner", typeof(Products.Entities.Enterprise), typeof(Products.Daos.Interfaces.IEnterpriseDao));

		    return aggregation;
        }

		public List<Product> SelectProductByCatalogs(int[] catalogIds, bool isAggregatedChildren = false)
        {
            List<Product> items = this.SelectByColumnIds("CatalogId",catalogIds,isAggregatedChildren);
            return items;
        }
		public List<Product> SelectProductByCatalogs(Pager pager, int[] catalogIds, bool isAggregatedChildren = false)
        {
            List<Product> items = this.SelectByColumnIds(pager,"CatalogId",catalogIds,isAggregatedChildren);
            return items;
        }
		public List<Product> SelectProductByOwners(int[] ownerIds, bool isAggregatedChildren = false)
        {
            List<Product> items = this.SelectByColumnIds("OwnerId",ownerIds,isAggregatedChildren);
            return items;
        }
		public List<Product> SelectProductByOwners(Pager pager, int[] ownerIds, bool isAggregatedChildren = false)
        {
            List<Product> items = this.SelectByColumnIds(pager,"OwnerId",ownerIds,isAggregatedChildren);
            return items;
        }
		public List<Product> SelectByCatalog(int pageIndex,int pageSize,int catalogId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Product> items = this.SelectBy(pager,new Product { Catalog = new Products.Entities.Catalog{ Id = catalogId } },new List<string> { "CatalogId" });
            return items;
        }
		public List<Product> SelectByCatalog(int catalogId)
        {
            List<Product> items = this.SelectBy(new Product { Catalog = new Products.Entities.Catalog{ Id = catalogId } },new List<string> { "CatalogId" });
            return items;
        }
		public List<Product> SelectByCatalogOwner(int pageIndex,int pageSize,int catalogId,int ownerId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Product> items = this.SelectBy(pager,new Product { Catalog = new Products.Entities.Catalog{ Id = catalogId },Owner = new Products.Entities.Enterprise{ Id = ownerId } },new List<string> { "CatalogId","OwnerId" });
            return items;
        }
		public List<Product> SelectByCatalogOwner(int catalogId,int ownerId)
        {
            List<Product> items = this.SelectBy(new Product { Catalog = new Products.Entities.Catalog{ Id = catalogId },Owner = new Products.Entities.Enterprise{ Id = ownerId } },new List<string> { "CatalogId","OwnerId" });
            return items;
        }
		public List<Product> SelectByOwner(int pageIndex,int pageSize,int ownerId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Product> items = this.SelectBy(pager,new Product { Owner = new Products.Entities.Enterprise{ Id = ownerId } },new List<string> { "OwnerId" });
            return items;
        }
		public List<Product> SelectByOwner(int ownerId)
        {
            List<Product> items = this.SelectBy(new Product { Owner = new Products.Entities.Enterprise{ Id = ownerId } },new List<string> { "OwnerId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
