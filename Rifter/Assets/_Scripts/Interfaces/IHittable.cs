using UnityEngine;
using UnityEngine.Events;

namespace _Scripts
{
    public interface IHittable
    {
        UnityEvent OnGetHit { get; set; }
    
        void GetHit(int damage, GameObject damageDealer);
    }
}
