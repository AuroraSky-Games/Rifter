﻿using UnityEngine;

namespace _Scripts.Enemies.AI.Actions
{
    public class AttackAction : AIAction
    {
        public override void TakeAction()
        {
            AIMovementData.Direction = Vector2.zero;
            AIMovementData.PointOfInterest = EnemyController.Target.transform.position;
            EnemyController.Move(AIMovementData.Direction, AIMovementData.PointOfInterest);
            AIActionData.Attack = true;
            EnemyController.Attack();
        }
    }
}