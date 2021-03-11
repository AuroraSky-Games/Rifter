using UnityEngine.Events;

namespace _Scripts
{
    public interface IAgent
    { 
        int Health { get; }
        UnityEvent OnGetHit { get; set; }
        UnityEvent OnDie { get; set; }

    }
}