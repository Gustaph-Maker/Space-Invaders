using UnityEngine;

public class C_AlienFactory : MonoBehaviour
{
    [SerializeField] private GameObject alienPrefab;

    public GameObject CreateAlien(Vector3 position)
    {
        GameObject alien = Instantiate(
            alienPrefab,
            position,
            Quaternion.identity
        );

        return alien;
    }
}
