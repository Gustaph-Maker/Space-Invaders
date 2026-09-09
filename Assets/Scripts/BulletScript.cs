using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;
    private Vector3 bulletDirection;
    private float offScreen = 6f;
    private GameObject owner;
    private Team ownerTeam;
    private C_Move move;

    public void Initialize(GameObject owner, Vector3 bulletDirection)
    {
        this.owner = owner;
        this.bulletDirection = bulletDirection;
        C_TeamMember teamMember = owner.GetComponent<C_TeamMember>();

        if(teamMember != null)
        {
            ownerTeam = teamMember.Team;
        }
    }

    private void Awake()
    {
        move = GetComponent<C_Move>();
    }

    private void Update()
    {
        move.Movement(bulletSpeed,bulletDirection);

        if (transform.position.y > offScreen || transform.position.y < -offScreen)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == owner)
        {
           return;
        }

        C_TeamMember teamMember = other.GetComponentInParent<C_TeamMember>();

        if(teamMember != null && teamMember.Team == ownerTeam)
        {
            return;
        }

        Debug.Log("Bullet hit: " + other.gameObject.name);
    }
}
