using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.Enemies.AI.Actions
{
    public class ChaseAction : AIAction
    {
        public override void TakeAction()
        {
            var position = EnemyController.Target.transform.position;
            var direction = position - transform.position;
            AIMovementData.Direction = direction.normalized;
            AIMovementData.PointOfInterest = position;
            EnemyController.Move(AIMovementData.Direction, AIMovementData.PointOfInterest);
        }
    }
}