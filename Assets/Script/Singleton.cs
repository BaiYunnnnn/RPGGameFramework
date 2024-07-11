using UnityEngine;

namespace Script
{
    public class Singleton<T> : MonoBehaviour
    where T: MonoBehaviour
    {
        public bool global = false;
        private static T _instance;

        public static T Instance
        {
            get
            {
                _instance ??= FindObjectOfType<T>();

                return _instance;
            }
        }

        private void Awake()
        {
            if (global)
            {
                DontDestroyOnLoad(this);
            }

            OnStart();
        }

        protected virtual void OnStart()
        {
            
        }
    }
}