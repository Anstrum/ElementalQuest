using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public PlayerControls playerControls;

    private InputAction Up;
    private InputAction Down;
    private InputAction Left;
    private InputAction Right;
    private InputAction Sprint;
    private InputAction Roll;
    private InputAction Atk;
    private InputAction Defend;
    private InputAction Ultimate;
    private InputAction Special;

    private float AtkTimer = 0;


    public bool up = false;
    public bool down = false;
    public float left = 0;
    public float right = 0;
    public bool sprint = false;
    public bool roll = false;
    public bool atk = false;
    public bool defend = false;
    public bool ultimate = false;
    public bool special = false;


    public void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        Up = playerControls.movement.Up;
        Down = playerControls.movement.Down;
        Left = playerControls.movement.Left;
        Right = playerControls.movement.Right;
        Sprint = playerControls.movement.Sprint;
        Roll = playerControls.movement.Roll;
        Atk = playerControls.movement.Atk;
        Defend = playerControls.movement.Defend;
        Ultimate = playerControls.movement.Ultimate;
        Special = playerControls.movement.Special;

        Up.Enable();
        Down.Enable();
        Left.Enable();
        Right.Enable();
        Sprint.Enable();
        Roll.Enable();
        Atk.Enable();
        Defend.Enable();
        Ultimate.Enable();
        Special.Enable();
    }
    private void OnDisable()
    {
        Up.Disable();
        Down.Disable();
        Left.Disable();
        Right.Disable();
        Sprint.Disable();
        Roll.Disable();
        Atk.Disable();
        Defend.Disable();
        Ultimate.Disable();
        Special.Disable();
    }
    void Update()
    {
        up = Up.ReadValue<float>() > 0;
        down = Down.ReadValue<float>() > 0;
        left = Left.ReadValue<float>();
        right = Right.ReadValue<float>();
        sprint = Sprint.ReadValue<float>() > 0;
        roll = Roll.ReadValue<float>() > 0;

        AtkTimer -= Time.deltaTime ;
        if(AtkTimer < 0)
        {
            AtkTimer = 0;
        }
        if (Atk.ReadValue<float>() > 0)
        {
            AtkTimer = 0.3f;
        }

        atk = AtkTimer > 0; // 0.2 secondes \\
        defend = Defend.ReadValue<float>() > 0;
        ultimate = Ultimate.ReadValue<float>() > 0;
        special = Special.ReadValue<float>() > 0;
    }
}
