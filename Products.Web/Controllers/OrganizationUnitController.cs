using Products.Entities;
using System.Collections.Generic;
using Products.Services.Interfaces;
using Products.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Controllers
{
	public class OrganizationUnitController:CommonController<OrganizationUnit, IOrganizationUnitService, OrganizationUnitModel>
	{


		protected override List<OrganizationUnit> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<OrganizationUnit> lists = this.Service.SelectBy(pagerSearchModel.Pager,new OrganizationUnit { Name = pagerSearchModel.Name }, organizationUnit => organizationUnit.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
