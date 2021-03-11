using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Enemies.AI
{
    public class AIState : MonoBehaviour
    {
        private EnemyController _enemyController = null;
        [field: SerializeField] private List<AIAction> actions = null;
        [field: SerializeField] private List<AITransition> transitions = null;

        private void Awake()
        {
            _enemyController = transform.root.GetComponentInChildren<EnemyController>();
        }

        public void UpdateState()
        {
            foreach (var action in actions)
            {
                  action.TakeAction();  
            }

            foreach (var transition in transitions)
            {
                //Player in range -> True -> Back to Idle
                //Player visible -> True -> Chase

                bool result = false;
                foreach (var decision in transition.Decisions)
                {
                    result = decision.MakeADecision();
                    if (result == false)
                        break;;
                }

                if (result)
                {
                    if (transition.PositiveResult!=null)
                    {
                        _enemyController.ChangeToState(transition.PositiveResult);
                        return;
                    }
                }
                else
                {
                    if (transition.NegativeResult != null)
                    {
                        _enemyController.ChangeToState(transition.NegativeResult);
                        return;
                    }
                }
            }
        }
        
    }
}
