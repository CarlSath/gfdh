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
	[Route("/EnterpriseApi")]
	public class EnterpriseApiController : CommonApiController<Enterprise, IEnterpriseService>
	{


		[Route("SelectEnterpriseByProductCatalogs")]
		[HttpPost]
		public RequestResult SelectEnterpriseByProductCatalogs(int[] productCatalogIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<Enterprise> entities = this.Service.SelectEnterpriseByProductCatalogs(productCatalogIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByProductCatalog")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByProductCatalog(int pageIndex,int pageSize,int productCatalogId)
        {
            try
            {
                List<Enterprise> entities = this.Service.SelectByProductCatalog(pageIndex,pageSize,productCatalogId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByProductCatalog")]
		[HttpGet]
		public virtual RequestResult SelectByProductCatalog(int productCatalogId)
         {
            try
            {
                List<Enterprise> entities = this.Service.SelectByProductCatalog(productCatalogId);
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
