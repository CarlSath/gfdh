using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class OrganizationUnitModel: CommonModel<OrganizationUnit>
	{
		public List<Worker> Employees {get; set;}
		public Worker Manager {get; set;}
		public OrganizationUnit ParentUnit {get; set;}
		public List<OrganizationUnit> ChildUnits {get; set;}

		public override void PopulateFrom(OrganizationUnit entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Employees = entity.Employees;
			this.Manager = entity.Manager;
			this.ParentUnit = entity.ParentUnit;
			this.ChildUnits = entity.ChildUnits;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(OrganizationUnit entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Employees = this.Employees;

			entity.Manager = this.Manager;

			entity.ParentUnit = this.ParentUnit;

			entity.ChildUnits = this.ChildUnits;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
