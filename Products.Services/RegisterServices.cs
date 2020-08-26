using MetaShare.Common.Core.CommonService;
using Products.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(ICatalogService), new CatalogService(), isRegister);
			factory.Register(typeof(ISchoolService), new SchoolService(), isRegister);
			factory.Register(typeof(IProductService), new ProductService(), isRegister);
			factory.Register(typeof(IOrganizationUnitService), new OrganizationUnitService(), isRegister);
			factory.Register(typeof(IWorkerService), new WorkerService(), isRegister);
			factory.Register(typeof(IEnterpriseService), new EnterpriseService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
