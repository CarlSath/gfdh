using System;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.Models
{
	public class ObjectVersionModel<TEntity> : CommonModel<TEntity> where TEntity : ObjectVersion
    {
        public int SystemId { get; set; }

        public int Version { get; set; }

        public int ModifiedUserId { get; set; }

        public string ModifiedUserName { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public DataOperationType OperationType { get; set; }

        public DateTime EffectiveStartDateTime { get; set; }

        public DateTime EffectiveEndDateTime { get; set; }
        
        /*add customized code between this region*/
        /*add customized code between this region*/

        public override void PopulateFrom(TEntity entity)
        {
            if (entity == null) return;
            base.PopulateFrom(entity);

            this.SystemId = entity.SystemId;
            this.Version = entity.Version;
            this.ModifiedUserId = entity.ModifiedUserId;
            this.ModifiedUserName = entity.ModifiedUserName;
            this.ModifiedDateTime = entity.ModifiedDateTime;
            this.OperationType = entity.OperationType;
            this.EffectiveStartDateTime = entity.EffectiveStartDateTime;
            this.EffectiveEndDateTime = entity.EffectiveEndDateTime;
            /*add customized code between this region*/
            /*add customized code between this region*/
        }
	/*add customized code between this region*/
	/*add customized code between this region*/
	   }
}
            
