using UnityEngine;

public class C_TeamMember : MonoBehaviour
{
    [SerializeField] private Team team;

    public Team Team => team;
}
