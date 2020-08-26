using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class OrganizationModel<TEntity>: CommonModel<TEntity> where TEntity :Organization
	{
		public string Phone {get; set;}
		public List<OrganizationUnit> OrganizationUnits {get; set;}

		public override void PopulateFrom(TEntity entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Phone = entity.Phone;
			this.OrganizationUnits = entity.OrganizationUnits;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(TEntity entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Phone = this.Phone;

			entity.OrganizationUnits = this.OrganizationUnits;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
