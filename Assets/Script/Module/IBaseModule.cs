using UnityEngine;

namespace Script.Module
{
    internal interface IBaseModule<in T> 
        where T: MonoBehaviour
    {
        public void Update(T obj);
    }
}