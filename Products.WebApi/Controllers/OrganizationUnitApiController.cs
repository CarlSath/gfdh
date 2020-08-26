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
	[Route("/OrganizationUnitApi")]
	public class OrganizationUnitApiController : CommonApiController<OrganizationUnit, IOrganizationUnitService>
	{


		[Route("SelectOrganizationUnitByManagers")]
		[HttpPost]
		public RequestResult SelectOrganizationUnitByManagers(int[] managerIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<OrganizationUnit> entities = this.Service.SelectOrganizationUnitByManagers(managerIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }

		[Route("SelectOrganizationUnitByParentUnits")]
		[HttpPost]
		public RequestResult SelectOrganizationUnitByParentUnits(int[] parentUnitIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<OrganizationUnit> entities = this.Service.SelectOrganizationUnitByParentUnits(parentUnitIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }

		[Route("SelectOrganizationUnitByOrganizations")]
		[HttpPost]
		public RequestResult SelectOrganizationUnitByOrganizations(int[] organizationIds, bool isAggregatedChildren)
        {        
            try        
            {
                List<OrganizationUnit> entities = this.Service.SelectOrganizationUnitByOrganizations(organizationIds,isAggregatedChildren);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch (Exception)
            {
                return new RequestResult { IsSucceed = false, Message = SelectFailed, Data = null };
            }
        }


		[Route("SelectWithPageByManager")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByManager(int pageIndex,int pageSize,int managerId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManager(pageIndex,pageSize,managerId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByManager")]
		[HttpGet]
		public virtual RequestResult SelectByManager(int managerId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManager(managerId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByManagerOrganization")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByManagerOrganization(int pageIndex,int pageSize,int managerId,int organizationId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManagerOrganization(pageIndex,pageSize,managerId,organizationId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByManagerOrganization")]
		[HttpGet]
		public virtual RequestResult SelectByManagerOrganization(int managerId,int organizationId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManagerOrganization(managerId,organizationId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByManagerParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByManagerParentUnit(int pageIndex,int pageSize,int managerId,int parentUnitId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManagerParentUnit(pageIndex,pageSize,managerId,parentUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByManagerParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectByManagerParentUnit(int managerId,int parentUnitId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByManagerParentUnit(managerId,parentUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByOrganization")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByOrganization(int pageIndex,int pageSize,int organizationId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByOrganization(pageIndex,pageSize,organizationId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByOrganization")]
		[HttpGet]
		public virtual RequestResult SelectByOrganization(int organizationId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByOrganization(organizationId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByOrganizationParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByOrganizationParentUnit(int pageIndex,int pageSize,int organizationId,int parentUnitId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByOrganizationParentUnit(pageIndex,pageSize,organizationId,parentUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByOrganizationParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectByOrganizationParentUnit(int organizationId,int parentUnitId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByOrganizationParentUnit(organizationId,parentUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectWithPageByParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectWithPageByParentUnit(int pageIndex,int pageSize,int parentUnitId)
        {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByParentUnit(pageIndex,pageSize,parentUnitId);
                return new RequestResult { IsSucceed = true, Message = SelectSuccessful, Data = entities };
            }
            catch
            {
                return new RequestResult { IsSucceed = false, Message = SelectNotFound, Data = null };
            }
        }
		[Route("SelectByParentUnit")]
		[HttpGet]
		public virtual RequestResult SelectByParentUnit(int parentUnitId)
         {
            try
            {
                List<OrganizationUnit> entities = this.Service.SelectByParentUnit(parentUnitId);
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
