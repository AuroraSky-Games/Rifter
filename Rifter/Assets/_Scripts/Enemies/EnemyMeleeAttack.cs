using UnityEngine;

namespace _Scripts.Enemies
{
    public class EnemyMeleeAttack : EnemyAttack
    {
        public override void Attack(int damage)
        {
            if (WaitForNextAttack == false)
            {
                var hittable = GetTarget().GetComponent<IHittable>();
                Debug.Log(gameObject);
                hittable?.GetHit(damage, gameObject);
                StartCoroutine(WaitForNextAttackCoroutine());
            }
        }
    }
}