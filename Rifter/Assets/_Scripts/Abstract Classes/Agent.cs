using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Abstract_Classes
{
    public abstract class Agent : MonoBehaviour, IHittable, IAgent
    {
        public int Health { get; private set; }
        [field: SerializeField] private SOAgentStats AgentStats { get; set; }
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