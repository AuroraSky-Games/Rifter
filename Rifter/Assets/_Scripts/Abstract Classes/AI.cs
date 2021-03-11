using _Scripts.Enemies;
using _Scripts.Enemies.AI;
using UnityEngine;

namespace _Scripts.Abstract_Classes
{
    public abstract class AI : MonoBehaviour
    {
        protected AIActionData AIActionData;
        protected AIMovementData AIMovementData;
        protected EnemyController EnemyController;

        protected void Awake()
        {
            AIActionData = transform.root.GetComponentInChildren<AIActionData>();
            AIMovementData = transform.root.GetComponentInChildren<AIMovementData>();
            EnemyController = transform.root.GetComponentInChildren<EnemyController>();
        }
    }
}