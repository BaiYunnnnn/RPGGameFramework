using System;
using System.Collections.Generic;
using Script.Module;
using Script.Module.PlayerModule;
using UnityEngine;

namespace Script.Entity.Npc
{
    internal abstract class BaseNpc<T>: BaseEntity
        where T: MonoBehaviour
    {
        #region ModuleList
        protected List<IBaseModule<T>> ModuleList;
        #endregion

        protected abstract void RenewModule();
        protected abstract void Update();
        protected abstract void Start();
    }
}