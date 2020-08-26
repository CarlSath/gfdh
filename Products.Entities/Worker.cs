using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class Worker : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string LastName {get; set;}

		[DataMember]
		public OrganizationUnit OrganizationUnit {get; set;}

		[DataMember]
		public string FirstName {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
