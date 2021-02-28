using UnityEngine;

namespace _Scriptable_Objects
{
    [CreateAssetMenu(menuName = "Weapons/WeaponData")]
    public class SOWeaponData : ScriptableObject
    {
        
        [field: SerializeField]
        public SOProjectileData ProjectileData { get; set; }
        
        [field: SerializeField] [field: Range(0, 100)]
        public int AmmoCapacity { get; set; } = 10;

        [field: SerializeField] [field: Range(0.1f, 100)]
        public float WeaponDelay { get; set; } = 5f;

        [field: SerializeField] [field: Range(0, 10)]
        public float SpreadAngle { get; set; } = 5;

        [field: SerializeField] 
        private bool multiBulletShoot = false;

        [field: SerializeField]
        private bool isAutomatic = false;

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
