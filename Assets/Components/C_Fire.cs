using UnityEngine;

public class C_Fire : MonoBehaviour
{
    public void Fire(GameObject bulletPrefab)
    {
        GameObject bulletObject = Instantiate(
            bulletPrefab,
            transform.position,
            transform.rotation
            );

        BulletScript bullet = bulletObject.GetComponent<BulletScript>();

        bullet.Initialize(gameObject);
    }
}
