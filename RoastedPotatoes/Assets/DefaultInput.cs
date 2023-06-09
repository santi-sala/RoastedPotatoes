//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/DefaultInput.inputactions
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

public partial class @DefaultInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInput"",
    ""maps"": [
        {
            ""name"": ""ControlScheme"",
            ""id"": ""24d0ef5c-8fee-448c-8b1a-9c65e41aee87"",
            ""actions"": [
                {
                    ""name"": ""Movement_Up"",
                    ""type"": ""Button"",
                    ""id"": ""08515466-162e-46d8-a254-a52273a0f4da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement_Down"",
                    ""type"": ""Button"",
                    ""id"": ""ae3c7ade-aa39-4bf9-a4ea-5318db98003e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement_Left"",
                    ""type"": ""Button"",
                    ""id"": ""22f973cf-0711-482e-a396-4b932986a671"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement_Right"",
                    ""type"": ""Button"",
                    ""id"": ""4ea148ff-ac84-45e2-9d45-18c9449d66f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""5021bd2f-ff19-4081-a781-8e8d7a040ea9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Alternate"",
                    ""type"": ""Button"",
                    ""id"": ""f7250ad4-6eef-487e-9703-a4d279619296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quit_The_Application"",
                    ""type"": ""Button"",
                    ""id"": ""547cd3ea-6251-49e3-9174-ad0b7088d27d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11a0838b-b494-4584-9d2a-d5e70a3c3c40"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36fdebbb-8c83-410a-af78-9fe479e3c0f6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f0d3a87-6810-47f6-a908-cbcc7c60d457"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13c95c4b-0945-4339-ad8d-f0dcd48b3829"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c00c3dea-afda-4713-81af-a233d4f2451e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98652659-a8a7-4813-8ab0-d6640e402494"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b16ee73a-143b-46d0-84f0-6431fb73a286"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5d961bf-df31-4cf4-b605-4b9a76bb95e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd5ee768-cc1d-428c-a388-6559c35aa0f3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef51f555-4e87-4e43-aed6-b7a88c5c7c3a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alternate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21ca8708-ea1b-464b-b08d-20b73c22bf2b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit_The_Application"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControlScheme
        m_ControlScheme = asset.FindActionMap("ControlScheme", throwIfNotFound: true);
        m_ControlScheme_Movement_Up = m_ControlScheme.FindAction("Movement_Up", throwIfNotFound: true);
        m_ControlScheme_Movement_Down = m_ControlScheme.FindAction("Movement_Down", throwIfNotFound: true);
        m_ControlScheme_Movement_Left = m_ControlScheme.FindAction("Movement_Left", throwIfNotFound: true);
        m_ControlScheme_Movement_Right = m_ControlScheme.FindAction("Movement_Right", throwIfNotFound: true);
        m_ControlScheme_Interaction = m_ControlScheme.FindAction("Interaction", throwIfNotFound: true);
        m_ControlScheme_Alternate = m_ControlScheme.FindAction("Alternate", throwIfNotFound: true);
        m_ControlScheme_Quit_The_Application = m_ControlScheme.FindAction("Quit_The_Application", throwIfNotFound: true);
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

    // ControlScheme
    private readonly InputActionMap m_ControlScheme;
    private IControlSchemeActions m_ControlSchemeActionsCallbackInterface;
    private readonly InputAction m_ControlScheme_Movement_Up;
    private readonly InputAction m_ControlScheme_Movement_Down;
    private readonly InputAction m_ControlScheme_Movement_Left;
    private readonly InputAction m_ControlScheme_Movement_Right;
    private readonly InputAction m_ControlScheme_Interaction;
    private readonly InputAction m_ControlScheme_Alternate;
    private readonly InputAction m_ControlScheme_Quit_The_Application;
    public struct ControlSchemeActions
    {
        private @DefaultInput m_Wrapper;
        public ControlSchemeActions(@DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement_Up => m_Wrapper.m_ControlScheme_Movement_Up;
        public InputAction @Movement_Down => m_Wrapper.m_ControlScheme_Movement_Down;
        public InputAction @Movement_Left => m_Wrapper.m_ControlScheme_Movement_Left;
        public InputAction @Movement_Right => m_Wrapper.m_ControlScheme_Movement_Right;
        public InputAction @Interaction => m_Wrapper.m_ControlScheme_Interaction;
        public InputAction @Alternate => m_Wrapper.m_ControlScheme_Alternate;
        public InputAction @Quit_The_Application => m_Wrapper.m_ControlScheme_Quit_The_Application;
        public InputActionMap Get() { return m_Wrapper.m_ControlScheme; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlSchemeActions set) { return set.Get(); }
        public void SetCallbacks(IControlSchemeActions instance)
        {
            if (m_Wrapper.m_ControlSchemeActionsCallbackInterface != null)
            {
                @Movement_Up.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Up;
                @Movement_Up.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Up;
                @Movement_Up.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Up;
                @Movement_Down.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Down;
                @Movement_Down.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Down;
                @Movement_Down.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Down;
                @Movement_Left.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Left;
                @Movement_Left.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Left;
                @Movement_Left.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Left;
                @Movement_Right.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Right;
                @Movement_Right.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Right;
                @Movement_Right.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnMovement_Right;
                @Interaction.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnInteraction;
                @Alternate.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnAlternate;
                @Alternate.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnAlternate;
                @Alternate.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnAlternate;
                @Quit_The_Application.started -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnQuit_The_Application;
                @Quit_The_Application.performed -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnQuit_The_Application;
                @Quit_The_Application.canceled -= m_Wrapper.m_ControlSchemeActionsCallbackInterface.OnQuit_The_Application;
            }
            m_Wrapper.m_ControlSchemeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement_Up.started += instance.OnMovement_Up;
                @Movement_Up.performed += instance.OnMovement_Up;
                @Movement_Up.canceled += instance.OnMovement_Up;
                @Movement_Down.started += instance.OnMovement_Down;
                @Movement_Down.performed += instance.OnMovement_Down;
                @Movement_Down.canceled += instance.OnMovement_Down;
                @Movement_Left.started += instance.OnMovement_Left;
                @Movement_Left.performed += instance.OnMovement_Left;
                @Movement_Left.canceled += instance.OnMovement_Left;
                @Movement_Right.started += instance.OnMovement_Right;
                @Movement_Right.performed += instance.OnMovement_Right;
                @Movement_Right.canceled += instance.OnMovement_Right;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Alternate.started += instance.OnAlternate;
                @Alternate.performed += instance.OnAlternate;
                @Alternate.canceled += instance.OnAlternate;
                @Quit_The_Application.started += instance.OnQuit_The_Application;
                @Quit_The_Application.performed += instance.OnQuit_The_Application;
                @Quit_The_Application.canceled += instance.OnQuit_The_Application;
            }
        }
    }
    public ControlSchemeActions @ControlScheme => new ControlSchemeActions(this);
    public interface IControlSchemeActions
    {
        void OnMovement_Up(InputAction.CallbackContext context);
        void OnMovement_Down(InputAction.CallbackContext context);
        void OnMovement_Left(InputAction.CallbackContext context);
        void OnMovement_Right(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnAlternate(InputAction.CallbackContext context);
        void OnQuit_The_Application(InputAction.CallbackContext context);
    }
}
