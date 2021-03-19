using System;
using System.Collections;
using _Scripts.Abstract_Classes;
using UnityEngine;

namespace _Scripts.Enemies
{
    public class Enemy : Agent
    {
        
        public EnemyMeleeAttack EnemyAttack { get; set; }
        
        private void Awake()
        {

            // if (EnemyAttack == null)
            // {
            //     EnemyAttack.GetComponent<EnemyMeleeAttack>();
            // }
            
        }

        // public void PerformAttack()
        // {
        //     if (dead == false)
        //     {
        //         EnemyAttack.Attack(AgentStats.Damage);
        //     }
        // }
        
        public override void GetHit(int damage, GameObject damageDealer)
        {
            if (dead == false)
            {
                Health--;
                OnGetHit?.Invoke();
                //Debug.Log("Enemy Hit Test");
                if (Health <= 0)
                { 
                    dead = true;
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
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag.Equals("Player"))
            {
                var hittable = collision.GetComponent<IHittable>();
                hittable?.GetHit(AgentStats.Damage, gameObject);
            }
        }

    }
}


