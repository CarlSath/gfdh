using System;
using MetaShare.Common.Core.Daos;
using Products.Daos.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}

		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}

		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(ICatalogDao), new CatalogDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(ISchoolDao), new SchoolDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IProductDao), new ProductDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IOrganizationUnitDao), new OrganizationUnitDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IWorkerDao), new WorkerDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IEnterpriseDao), new EnterpriseDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
