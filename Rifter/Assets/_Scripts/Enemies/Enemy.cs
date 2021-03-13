using System;
using System.Collections;
using _Scripts.Abstract_Classes;
using UnityEngine;

namespace _Scripts.Enemies
{
    public class Enemy : Agent
    {
        
        // public EnemyMeleeAttack EnemyAttack { get; set; }
        
        private void Awake()
        {
            // EnemyAttack.GetComponent<EnemyMeleeAttack>();
        }

        // public void PerformAttack()
        // {
        //     if ( _dead == false)
        //     {
        //         EnemyAttack.Attack(AgentStats.Damage);
        //     }
        // }
        
        public override void GetHit(int damage, GameObject damageDealer)
        {
            if (_dead == false)
            {
                Health--;
                //OnGetHit?.Invoke();
                if (Health <= 0)
                { 
                    _dead = true;
                    OnDie?.Invoke();
                    StartCoroutine(WaitToDie());
                }
            }
        }
        
        protected override IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }

        

    }
}


