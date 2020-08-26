using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Products.Entities;
using MetaShare.Common.Core.Services;
using Products.Daos.Interfaces;
using Products.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services
{
	public class OrganizationUnitService : Service<OrganizationUnit>, IOrganizationUnitService
	{
		public OrganizationUnitService() : base(typeof (IOrganizationUnitDao))
		{
		}

		public List<OrganizationUnit> SelectOrganizationUnitByManagers(int[] managerIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds("ManagerId",managerIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectOrganizationUnitByManagers(Pager pager, int[] managerIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds(pager,"ManagerId",managerIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectOrganizationUnitByParentUnits(int[] parentUnitIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds("ParentUnitId",parentUnitIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectOrganizationUnitByParentUnits(Pager pager, int[] parentUnitIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds(pager,"ParentUnitId",parentUnitIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectOrganizationUnitByOrganizations(int[] organizationIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds("OrganizationId",organizationIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectOrganizationUnitByOrganizations(Pager pager, int[] organizationIds, bool isAggregatedChildren = false)
        {
            List<OrganizationUnit> items = this.SelectByColumnIds(pager,"OrganizationId",organizationIds,isAggregatedChildren);
            return items;
        }
		public List<OrganizationUnit> SelectByManager(int pageIndex,int pageSize,int managerId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId } },new List<string> { "ManagerId" });
            return items;
        }
		public List<OrganizationUnit> SelectByManager(int managerId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId } },new List<string> { "ManagerId" });
            return items;
        }
		public List<OrganizationUnit> SelectByManagerOrganization(int pageIndex,int pageSize,int managerId,int organizationId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId },Organization = new Products.Entities.Organization{ Id = organizationId } },new List<string> { "ManagerId","OrganizationId" });
            return items;
        }
		public List<OrganizationUnit> SelectByManagerOrganization(int managerId,int organizationId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId },Organization = new Products.Entities.Organization{ Id = organizationId } },new List<string> { "ManagerId","OrganizationId" });
            return items;
        }
		public List<OrganizationUnit> SelectByManagerParentUnit(int pageIndex,int pageSize,int managerId,int parentUnitId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId },ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "ManagerId","ParentUnitId" });
            return items;
        }
		public List<OrganizationUnit> SelectByManagerParentUnit(int managerId,int parentUnitId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { Manager = new Products.Entities.Worker{ Id = managerId },ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "ManagerId","ParentUnitId" });
            return items;
        }
		public List<OrganizationUnit> SelectByOrganization(int pageIndex,int pageSize,int organizationId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { Organization = new Products.Entities.Organization{ Id = organizationId } },new List<string> { "OrganizationId" });
            return items;
        }
		public List<OrganizationUnit> SelectByOrganization(int organizationId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { Organization = new Products.Entities.Organization{ Id = organizationId } },new List<string> { "OrganizationId" });
            return items;
        }
		public List<OrganizationUnit> SelectByOrganizationParentUnit(int pageIndex,int pageSize,int organizationId,int parentUnitId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { Organization = new Products.Entities.Organization{ Id = organizationId },ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "OrganizationId","ParentUnitId" });
            return items;
        }
		public List<OrganizationUnit> SelectByOrganizationParentUnit(int organizationId,int parentUnitId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { Organization = new Products.Entities.Organization{ Id = organizationId },ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "OrganizationId","ParentUnitId" });
            return items;
        }
		public List<OrganizationUnit> SelectByParentUnit(int pageIndex,int pageSize,int parentUnitId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<OrganizationUnit> items = this.SelectBy(pager,new OrganizationUnit { ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "ParentUnitId" });
            return items;
        }
		public List<OrganizationUnit> SelectByParentUnit(int parentUnitId)
        {
            List<OrganizationUnit> items = this.SelectBy(new OrganizationUnit { ParentUnit = new Products.Entities.OrganizationUnit{ Id = parentUnitId } },new List<string> { "ParentUnitId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
