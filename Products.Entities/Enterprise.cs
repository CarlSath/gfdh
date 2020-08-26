using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Entities
{
	public class Enterprise : LegalEntity
	{
		[DataMember]
		public Catalog ProductCatalog {get; set;}

	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
