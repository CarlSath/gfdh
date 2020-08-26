using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class WorkerDao : CommonObjectDao<Worker>, IWorkerDao
	{
		public class WorkerSqlBuilder : ObjectSqlBuilder
		{
			public WorkerSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Worker")
			{
				this.SqlInsert = "INSERT INTO Worker (LastName,FirstName,OrganizationUnitid," + this.SqlBaseFieldInsertFront + ") VALUES (@LastName,@FirstName,@OrganizationUnitid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Worker SET LastName=@LastName,FirstName=@FirstName,OrganizationUnitid=@OrganizationUnitid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class WorkerResultHandler : CommonObjectResultHandler<Worker>
		{
			public override void GetColumnValues(IDataReader reader, Worker item)
			{
				base.GetColumnValues(reader, item);
				int ordinalLastName = reader.GetOrdinal("LastName");
				item.LastName = reader.IsDBNull(ordinalLastName) ? null : reader.GetString(ordinalLastName);
				int ordinalOrganizationUnitId = reader.GetOrdinal("OrganizationUnitId");
				item.OrganizationUnit = reader.IsDBNull(ordinalOrganizationUnitId) ? null :reader.GetInt32(ordinalOrganizationUnitId)==0?null:new OrganizationUnit { Id=reader.GetInt32(ordinalOrganizationUnitId)};
				int ordinalFirstName = reader.GetOrdinal("FirstName");
				item.FirstName = reader.IsDBNull(ordinalFirstName) ? null : reader.GetString(ordinalFirstName);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Worker item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "LastName", item.LastName ?? (object) DBNull.Value);
				context.AddParameter(command, "OrganizationUnitId", item.OrganizationUnit ==null? 0:item.OrganizationUnit.Id);

				context.AddParameter(command, "FirstName", item.FirstName ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public WorkerDao(SqlDialect sqlDialect) : base(new WorkerSqlBuilder(sqlDialect), new WorkerResultHandler())
		{
		}

		public WorkerDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new WorkerSqlBuilder(sqlDialect), new WorkerResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
