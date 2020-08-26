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
	public class SchoolService : Service<School>, ISchoolService
	{
		public SchoolService() : base(typeof (ISchoolDao))
		{
			ServiceAggregationInfo organizationUnitsServiceAggregation = this.ServiceAggregationInfo.AddCompositeCollectionChild("OrganizationUnits", typeof(Products.Entities.OrganizationUnit), typeof(Products.Daos.Interfaces.IOrganizationUnitDao), "Organization");
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
