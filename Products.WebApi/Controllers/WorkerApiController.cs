using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Products.Entities;
using Products.Services.Interfaces;
using Products.WebApi.Models;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.WebApi.Controllers
{
	[Route("/WorkerApi")]
	public class WorkerApiController : CommonApiController<Worker, IWorkerService>
	{


		[Route("SelectWorkerByOrganizationUnits")]
		[HttpPost]
		public RequestResult SelectWorkerByOrganizationUnits(int[] organizationUnitIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<Worker> entities = this.Service.SelectWorkerByOrganizationUnits(organizationUnitIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByOrganizationUnit")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByOrganizationUnit(int pageIndex,int pageSize,int organizationUnitId)
        {
            try
            {
                List<Worker> entities = this.Service.SelectByOrganizationUnit(pageIndex,pageSize,organizationUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByOrganizationUnit")]
		[HttpGet]
		public virtual RequestResult SelectByOrganizationUnit(int organizationUnitId)
         {
            try
            {
                List<Worker> entities = this.Service.SelectByOrganizationUnit(organizationUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
