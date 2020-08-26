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
	public class WorkerController:CommonController<Worker, IWorkerService, WorkerModel>
	{


		protected override List<Worker> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Worker> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Worker { Name = pagerSearchModel.Name }, worker => worker.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
