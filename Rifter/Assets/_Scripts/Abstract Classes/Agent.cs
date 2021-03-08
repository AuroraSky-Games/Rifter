using System.Collections;
using _Scripts.Interfaces;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Abstract_Classes
{
    public abstract class Agent : MonoBehaviour, IHittable, IAgent
    {
        
        [field: SerializeField] public int Health { get; set; } = 2;
        [field: SerializeField] public UnityEvent OnGetHit { get; set; }
        [field: SerializeField] public UnityEvent OnDie { get; set; }
        
        public void GetHit(int damage, GameObject damageDealer)
        {

            Health--;
            OnGetHit?.Invoke();

            if (Health <= 0)
            {
                OnDie?.Invoke();
                StartCoroutine(WaitToDie());

            }
        }
        
        IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }
        
    }
}