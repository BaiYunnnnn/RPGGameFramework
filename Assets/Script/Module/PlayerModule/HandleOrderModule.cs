using Script.Entity.Player;
using UnityEngine;

namespace Script.Module.PlayerModule
{
    internal class HandleOrderModule: BasePlayerModule
    {
        public override void Update(Player player)
        {
            HandleMoveOrder(player);
        }

        private void HandleMoveOrder(Player player)
        {
            Vector2 nowDire = Vector2.zero;
            if (player.ForwardOrder)
            {
                nowDire += Vector2.right;
            }

            if (player.BackwardOrder)
            {
                nowDire += Vector2.left;
            }

            if (player.RightOrder)
            {
                nowDire += Vector2.up;
            }
            if (player.LeftOrder)
            {
                nowDire += Vector2.down;
            }

            player.SpeedVec = nowDire.normalized * player.maxSpeed;
        }
    }
}