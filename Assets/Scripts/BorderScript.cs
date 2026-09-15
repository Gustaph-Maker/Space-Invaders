using UnityEngine;

public class BorderScript : MonoBehaviour
{
    [SerializeField] private AlienArmyScript AlienArmy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AlienArmy.BorderCollision();
    }
}
