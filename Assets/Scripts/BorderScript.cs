using UnityEngine;

public class BorderScript : MonoBehaviour
{
    [SerializeField] private AlienArmyScript AlienArmy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        C_TeamMember teamMember = collision.GetComponent<C_TeamMember>();

        if(teamMember != null && teamMember.Team == Team.Alien)
        {
            AlienArmy.BorderCollision();
        }
    }
}
