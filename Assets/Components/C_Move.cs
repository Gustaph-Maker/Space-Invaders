using UnityEngine;

public class C_Move : MonoBehaviour
{
    public void Movement(float speed, Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
