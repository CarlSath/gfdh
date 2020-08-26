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
	public class EnterpriseController:CommonController<Enterprise, IEnterpriseService, EnterpriseModel>
	{


		protected override void LoadViewReferenceData(EnterpriseModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);

			ICatalogService catalogService = ServiceFactory.Instance.GetService<ICatalogService>();
			model.ProductCatalogs = catalogService.SelectAll();

		}

		protected override int DoInsert(Enterprise entity)
	    {
            return this.Service.Insert(entity, true);
	    }

	    protected override int DoUpdate(Enterprise entity)
	    {
            return this.Service.Update(entity, true);
	    }

	    protected override int DoDelete(Enterprise entity)
	    {
            return this.Service.Delete(entity, true);
	    }

		protected override Enterprise GetEntity(int id)
        {
            return this.Service.SelectById(new Enterprise { Id = id }, true);
        }

		protected override List<Enterprise> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Enterprise> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Enterprise { Name = pagerSearchModel.Name }, enterprise => enterprise.Name.Contains(pagerSearchModel.Name));
        return this.Service.SelectAllWithReferenceData(lists);
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
