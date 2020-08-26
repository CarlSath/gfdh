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
	public class WorkerService : Service<Worker>, IWorkerService
	{
		public WorkerService() : base(typeof (IWorkerDao))
		{
		}

		public List<Worker> SelectWorkerByOrganizationUnits(int[] organizationUnitIds, bool isAggregatedChildren = false)
        {
            List<Worker> items = this.SelectByColumnIds("OrganizationUnitId",organizationUnitIds,isAggregatedChildren);
            return items;
        }
		public List<Worker> SelectWorkerByOrganizationUnits(Pager pager, int[] organizationUnitIds, bool isAggregatedChildren = false)
        {
            List<Worker> items = this.SelectByColumnIds(pager,"OrganizationUnitId",organizationUnitIds,isAggregatedChildren);
            return items;
        }
		public List<Worker> SelectByOrganizationUnit(int pageIndex,int pageSize,int organizationUnitId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Worker> items = this.SelectBy(pager,new Worker { OrganizationUnit = new Products.Entities.OrganizationUnit{ Id = organizationUnitId } },new List<string> { "OrganizationUnitId" });
            return items;
        }
		public List<Worker> SelectByOrganizationUnit(int organizationUnitId)
        {
            List<Worker> items = this.SelectBy(new Worker { OrganizationUnit = new Products.Entities.OrganizationUnit{ Id = organizationUnitId } },new List<string> { "OrganizationUnitId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
