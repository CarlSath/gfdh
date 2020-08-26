using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class Catalog : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public string Code {get; set;}

		[DataMember]
		public Catalog Parent {get; set;}

		[DataMember]
		public List<Catalog> SubCatalogs {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
