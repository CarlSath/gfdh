using MetaShare.Common.Core.DataSchema;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos.DataSchema
{
	public class EnterpriseDdlBuilder : DdlBuilder
	{
		public override string GetSqlCreateTable()
		{
			return @"CREATE TABLE Enterprise(Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,Description nvarchar(255),ProductCatalogId nvarchar(255),Name nvarchar(255),Description nvarchar(255),Owner_Id int,Entity_Status int)";
		}

		public override string GetSqlDropTable()
		{
			return @"DROP TABLE Enterprise";
		}

		public override string GetSqlExistTable()
		{
			return @"SELECT COUNT(*) FROM Information_Schema.COLUMNS WHERE TABLE_NAME = 'Enterprise'";
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
