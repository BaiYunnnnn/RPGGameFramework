using Script.Entity;

namespace Script.Module
{
    internal abstract class BaseEntityModule: IBaseModule<BaseEntity>
    {
        public abstract void Update(BaseEntity entity);
    }
}