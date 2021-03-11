using System.Collections;
using _Scripts.Abstract_Classes;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Player
{
    public class Player : Agent
    {
        protected override IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }
    }
}