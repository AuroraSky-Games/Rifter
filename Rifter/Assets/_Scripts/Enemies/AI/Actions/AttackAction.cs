using UnityEngine;

namespace _Scripts.Enemies.AI.Actions
{
    public class AttackAction : AIAction
    {
        public override void TakeAction()
        {
            if (EnemyController.Target != null)
            {
                AIMovementData.Direction = Vector2.zero;
                AIMovementData.PointOfInterest = EnemyController.Target.transform.position;
                EnemyController.MovementData(AIMovementData.Direction, AIMovementData.PointOfInterest);
                AIActionData.Attack = true;
                EnemyController.Attack();
                AIActionData.Arrived = true; 
            }
        }
    }
}