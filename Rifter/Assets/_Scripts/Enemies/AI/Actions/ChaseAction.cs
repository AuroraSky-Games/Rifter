﻿using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.Enemies.AI.Actions
{
    public class ChaseAction : AIAction
    {
        public override void TakeAction()
        {
            if (EnemyController.Target != null)
            {
                AIActionData.Attack = false;
                AIActionData.Arrived = false;
                var position = EnemyController.Target.transform.position;
                var direction = position - transform.position;
                AIMovementData.Direction = direction.normalized;
                AIMovementData.PointOfInterest = position;
                EnemyController.MovementData(AIMovementData.Direction, AIMovementData.PointOfInterest);
            }
        }
    }
}