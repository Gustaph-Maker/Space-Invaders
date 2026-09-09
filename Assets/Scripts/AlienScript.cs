using System.Runtime.CompilerServices;
using UnityEngine;

public class AlienScript : MonoBehaviour
{
    private C_Fire fire;
    private C_Move move;
    [SerializeField] private float moveDistance = 1.0f;

    private void Start()
    {
        fire = GetComponent<C_Fire>();
        move = GetComponent<C_Move>();
    }

    public void Shoot()
    {
        fire.Fire();
    }

    public void Move(Vector3 direction)
    {
        move.Movement(moveDistance,direction);
    }
}
