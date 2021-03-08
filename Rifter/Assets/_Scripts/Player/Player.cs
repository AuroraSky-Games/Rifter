using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Player
{
    public class Player : Agent
    {
        
        [field: SerializeField] private SOAgentStats PlayerStats { get; set; }
    
        private void Start()
        {
            Health = PlayerStats.MaxHealth;
        }

        protected override IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }
    }
}