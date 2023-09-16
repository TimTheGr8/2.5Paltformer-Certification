//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Inputs/PlayerInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""28dd6be6-5cd1-443d-a859-f92b5e25bfc8"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a3801333-22b9-4165-871f-14d72c753c4f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c7e1ce8c-325d-45eb-a1d8-5c9565f7f0cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClimbLedge"",
                    ""type"": ""Button"",
                    ""id"": ""31d4bf5c-ec1b-4640-be89-ea501dbbad53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""6249c4c8-ad79-4f37-84aa-901a31099dc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""b3ffc3c4-6ef3-405e-bf87-15c55697a035"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClimbLadder"",
                    ""type"": ""Value"",
                    ""id"": ""a81aed69-24f3-4829-ac65-b16492f333d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""A/D"",
                    ""id"": ""b711991c-fa42-48f8-9592-62bd0869ba05"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cc653c30-cf92-4fda-8aac-2c58b083f37e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d89bee44-e946-48d2-87fa-a218e96e07a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b76c38e8-d85c-4dad-8ade-047746b5fbe2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7160cb8-7e7e-4058-8203-b9473c5a486a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClimbLedge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07be8871-3ece-44eb-adcc-9e9e129c8ab9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""611e885b-3de4-47c8-b5a3-9d1d84a8925f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""W/S"",
                    ""id"": ""41bc0725-85b8-4e6e-90b5-12adedaf2422"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClimbLadder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7d8f4abb-b8b0-4f68-93d5-1e4123df039a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClimbLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a5a77843-7724-4774-9ce1-8f51544dcddf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClimbLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Ladder"",
            ""id"": ""6ea7dfe2-7e54-4372-a425-5f9865b68f8a"",
            ""actions"": [
                {
                    ""name"": ""Climb"",
                    ""type"": ""Value"",
                    ""id"": ""9c9b3f58-48ed-40e4-b4ec-04e3a854fac5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""05930dcc-3dfe-4267-b05c-5c8b6ce7e2f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""W/S"",
                    ""id"": ""5a791e41-cc24-4e01-93f7-004e585146a8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""693a5b65-04f3-44bf-b0c9-097a025998be"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6415ceec-e268-48cc-bde3-615f652b9b04"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51ab9c02-0da5-47c9-9ffb-6c5812783338"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_ClimbLedge = m_Player.FindAction("ClimbLedge", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_ClimbLadder = m_Player.FindAction("ClimbLadder", throwIfNotFound: true);
        // Ladder
        m_Ladder = asset.FindActionMap("Ladder", throwIfNotFound: true);
        m_Ladder_Climb = m_Ladder.FindAction("Climb", throwIfNotFound: true);
        m_Ladder_Interact = m_Ladder.FindAction("Interact", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_ClimbLedge;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_ClimbLadder;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @ClimbLedge => m_Wrapper.m_Player_ClimbLedge;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @ClimbLadder => m_Wrapper.m_Player_ClimbLadder;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @ClimbLedge.started += instance.OnClimbLedge;
            @ClimbLedge.performed += instance.OnClimbLedge;
            @ClimbLedge.canceled += instance.OnClimbLedge;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Roll.started += instance.OnRoll;
            @Roll.performed += instance.OnRoll;
            @Roll.canceled += instance.OnRoll;
            @ClimbLadder.started += instance.OnClimbLadder;
            @ClimbLadder.performed += instance.OnClimbLadder;
            @ClimbLadder.canceled += instance.OnClimbLadder;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @ClimbLedge.started -= instance.OnClimbLedge;
            @ClimbLedge.performed -= instance.OnClimbLedge;
            @ClimbLedge.canceled -= instance.OnClimbLedge;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Roll.started -= instance.OnRoll;
            @Roll.performed -= instance.OnRoll;
            @Roll.canceled -= instance.OnRoll;
            @ClimbLadder.started -= instance.OnClimbLadder;
            @ClimbLadder.performed -= instance.OnClimbLadder;
            @ClimbLadder.canceled -= instance.OnClimbLadder;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Ladder
    private readonly InputActionMap m_Ladder;
    private List<ILadderActions> m_LadderActionsCallbackInterfaces = new List<ILadderActions>();
    private readonly InputAction m_Ladder_Climb;
    private readonly InputAction m_Ladder_Interact;
    public struct LadderActions
    {
        private @PlayerInputs m_Wrapper;
        public LadderActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Climb => m_Wrapper.m_Ladder_Climb;
        public InputAction @Interact => m_Wrapper.m_Ladder_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Ladder; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LadderActions set) { return set.Get(); }
        public void AddCallbacks(ILadderActions instance)
        {
            if (instance == null || m_Wrapper.m_LadderActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LadderActionsCallbackInterfaces.Add(instance);
            @Climb.started += instance.OnClimb;
            @Climb.performed += instance.OnClimb;
            @Climb.canceled += instance.OnClimb;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(ILadderActions instance)
        {
            @Climb.started -= instance.OnClimb;
            @Climb.performed -= instance.OnClimb;
            @Climb.canceled -= instance.OnClimb;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(ILadderActions instance)
        {
            if (m_Wrapper.m_LadderActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILadderActions instance)
        {
            foreach (var item in m_Wrapper.m_LadderActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LadderActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LadderActions @Ladder => new LadderActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnClimbLedge(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnClimbLadder(InputAction.CallbackContext context);
    }
    public interface ILadderActions
    {
        void OnClimb(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
