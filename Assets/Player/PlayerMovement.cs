using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float animationSpeed;
    public Animator animator;

    public PlayerInputs playerInputs;


    public void Update()
    {

    }

    void FixedUpdate()
    {
        animator.SetBool("Atk", playerInputs.atk);
        animator.SetBool("Movement", playerInputs.left > 0 || playerInputs.right > 0);
        animator.SetBool("Sprint", playerInputs.sprint);
        animator.SetBool("JumpUp", playerInputs.up);
        animator.SetBool("JumpDown", playerInputs.down);
        animator.SetBool("Ultimate", playerInputs.ultimate);
        animator.SetBool("Special", playerInputs.ultimate);
        animator.SetBool("Defend", playerInputs.defend);
        animator.SetBool("Roll", playerInputs.roll);
    }
}
