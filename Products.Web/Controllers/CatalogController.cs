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
	public class CatalogController:CommonController<Catalog, ICatalogService, CatalogModel>
	{


		protected override List<Catalog> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Catalog> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Catalog { Name = pagerSearchModel.Name }, catalog => catalog.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
