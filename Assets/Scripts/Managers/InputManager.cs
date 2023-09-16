using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("There is no InputManager.");

            return _instance;
        }
    }

    [SerializeField]
    private Player _player;

    private PlayerInputs _inputs;
    private GameObject _switch;
    private GameObject _ladder;

    private void Awake()
    {
        _instance = this;

        if (_player == null)
            Debug.LogError("There is no player for the Input Manager.");

        _inputs = new PlayerInputs();
        InitializeInputs();
    }

    public void AssignSwitch(GameObject controller)
    {
        _switch = controller;
    }

    public void AsssignLadder(GameObject ladder)
    {
        _ladder = ladder;
    }

    private void InitializeInputs()
    {
        _inputs.Player.Enable();
        _inputs.Player.Move.performed += Move_performed;
        _inputs.Player.Move.canceled += Move_canceled;
        _inputs.Player.Jump.performed += Jump_performed;
        _inputs.Player.ClimbLedge.performed += ClimbLedge_performed;
        _inputs.Player.Interact.performed += Interact_performed;
        _inputs.Player.Roll.performed += Roll_performed;

        _inputs.Ladder.Climb.performed += Climb_performed;
        _inputs.Ladder.Climb.canceled += Climb_canceled;
        _inputs.Ladder.Interact.performed += LadderInteract_performed;
    }

    private void LadderInteract_performed(InputAction.CallbackContext context)
    {
        _player.LadderInteraction();
    }

    private void Climb_canceled(InputAction.CallbackContext context)
    {
        _player.SetClimb(0);
    }

    private void Climb_performed(InputAction.CallbackContext context)
    {
        _player.SetClimb(context.ReadValue<float>());
    }

    private void Roll_performed(InputAction.CallbackContext context)
    {
        _player.Roll();
    }
    
    private void Interact_performed(InputAction.CallbackContext context)
    {
        if (_switch != null)
        {
            SwitchController controller = _switch.GetComponent<SwitchController>();
            if(controller != null)
                controller.ActivateLift();
        }

        if(_ladder != null)
        {
            _player.LadderInteraction();
        }
    }

    private void ClimbLedge_performed(InputAction.CallbackContext context)
    {
        _player.ClimbLedge();
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        _player.Jump();
    }

    private void Move_canceled(InputAction.CallbackContext context)
    {
        _player.SetWalk(0);
    }

    private void Move_performed(InputAction.CallbackContext context)
    {
        _player.SetWalk(context.ReadValue<float>());
    }

    public void EnablePlayerMap()
    {
        _inputs.Ladder.Disable();
        _inputs.Player.Enable();
    }

    public void EnableLadderMap()
    {
        _inputs.Player.Disable();
        _inputs.Ladder.Enable();
    }
}
