using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Vector2 moveDirection;
    private C_Move move;

    public InputActionReference moveAction;

    private void Awake()
    {
        move = GetComponent<C_Move>();
    }

    private void Update()
    {
        moveDirection = moveAction.action.ReadValue<Vector2>();
        Vector3 direction = new Vector3(moveDirection.x, 0, 0);
        move.Movement(moveSpeed, direction);
    }
}
