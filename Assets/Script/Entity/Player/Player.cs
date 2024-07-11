using System.Collections.Generic;
using Script.Module;
using Script.Module.PlayerModule;

namespace Script.Entity.Player
{
    internal class Player : BaseEntity
    {
        #region Module
        private List<IBaseModule<Player>> _moduleList;
        protected PlayerInputModule PlayerInputModule;
        protected HandleOrderModule HandleOrderModule;
        #endregion
        
        #region Order
        internal bool ForwardOrder;
        internal bool BackwardOrder;
        internal bool LeftOrder;
        internal bool RightOrder;
        #endregion

        private void RenewModule()
        {
            _moduleList = new List<IBaseModule<Player>>();
            PlayerInputModule = new PlayerInputModule();
            HandleOrderModule = new HandleOrderModule();
            TransformModule = new TransformModule();
            
            #region Order
            _moduleList.Add(PlayerInputModule);
            _moduleList.Add(HandleOrderModule);
            #endregion
            
            #region MainUpdate
            _moduleList.Add(TransformModule);
            _moduleList.Add(HealthModule);
            #endregion
        }
        private void Start()
        {
            RenewModule();
        }

        void Update()
        {
            foreach (IBaseModule<Player> nowModule in _moduleList)
            {
                nowModule.Update(this);
            }
        }
    }
}