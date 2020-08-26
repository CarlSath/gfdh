using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class Product : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public Catalog Catalog {get; set;}

		[DataMember]
		public Enterprise Owner {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
