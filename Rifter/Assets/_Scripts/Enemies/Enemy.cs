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
                //Debug.Log("Enemy Hit Test");
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


