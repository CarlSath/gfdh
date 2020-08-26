using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class Organization : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string Phone {get; set;}

		[DataMember]
		public List<OrganizationUnit> OrganizationUnits {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
