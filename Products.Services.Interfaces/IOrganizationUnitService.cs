using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services.Interfaces
{
	public interface IOrganizationUnitService : IPagingService<OrganizationUnit>
	{
	        List<OrganizationUnit> SelectOrganizationUnitByManagers(int[] managerIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectOrganizationUnitByManagers(Pager pager,int[] managerIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectOrganizationUnitByParentUnits(int[] parentUnitIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectOrganizationUnitByParentUnits(Pager pager,int[] parentUnitIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectOrganizationUnitByOrganizations(int[] organizationIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectOrganizationUnitByOrganizations(Pager pager,int[] organizationIds, bool isAggregatedChildren = false);
	        List<OrganizationUnit> SelectByManager(int pageIndex,int pageSize,int managerId);
	        List<OrganizationUnit> SelectByManager(int managerId);
	        List<OrganizationUnit> SelectByManagerOrganization(int pageIndex,int pageSize,int managerId,int organizationId);
	        List<OrganizationUnit> SelectByManagerOrganization(int managerId,int organizationId);
	        List<OrganizationUnit> SelectByManagerParentUnit(int pageIndex,int pageSize,int managerId,int parentUnitId);
	        List<OrganizationUnit> SelectByManagerParentUnit(int managerId,int parentUnitId);
	        List<OrganizationUnit> SelectByOrganization(int pageIndex,int pageSize,int organizationId);
	        List<OrganizationUnit> SelectByOrganization(int organizationId);
	        List<OrganizationUnit> SelectByOrganizationParentUnit(int pageIndex,int pageSize,int organizationId,int parentUnitId);
	        List<OrganizationUnit> SelectByOrganizationParentUnit(int organizationId,int parentUnitId);
	        List<OrganizationUnit> SelectByParentUnit(int pageIndex,int pageSize,int parentUnitId);
	        List<OrganizationUnit> SelectByParentUnit(int parentUnitId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
