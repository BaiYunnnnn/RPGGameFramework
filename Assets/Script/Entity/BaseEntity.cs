using Script.Module;
using UnityEngine;

namespace Script.Entity
{
    internal abstract class BaseEntity: MonoBehaviour
    {
        #region BaseAttibute
        [SerializeField] internal float maxSpeed;
        internal Vector2 SpeedVec;
        internal int Health;
        internal bool Died;
        #endregion
        
        #region Module
        protected HealthModule HealthModule;
        protected TransformModule TransformModule;
        #endregion
    }
}