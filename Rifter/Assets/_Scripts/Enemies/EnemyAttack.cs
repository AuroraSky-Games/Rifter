using System;
using System.Collections;
using UnityEngine;

namespace _Scripts.Enemies
{
    public abstract class EnemyAttack : MonoBehaviour
    {
        private EnemyController _enemyController;
        [field: SerializeField] public float AttackDelay { get; set; } = 1;
        protected bool WaitForNextAttack;

        private void Awake()
        {
            _enemyController = GetComponent<EnemyController>();
        }

        public abstract void Attack(int damage);

        public IEnumerator WaitForNextAttackCoroutine()
        {
            WaitForNextAttack = true;
            yield return new WaitForSeconds(AttackDelay);
            WaitForNextAttack = false;
        }

        protected GameObject GetTarget()
        {
            return _enemyController.Target;
        }
        
    }
}