using Script.Entity.Player;
using Script.GameSystem;
using UnityEngine;

namespace Script.Module.PlayerModule
{
    internal class PlayerInputModule: BasePlayerModule
    {
        public override void Update(Player player)
        {
            player.ForwardOrder = Input.GetKey(GlobalConfigure.PlayerConfigure.Forward);
            player.BackwardOrder = Input.GetKey(GlobalConfigure.PlayerConfigure.Backward);
            player.LeftOrder = Input.GetKey(GlobalConfigure.PlayerConfigure.Left);
            player.RightOrder = Input.GetKey(GlobalConfigure.PlayerConfigure.Right);
        }
    }
}