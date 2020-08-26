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
	[Route("/CatalogApi")]
	public class CatalogApiController : CommonApiController<Catalog, ICatalogService>
	{


		[Route("SelectCatalogByParents")]
		[HttpPost]
		public RequestResult SelectCatalogByParents(int[] parentIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<Catalog> entities = this.Service.SelectCatalogByParents(parentIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByParent")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByParent(int pageIndex,int pageSize,int parentId)
        {
            try
            {
                List<Catalog> entities = this.Service.SelectByParent(pageIndex,pageSize,parentId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByParent")]
		[HttpGet]
		public virtual RequestResult SelectByParent(int parentId)
         {
            try
            {
                List<Catalog> entities = this.Service.SelectByParent(parentId);
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
