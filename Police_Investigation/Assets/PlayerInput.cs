// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""6a5bf4a1-a156-49f6-acbe-4a9219ecb79c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""d6f4d23d-21d1-4deb-8a63-2f5a2ed55365"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""511925ff-d706-4ded-8f06-86e3b16e6340"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d34c6379-9a81-46d0-a844-8dd9ed510875"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""886a0e91-2f56-4537-89b4-246d8200d6e3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8250e61-5f39-4063-82ef-04c39adb6ae7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""96b66bd4-b60a-4715-8e57-a7b043c2d29a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""b33e5d78-23fd-4c24-b9a7-86b7ee1c2c0e"",
            ""actions"": [
                {
                    ""name"": ""StartDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""c147dc63-c90b-4f0f-b060-b39975a2e49f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""NextDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""178c084d-5df4-4a8d-9a88-8edfebfc4af7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ExitDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""a34a6bad-fd6c-40e4-a7a3-5d73a5fdda29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""96b991a7-5863-400d-bcd6-faff6cbe81e1"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eedfd3b9-b96e-4b2e-94d2-7d2ef2eb1dee"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ec6885d-80f3-4671-beaf-36d9087fdca3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MouseLook"",
            ""id"": ""b57b9702-9a99-4853-9f2c-25e012a2a19d"",
            ""actions"": [
                {
                    ""name"": ""LookVector"",
                    ""type"": ""Value"",
                    ""id"": ""9f86dc6a-1b27-4fc0-99ce-8dcc04d724c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09d4f5bc-ae59-496d-8788-2246c655a5a0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_StartDialogue = m_Interaction.FindAction("StartDialogue", throwIfNotFound: true);
        m_Interaction_NextDialogue = m_Interaction.FindAction("NextDialogue", throwIfNotFound: true);
        m_Interaction_ExitDialogue = m_Interaction.FindAction("ExitDialogue", throwIfNotFound: true);
        // MouseLook
        m_MouseLook = asset.FindActionMap("MouseLook", throwIfNotFound: true);
        m_MouseLook_LookVector = m_MouseLook.FindAction("LookVector", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private IInteractionActions m_InteractionActionsCallbackInterface;
    private readonly InputAction m_Interaction_StartDialogue;
    private readonly InputAction m_Interaction_NextDialogue;
    private readonly InputAction m_Interaction_ExitDialogue;
    public struct InteractionActions
    {
        private @PlayerInput m_Wrapper;
        public InteractionActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartDialogue => m_Wrapper.m_Interaction_StartDialogue;
        public InputAction @NextDialogue => m_Wrapper.m_Interaction_NextDialogue;
        public InputAction @ExitDialogue => m_Wrapper.m_Interaction_ExitDialogue;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterface != null)
            {
                @StartDialogue.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnStartDialogue;
                @StartDialogue.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnStartDialogue;
                @StartDialogue.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnStartDialogue;
                @NextDialogue.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnNextDialogue;
                @NextDialogue.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnNextDialogue;
                @NextDialogue.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnNextDialogue;
                @ExitDialogue.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnExitDialogue;
                @ExitDialogue.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnExitDialogue;
                @ExitDialogue.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnExitDialogue;
            }
            m_Wrapper.m_InteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartDialogue.started += instance.OnStartDialogue;
                @StartDialogue.performed += instance.OnStartDialogue;
                @StartDialogue.canceled += instance.OnStartDialogue;
                @NextDialogue.started += instance.OnNextDialogue;
                @NextDialogue.performed += instance.OnNextDialogue;
                @NextDialogue.canceled += instance.OnNextDialogue;
                @ExitDialogue.started += instance.OnExitDialogue;
                @ExitDialogue.performed += instance.OnExitDialogue;
                @ExitDialogue.canceled += instance.OnExitDialogue;
            }
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);

    // MouseLook
    private readonly InputActionMap m_MouseLook;
    private IMouseLookActions m_MouseLookActionsCallbackInterface;
    private readonly InputAction m_MouseLook_LookVector;
    public struct MouseLookActions
    {
        private @PlayerInput m_Wrapper;
        public MouseLookActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LookVector => m_Wrapper.m_MouseLook_LookVector;
        public InputActionMap Get() { return m_Wrapper.m_MouseLook; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseLookActions set) { return set.Get(); }
        public void SetCallbacks(IMouseLookActions instance)
        {
            if (m_Wrapper.m_MouseLookActionsCallbackInterface != null)
            {
                @LookVector.started -= m_Wrapper.m_MouseLookActionsCallbackInterface.OnLookVector;
                @LookVector.performed -= m_Wrapper.m_MouseLookActionsCallbackInterface.OnLookVector;
                @LookVector.canceled -= m_Wrapper.m_MouseLookActionsCallbackInterface.OnLookVector;
            }
            m_Wrapper.m_MouseLookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LookVector.started += instance.OnLookVector;
                @LookVector.performed += instance.OnLookVector;
                @LookVector.canceled += instance.OnLookVector;
            }
        }
    }
    public MouseLookActions @MouseLook => new MouseLookActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnStartDialogue(InputAction.CallbackContext context);
        void OnNextDialogue(InputAction.CallbackContext context);
        void OnExitDialogue(InputAction.CallbackContext context);
    }
    public interface IMouseLookActions
    {
        void OnLookVector(InputAction.CallbackContext context);
    }
}
