using Script.Entity;
using Script.Module.PlayerModule;
using UnityEngine;

namespace Script.Module
{
    internal class TransformModule: BaseEntityModule
    {
        public override void Update(BaseEntity entity)
        {
            Move(entity);
        }

        protected void Move(BaseEntity entity)
        {
            Vector3 deltaPos = new Vector3(entity.SpeedVec[1], 0, entity.SpeedVec[0]) * Time.deltaTime;
            entity.transform.position += deltaPos;
        }
    }
}