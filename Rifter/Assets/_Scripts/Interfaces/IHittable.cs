using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Interfaces
{
    public interface IHittable
    {
        UnityEvent OnGetHit { get; set; }
    
        void GetHit(int damage, GameObject damageDealer);
    }
}
