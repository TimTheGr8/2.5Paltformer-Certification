using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    private PlayerInputs _inputs;

    private void Awake()
    {
        if (_player == null)
            Debug.LogError("There is no player for the Input Manager.");

        _inputs = new PlayerInputs();
        InitializeInputs();
    }

    private void InitializeInputs()
    {
        _inputs.Player.Enable();
        _inputs.Player.Move.performed += Move_performed;
        _inputs.Player.Move.canceled += Move_canceled;
        _inputs.Player.Jump.performed += Jump_performed;
        _inputs.Player.ClimbLedge.performed += ClimbLedge_performed;
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
}
