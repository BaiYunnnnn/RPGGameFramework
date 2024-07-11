using Script.Entity.Player;

namespace Script.Module.PlayerModule
{
    internal abstract class BasePlayerModule: IBaseModule<Player>
    {
        public abstract void Update(Player obj);
    }
}