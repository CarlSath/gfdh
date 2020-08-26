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
	public class ProductController:CommonController<Product, IProductService, ProductModel>
	{


		protected override void LoadViewReferenceData(ProductModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);

			ICatalogService catalogService = ServiceFactory.Instance.GetService<ICatalogService>();
			model.Catalogs = catalogService.SelectAll();

			IEnterpriseService enterpriseService = ServiceFactory.Instance.GetService<IEnterpriseService>();
			model.Owners = enterpriseService.SelectAll();

		}

		protected override Product GetEntity(int id)
        {
            return this.Service.SelectById(new Product { Id = id }, true);
        }

		protected override List<Product> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Product> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Product { Name = pagerSearchModel.Name }, product => product.Name.Contains(pagerSearchModel.Name));
        return this.Service.SelectAllWithReferenceData(lists);
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
