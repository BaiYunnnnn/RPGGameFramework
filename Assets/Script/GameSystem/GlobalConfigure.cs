using UnityEngine;

namespace Script.GameSystem
{
    public class GlobalConfigure : Singleton<GlobalConfigure>
    {
        #region Player
        [SerializeField] private KeyCode forward;
        [SerializeField] private KeyCode backward;
        [SerializeField] private KeyCode left;
        [SerializeField] private KeyCode right;
        public static class PlayerConfigure
        {
            public static KeyCode Forward => GlobalConfigure.Instance.forward;
            public static KeyCode Backward => GlobalConfigure.Instance.backward;
            public static KeyCode Left => GlobalConfigure.Instance.left;
            public static KeyCode Right => GlobalConfigure.Instance.right;
        }
        #endregion
    }
}