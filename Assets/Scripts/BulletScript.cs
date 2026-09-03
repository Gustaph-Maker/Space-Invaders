using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;
    private Vector3 direction = Vector3.up;
    private float offScreen = 6f;

    private C_Move move;

    private void Awake()
    {
        move = GetComponent<C_Move>();
    }

    private void Update()
    {
        move.Movement(bulletSpeed,direction);

        if (transform.position.y > offScreen || transform.position.y < -offScreen)
            Destroy(gameObject);
    }
}
