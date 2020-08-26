using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos.DataSchema
{
	public class SchoolDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE School(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Name nvarchar(255),Description nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE School";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'School'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
