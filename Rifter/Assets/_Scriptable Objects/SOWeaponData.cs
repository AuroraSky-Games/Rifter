using UnityEngine;

namespace _Scriptable_Objects
{
    [CreateAssetMenu(menuName = "Player/WeaponData")]
    public class SOWeaponData : ScriptableObject
    {
        [field: SerializeField] [field: Range(0, 100)]
        public int AmmoCapacity { get; set; } = 10;

        [field: SerializeField] [field: Range(0.1f, 5f)]
        public float WeaponDelay { get; set; } = 5f;

        [field: SerializeField] [field: Range(0, 10)]
        public float SpreadAngle { get; set; } = 5;

        [field: SerializeField] 
        private bool multiBulletShoot = false;

        [field: SerializeField] [field: Range(1, 4)]
        private int bulletCount = 1;

        internal int GetBulletCountToSpawn()
        {
            if (multiBulletShoot)
            {
                return bulletCount;
            }

            return 1;
        }
    
    }
}
