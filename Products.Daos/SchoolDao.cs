using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class SchoolDao : CommonObjectDao<School>, ISchoolDao
	{
		public class SchoolSqlBuilder : ObjectSqlBuilder
		{
			public SchoolSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"School")
			{
				this.SqlInsert = "INSERT INTO School (Phone," + this.SqlBaseFieldInsertFront + ") VALUES (@Phone," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE School SET Phone=@Phone," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class SchoolResultHandler : CommonObjectResultHandler<School>
		{
			public override void GetColumnValues(IDataReader reader, School item)
			{
				base.GetColumnValues(reader, item);
				int ordinalPhone = reader.GetOrdinal("Phone");
				item.Phone = reader.IsDBNull(ordinalPhone) ? null : reader.GetString(ordinalPhone);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, School item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Phone", item.Phone ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public SchoolDao(SqlDialect sqlDialect) : base(new SchoolSqlBuilder(sqlDialect), new SchoolResultHandler())
		{
		}

		public SchoolDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new SchoolSqlBuilder(sqlDialect), new SchoolResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
