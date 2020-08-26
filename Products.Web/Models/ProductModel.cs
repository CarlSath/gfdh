using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class ProductModel: CommonModel<Product>
	{
		public Catalog Catalog {get; set;}
		public List<Catalog> Catalogs { get; set; }
		public Enterprise Owner {get; set;}
		public List<Enterprise> Owners { get; set; }

		public override void PopulateFrom(Product entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Catalog = entity.Catalog;
			this.Owner = entity.Owner;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Product entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Catalog = this.Catalog;
			if (this.Catalogs != null && this.Catalogs.Count > 0)
		    {
		        entity.Catalog = this.Catalogs.Find(p => entity.Catalog != null && entity.Catalog.Id == p.Id);
            }
			entity.Owner = this.Owner;
			if (this.Owners != null && this.Owners.Count > 0)
		    {
		        entity.Owner = this.Owners.Find(p => entity.Owner != null && entity.Owner.Id == p.Id);
            }
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
