using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services.Interfaces
{
	public interface IWorkerService : IPagingService<Worker>
	{
	        List<Worker> SelectWorkerByOrganizationUnits(int[] organizationUnitIds, bool isAggregatedChildren = false);
	        List<Worker> SelectWorkerByOrganizationUnits(Pager pager,int[] organizationUnitIds, bool isAggregatedChildren = false);
	        List<Worker> SelectByOrganizationUnit(int pageIndex,int pageSize,int organizationUnitId);
	        List<Worker> SelectByOrganizationUnit(int organizationUnitId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
