using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class OrganizationUnit : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public List<Worker> Employees {get; set;}

		[DataMember]
		public Worker Manager {get; set;}

		[DataMember]
		public OrganizationUnit ParentUnit {get; set;}

		[DataMember]
		public List<OrganizationUnit> ChildUnits {get; set;}

		[DataMember]
		public Organization Organization {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
