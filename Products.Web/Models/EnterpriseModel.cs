using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class EnterpriseModel: Products.Web.Models.LegalEntityModel<Enterprise>
	{
		public Catalog ProductCatalog {get; set;}
		public List<Catalog> ProductCatalogs { get; set; }

		public override void PopulateFrom(Enterprise entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.ProductCatalog = entity.ProductCatalog;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Enterprise entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.ProductCatalog = this.ProductCatalog;
			if (this.ProductCatalogs != null && this.ProductCatalogs.Count > 0)
		    {
		        entity.ProductCatalog = this.ProductCatalogs.Find(p => entity.ProductCatalog != null && entity.ProductCatalog.Id == p.Id);
            }
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
