using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class LegalEntityModel<TEntity>: Products.Web.Models.OrganizationModel<TEntity> where TEntity :LegalEntity
	{

		public override void PopulateFrom(TEntity entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(TEntity entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
