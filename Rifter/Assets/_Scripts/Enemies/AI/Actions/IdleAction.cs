using System.Collections;
using System.Collections.Generic;
using _Scripts.Enemies.AI;
using UnityEngine;

public class IdleAction : AIAction
{
    public override void TakeAction()
    {
        AIMovementData.Direction = Vector2.zero;
        AIMovementData.PointOfInterest = transform.position;
        EnemyController.Move(AIMovementData.Direction, AIMovementData.PointOfInterest);
    }
}
