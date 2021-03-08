using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts
{
    public abstract class Agent : MonoBehaviour, IHittable, IAgent
    {
        [field: SerializeField] public SOAgentStats AgentStats { get; set; }
        public int Health { get; set; }
        [field: SerializeField] public UnityEvent OnGetHit { get; set; }
        [field: SerializeField] public UnityEvent OnDie { get; set; }
        
        private void Start()
        {
            Health = AgentStats.MaxHealth;
        }
        
        public void GetHit(int damage, GameObject damageDealer)
        {
            Health--;
            OnGetHit?.Invoke();
            if (Health > 0) return;
            OnDie?.Invoke();
            StartCoroutine(WaitToDie());
        }

        protected abstract IEnumerator WaitToDie();

    }
}