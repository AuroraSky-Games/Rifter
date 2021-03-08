using System.Collections;
using UnityEngine;

namespace _Scripts.Enemies
{
    public class Enemy : Agent
    {
        protected override IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }
    }
}


