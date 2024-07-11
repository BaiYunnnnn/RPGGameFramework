using Script.Entity;

namespace Script.Module
{
    internal class HealthModule: BaseEntityModule
    {
        public override void Update(BaseEntity entity)
        {
            
        }

        internal void ChangeHealth(BaseEntity entity, int delta)
        {
            entity.Health += delta;
            if (entity.Health <= 0) entity.Died = true;
        }
    }
}