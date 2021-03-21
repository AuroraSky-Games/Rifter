using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace _Scripts.Abstract_Classes
{
    public abstract class Agent : MonoBehaviour, IHittable, IAgent
    {
        [field: SerializeField] public virtual int Health { get; set; }
        [field: SerializeField] protected SOAgentStats AgentStats { get; set; }
        [field: SerializeField] public UnityEvent OnGetHit { get; set; }
        [field: SerializeField] public UnityEvent OnDie { get; set; }
        
        public bool dead;
        
        private void Awake()
        {
            Health = AgentStats.MaxHealth;
        }

        public abstract void GetHit(int damage, GameObject damageDealer);

        protected abstract IEnumerator WaitToDie();
    }
}