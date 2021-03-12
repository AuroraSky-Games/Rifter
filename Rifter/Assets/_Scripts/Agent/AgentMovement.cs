using _Scripts.Managers;
using UnityEngine;

namespace _Scripts.Enemies
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class AgentMovement : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        [field: SerializeField] private SOAgentStats AgentStats { get; set; }

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void MoveAgent(Vector2 movementInput)
        {
            _rigidbody2D.velocity = movementInput.normalized * AgentStats.startVelocity;
        }
    
    }
}
