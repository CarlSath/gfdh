using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class EnterpriseDao : CommonObjectDao<Enterprise>, IEnterpriseDao
	{
		public class EnterpriseSqlBuilder : ObjectSqlBuilder
		{
			public EnterpriseSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Enterprise")
			{
				this.SqlInsert = "INSERT INTO Enterprise (Phone,ProductCatalogid,ProductCatalogName,ProductCatalogDescription," + this.SqlBaseFieldInsertFront + ") VALUES (@Phone,@ProductCatalogid,@ProductCatalogName,@ProductCatalogDescription," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Enterprise SET Phone=@Phone,ProductCatalogid=@ProductCatalogid,ProductCatalogName=@ProductCatalogName,ProductCatalogDescription=@ProductCatalogDescription," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class EnterpriseResultHandler : CommonObjectResultHandler<Enterprise>
		{
			public override void GetColumnValues(IDataReader reader, Enterprise item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPhone = reader.GetOrdinal("Phone");
				item.Phone = reader.IsDBNull(ordinalPhone) ? null : reader.GetString(ordinalPhone);
				int ordinalProductCatalogId = reader.GetOrdinal("ProductCatalogId");
				int ordinalProductCatalogName = reader.GetOrdinal("ProductCatalogName");
				string productCatalogName= reader.IsDBNull(ordinalProductCatalogName) ? null :reader.GetString(ordinalProductCatalogName);
				int ordinalProductCatalogDescription = reader.GetOrdinal("ProductCatalogDescription");
				string productCatalogDescription= reader.IsDBNull(ordinalProductCatalogDescription) ? null:reader.GetString(ordinalProductCatalogDescription);
				item.ProductCatalog = reader.IsDBNull(ordinalProductCatalogId) ? null :reader.GetInt32(ordinalProductCatalogId)==0?null:new Catalog { Id=reader.GetInt32(ordinalProductCatalogId), Name = productCatalogName, Description = productCatalogDescription};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Enterprise item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Phone", item.Phone ?? (object) DBNull.Value);
				context.AddParameter(command, "ProductCatalogId", item.ProductCatalog ==null? 0:item.ProductCatalog.Id);
                context.AddParameter(command, "ProductCatalogName", item.ProductCatalog ==null?(object)DBNull.Value : string.IsNullOrEmpty(item.ProductCatalog.Name) ? (object)DBNull.Value : item.ProductCatalog.Name);
                context.AddParameter(command, "ProductCatalogDescription", item.ProductCatalog ==null? (object)DBNull.Value : string.IsNullOrEmpty(item.ProductCatalog.Description) ? (object)DBNull.Value : item.ProductCatalog.Description);

				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public EnterpriseDao(SqlDialect sqlDialect) : base(new EnterpriseSqlBuilder(sqlDialect), new EnterpriseResultHandler())
		{
		}

		public EnterpriseDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new EnterpriseSqlBuilder(sqlDialect), new EnterpriseResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
