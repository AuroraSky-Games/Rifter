using System;
using UnityEngine;

namespace _Scripts.Weapons
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class WeaponRenderer : MonoBehaviour
    {
        [SerializeField] 
        protected int playerSortingOrder = 0;
        private SpriteRenderer weaponRenderer;

        private void Start()
        {
            weaponRenderer = GetComponent<SpriteRenderer>();
            Debug.Log(weaponRenderer.bounds);
        }

        public void FlipSprite(bool val)
        {
            weaponRenderer.flipY = val;
        }

        public void RenderBehindHead(bool val)
        {
            if (val)
            {
                weaponRenderer.sortingOrder = playerSortingOrder - 1;
            }
            else
            {
                weaponRenderer.sortingOrder = playerSortingOrder + 1;
            }

        }
        
    }
}