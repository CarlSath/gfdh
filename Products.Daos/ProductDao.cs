using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class ProductDao : CommonObjectDao<Product>, IProductDao
	{
		public class ProductSqlBuilder : ObjectSqlBuilder
		{
			public ProductSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Product")
			{
				this.SqlInsert = "INSERT INTO Product (CatalogDescription,OwnerDescription,OwnerName,Ownerid,Catalogid,CatalogName," + this.SqlBaseFieldInsertFront + ") VALUES (@CatalogDescription,@OwnerDescription,@OwnerName,@Ownerid,@Catalogid,@CatalogName," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Product SET CatalogDescription=@CatalogDescription,OwnerDescription=@OwnerDescription,OwnerName=@OwnerName,Ownerid=@Ownerid,Catalogid=@Catalogid,CatalogName=@CatalogName," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ProductResultHandler : CommonObjectResultHandler<Product>
		{
			public override void GetColumnValues(IDataReader reader, Product item)
			{
				base.GetColumnValues(reader, item);
				int ordinalCatalogId = reader.GetOrdinal("CatalogId");
				int ordinalCatalogName = reader.GetOrdinal("CatalogName");
				string catalogName= reader.IsDBNull(ordinalCatalogName) ? null :reader.GetString(ordinalCatalogName);
				int ordinalCatalogDescription = reader.GetOrdinal("CatalogDescription");
				string catalogDescription= reader.IsDBNull(ordinalCatalogDescription) ? null:reader.GetString(ordinalCatalogDescription);
				item.Catalog = reader.IsDBNull(ordinalCatalogId) ? null :reader.GetInt32(ordinalCatalogId)==0?null:new Catalog { Id=reader.GetInt32(ordinalCatalogId), Name = catalogName, Description = catalogDescription};
				int ordinalOwnerId = reader.GetOrdinal("OwnerId");
				int ordinalOwnerName = reader.GetOrdinal("OwnerName");
				string ownerName= reader.IsDBNull(ordinalOwnerName) ? null :reader.GetString(ordinalOwnerName);
				int ordinalOwnerDescription = reader.GetOrdinal("OwnerDescription");
				string ownerDescription= reader.IsDBNull(ordinalOwnerDescription) ? null:reader.GetString(ordinalOwnerDescription);
				item.Owner = reader.IsDBNull(ordinalOwnerId) ? null :reader.GetInt32(ordinalOwnerId)==0?null:new Enterprise { Id=reader.GetInt32(ordinalOwnerId), Name = ownerName, Description = ownerDescription};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Product item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "CatalogId", item.Catalog ==null? 0:item.Catalog.Id);
                context.AddParameter(command, "CatalogName", item.Catalog ==null?(object)DBNull.Value : string.IsNullOrEmpty(item.Catalog.Name) ? (object)DBNull.Value : item.Catalog.Name);
                context.AddParameter(command, "CatalogDescription", item.Catalog ==null? (object)DBNull.Value : string.IsNullOrEmpty(item.Catalog.Description) ? (object)DBNull.Value : item.Catalog.Description);

				context.AddParameter(command, "OwnerId", item.Owner ==null? 0:item.Owner.Id);
                context.AddParameter(command, "OwnerName", item.Owner ==null?(object)DBNull.Value : string.IsNullOrEmpty(item.Owner.Name) ? (object)DBNull.Value : item.Owner.Name);
                context.AddParameter(command, "OwnerDescription", item.Owner ==null? (object)DBNull.Value : string.IsNullOrEmpty(item.Owner.Description) ? (object)DBNull.Value : item.Owner.Description);

				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public ProductDao(SqlDialect sqlDialect) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler())
		{
		}

		public ProductDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
