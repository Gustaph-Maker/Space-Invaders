using UnityEngine;

public class C_Fire : MonoBehaviour
{
    [SerializeField] private Vector3 bulletDirection;
    [SerializeField] private GameObject bulletPrefab;

    public void Fire()
    {
        GameObject bulletObject = Instantiate(
            bulletPrefab,
            transform.position,
            transform.rotation
            );

        BulletScript bullet = bulletObject.GetComponent<BulletScript>();

        bullet.Initialize(gameObject, bulletDirection);
    }
}
