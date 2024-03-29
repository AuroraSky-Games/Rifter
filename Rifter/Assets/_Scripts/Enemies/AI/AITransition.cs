using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Enemies.AI
{
    public class AITransition : MonoBehaviour
    {
        [field: SerializeField] public List<AIDecision> Decisions { get; set; }
        [field: SerializeField] public AIState PositiveResult { get; set; }
        [field: SerializeField] public AIState NegativeResult { get; set; }

        private void Awake()
        {
            Decisions.Clear();
            Decisions = new List<AIDecision>(GetComponents<AIDecision>());
        }
    }
}
