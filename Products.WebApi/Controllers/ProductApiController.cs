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
	[Route("/ProductApi")]
	public class ProductApiController : CommonApiController<Product, IProductService>
	{


		[Route("SelectProductByCatalogs")]
		[HttpPost]
		public RequestResult SelectProductByCatalogs(int[] catalogIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<Product> entities = this.Service.SelectProductByCatalogs(catalogIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }

		[Route("SelectProductByOwners")]
		[HttpPost]
		public RequestResult SelectProductByOwners(int[] ownerIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<Product> entities = this.Service.SelectProductByOwners(ownerIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByCatalog")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByCatalog(int pageIndex,int pageSize,int catalogId)
        {
            try
            {
                List<Product> entities = this.Service.SelectByCatalog(pageIndex,pageSize,catalogId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByCatalog")]
		[HttpGet]
		public virtual RequestResult SelectByCatalog(int catalogId)
         {
            try
            {
                List<Product> entities = this.Service.SelectByCatalog(catalogId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByCatalogOwner")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByCatalogOwner(int pageIndex,int pageSize,int catalogId,int ownerId)
        {
            try
            {
                List<Product> entities = this.Service.SelectByCatalogOwner(pageIndex,pageSize,catalogId,ownerId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByCatalogOwner")]
		[HttpGet]
		public virtual RequestResult SelectByCatalogOwner(int catalogId,int ownerId)
         {
            try
            {
                List<Product> entities = this.Service.SelectByCatalogOwner(catalogId,ownerId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByOwner")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByOwner(int pageIndex,int pageSize,int ownerId)
        {
            try
            {
                List<Product> entities = this.Service.SelectByOwner(pageIndex,pageSize,ownerId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByOwner")]
		[HttpGet]
		public virtual RequestResult SelectByOwner(int ownerId)
         {
            try
            {
                List<Product> entities = this.Service.SelectByOwner(ownerId);
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
