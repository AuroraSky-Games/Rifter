using System.Collections;
using _Scripts.Abstract_Classes;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Player
{
    public class Player : Agent
    {

        public override void GetHit(int damage, GameObject damageDealer)
        {
            if (dead == false)
            {
                Health--;
                Debug.Log("Player Hit");
                OnGetHit?.Invoke();
                if (Health <= 0)
                {
                    dead = true;
                    OnDie?.Invoke();
                    StartCoroutine(WaitToDie());
                }
            }
        }

        protected override IEnumerator WaitToDie()
        {
            yield return new WaitForSeconds(.53f);
            Destroy(gameObject);
        }
    }
}