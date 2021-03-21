using System;
using UnityEngine;

namespace _Scripts.Enemies.AI.Decisions
{
    public class DistanceDecision : AIDecision
    {
        [field: SerializeField] [field: Range(0.1f, 100)] public float Distance { get; set; } = 5;
        
        public override bool MakeADecision()
        {
            if (EnemyController.Target != null)
            {
                if (Vector3.Distance(EnemyController.Target.transform.position, transform.position) < Distance)
                {
                    if (AIActionData.TargetSpotted == false)
                    {

                        AIActionData.TargetSpotted = true;
                    }
                }
                else
                {
                    AIActionData.TargetSpotted = false;
                }
            }
            
            return AIActionData.TargetSpotted;
            
        }

        // protected void OnDrawGizmos()
        // {
        //     if (UnityEditor.Selection.activeObject == gameObject)
        //     {
        //         Gizmos.color = Color.green;
        //         Gizmos.DrawWireSphere(transform.position, Distance);
        //         Gizmos.color = Color.white;
        //     }
        // }
    }
}