using Products.Entities;
using System.Collections.Generic;
using Products.Services.Interfaces;
using Products.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Controllers
{
	public class SchoolController:CommonController<School, ISchoolService, SchoolModel>
	{


		protected override int DoInsert(School entity)
	    {
            return this.Service.Insert(entity, true);
	    }

	    protected override int DoUpdate(School entity)
	    {
            return this.Service.Update(entity, true);
	    }

	    protected override int DoDelete(School entity)
	    {
            return this.Service.Delete(entity, true);
	    }

		protected override School GetEntity(int id)
        {
            return this.Service.SelectById(new School { Id = id }, true);
        }

		protected override List<School> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<School> lists = this.Service.SelectBy(pagerSearchModel.Pager,new School { Name = pagerSearchModel.Name }, school => school.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
