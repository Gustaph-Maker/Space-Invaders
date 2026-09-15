using System.Runtime.CompilerServices;
using UnityEngine;

public class AlienScript : MonoBehaviour
{
    private C_Fire fire;
    private C_Move move;
    [SerializeField] private float moveDistance = 1.0f;
    [SerializeField] private float shootChance = 50f;
    private float rollToShoot;

    private void Start()
    {
        fire = GetComponent<C_Fire>();
        move = GetComponent<C_Move>();
    }

    public void Shoot()
    {
        rollToShoot = Random.Range(0f, 100f);
        if (rollToShoot < shootChance)
        {
            fire.Fire();
        } 
    }

    public void Move(Vector3 direction)
    {
        move.Movement(moveDistance,direction);
    }
}
