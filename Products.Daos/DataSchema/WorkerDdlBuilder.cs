using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos.DataSchema
{
	public class WorkerDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE Worker(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Description nvarchar(255),Name nvarchar(255),LastName nvarchar(255),OrganizationUnitId nvarchar(255),FirstName nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE Worker";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'Worker'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
