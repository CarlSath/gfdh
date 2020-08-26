using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class OrganizationUnitDao : CommonObjectDao<OrganizationUnit>, IOrganizationUnitDao
	{
		public class OrganizationUnitSqlBuilder : ObjectSqlBuilder
		{
			public OrganizationUnitSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"OrganizationUnit")
			{
				this.SqlInsert = "INSERT INTO OrganizationUnit (Managerid,ParentUnitid,Organizationid," + this.SqlBaseFieldInsertFront + ") VALUES (@Managerid,@ParentUnitid,@Organizationid," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE OrganizationUnit SET Managerid=@Managerid,ParentUnitid=@ParentUnitid,Organizationid=@Organizationid," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class OrganizationUnitResultHandler : CommonObjectResultHandler<OrganizationUnit>
		{
			public override void GetColumnValues(IDataReader reader, OrganizationUnit item)
			{
				base.GetColumnValues(reader, item);
				int ordinalManagerId = reader.GetOrdinal("ManagerId");
				item.Manager = reader.IsDBNull(ordinalManagerId) ? null :reader.GetInt32(ordinalManagerId)==0?null:new Worker { Id=reader.GetInt32(ordinalManagerId)};
				int ordinalParentUnitId = reader.GetOrdinal("ParentUnitId");
				item.ParentUnit = reader.IsDBNull(ordinalParentUnitId) ? null :reader.GetInt32(ordinalParentUnitId)==0?null:new OrganizationUnit { Id=reader.GetInt32(ordinalParentUnitId)};
				int ordinalOrganizationId = reader.GetOrdinal("OrganizationId");
				item.Organization = reader.IsDBNull(ordinalOrganizationId) ? null :reader.GetInt32(ordinalOrganizationId)==0?null:new Organization { Id=reader.GetInt32(ordinalOrganizationId)};
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, OrganizationUnit item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "ManagerId", item.Manager ==null? 0:item.Manager.Id);

				context.AddParameter(command, "ParentUnitId", item.ParentUnit ==null? 0:item.ParentUnit.Id);

				context.AddParameter(command, "OrganizationId", item.Organization ==null? 0:item.Organization.Id);

				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public OrganizationUnitDao(SqlDialect sqlDialect) : base(new OrganizationUnitSqlBuilder(sqlDialect), new OrganizationUnitResultHandler())
		{
		}

		public OrganizationUnitDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new OrganizationUnitSqlBuilder(sqlDialect), new OrganizationUnitResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
