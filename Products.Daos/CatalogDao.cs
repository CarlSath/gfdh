using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class CatalogDao : CommonObjectDao<Catalog>, ICatalogDao
	{
		public class CatalogSqlBuilder : ObjectSqlBuilder
		{
			public CatalogSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Catalog")
			{
				this.SqlInsert = "INSERT INTO Catalog (Code,Parentid," + this.SqlBaseFieldInsertFront + ") VALUES (@Code,@Parentid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Catalog SET Code=@Code,Parentid=@Parentid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class CatalogResultHandler : CommonObjectResultHandler<Catalog>
		{
			public override void GetColumnValues(IDataReader reader, Catalog item)
			{
				base.GetColumnValues(reader, item);
				int ordinalCode = reader.GetOrdinal("Code");
				item.Code = reader.IsDBNull(ordinalCode) ? null : reader.GetString(ordinalCode);
				int ordinalParentId = reader.GetOrdinal("ParentId");
				item.Parent = reader.IsDBNull(ordinalParentId) ? null :reader.GetInt32(ordinalParentId)==0?null:new Catalog { Id=reader.GetInt32(ordinalParentId)};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Catalog item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Code", item.Code ?? (object) DBNull.Value);
				context.AddParameter(command, "ParentId", item.Parent ==null? 0:item.Parent.Id);

				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public CatalogDao(SqlDialect sqlDialect) : base(new CatalogSqlBuilder(sqlDialect), new CatalogResultHandler())
		{
		}

		public CatalogDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new CatalogSqlBuilder(sqlDialect), new CatalogResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
