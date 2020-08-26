using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class CatalogModel: CommonModel<Catalog>
	{
		public string Code {get; set;}
		public Catalog Parent {get; set;}
		public List<Catalog> SubCatalogs {get; set;}

		public override void PopulateFrom(Catalog entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Code = entity.Code;
			this.Parent = entity.Parent;
			this.SubCatalogs = entity.SubCatalogs;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Catalog entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Code = this.Code;

			entity.Parent = this.Parent;

			entity.SubCatalogs = this.SubCatalogs;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
