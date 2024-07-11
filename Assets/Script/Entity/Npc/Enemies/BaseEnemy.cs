using UnityEngine;

namespace Script.Entity.Npc.Enemies
{
    internal abstract class BaseEnemy<T>: BaseNpc<T> 
        where T : MonoBehaviour
    {
        
    }
}