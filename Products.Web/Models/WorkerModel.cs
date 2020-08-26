using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class WorkerModel: CommonModel<Worker>
	{
		public string LastName {get; set;}
		public OrganizationUnit OrganizationUnit {get; set;}
		public string FirstName {get; set;}

		public override void PopulateFrom(Worker entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.LastName = entity.LastName;
			this.OrganizationUnit = entity.OrganizationUnit;
			this.FirstName = entity.FirstName;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Worker entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.LastName = this.LastName;

			entity.OrganizationUnit = this.OrganizationUnit;

			entity.FirstName = this.FirstName;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
