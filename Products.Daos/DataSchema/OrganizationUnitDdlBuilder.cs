using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos.DataSchema
{
	public class OrganizationUnitDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE OrganizationUnit(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Description nvarchar(255),,ManagerId nvarchar(255),ParentUnitId nvarchar(255),,OrganizationId nvarchar(255),Name nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE OrganizationUnit";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'OrganizationUnit'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
