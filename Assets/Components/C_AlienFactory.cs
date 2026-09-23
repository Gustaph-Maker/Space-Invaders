using UnityEngine;

public class C_AlienFactory : MonoBehaviour
{
    [SerializeField] private GameObject alienPrefab;

    public AlienScript CreateAlien(Vector3 position)
    {
        GameObject alien = Instantiate(
            alienPrefab,
            position,
            Quaternion.identity
        );

        AlienScript alienScript = alien.GetComponent<AlienScript>();

        if(alienScript == null)
        {
            Debug.Log("Alien Prefab is missing AlienScipt component!");

            Destroy(alien);
            return null;
        }

        return alienScript;
    }
}
