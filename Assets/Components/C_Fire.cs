using UnityEngine;

public class C_Fire : MonoBehaviour
{
    public void Fire(Vector3 spawnPosition,Quaternion spawnRotation, GameObject bullet)
    {
        Instantiate(bullet, spawnPosition, spawnRotation);
    }
}
