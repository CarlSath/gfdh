using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class SchoolModel: Products.Web.Models.LegalEntityModel<School>
	{

		public override void PopulateFrom(School entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(School entity)
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
