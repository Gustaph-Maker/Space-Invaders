using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Vector2 moveDirection;
    private C_Move move;
    private C_Fire fire;

    public GameObject bullet;

    public InputActionReference moveAction;
    public InputActionReference fireAction;

    private void Awake()
    {
        move = GetComponent<C_Move>();
        fire = GetComponent<C_Fire>();
    }

    private void OnEnable()
    {
        fireAction.action.started += Shoot;
    }

    private void OnDisable()
    {
        fireAction.action.started -= Shoot;
    }

    private void Update()
    {
        moveDirection = moveAction.action.ReadValue<Vector2>();
        Vector3 direction = new Vector3(moveDirection.x, 0, 0);
        move.Movement(moveSpeed, direction);
    }

    private void Shoot(InputAction.CallbackContext obj)
    {
        fire.Fire(transform.position, transform.rotation, bullet);
    }
}
