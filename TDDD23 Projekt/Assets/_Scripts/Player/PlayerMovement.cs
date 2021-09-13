// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/Player/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""a7a036c4-64c0-4555-88d8-6245c652b703"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc81762c-3c8e-4b71-84b1-3ea1035015e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftMouseClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""62a08155-d610-42e6-8402-dc55b24f75bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightMouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""ad9bf6fa-033d-448f-b253-e2075bf3d21d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""08ba53cc-5c01-49d2-a984-4ce722b7192e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f19ebebf-0296-4953-baab-d12a8be6664a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""302a8a1e-09dc-40b0-abcf-b80b32a6cacb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c23f0a31-761e-4188-9522-b4bdbb2e670f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ef9c413-e799-4afd-954e-2882bece7cbb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""10611cd5-e695-4b31-9aa1-538432fc7618"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""3906f305-ae40-40be-abe5-4b5c9e7971a7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0bf6a03c-b95e-4ef2-9e31-dca3730180d2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""03674541-adf3-40e2-905f-7fa450960efd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ad8276d8-b21d-428d-8b9f-7012acf4067b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6e52b48-e50a-4ac6-838d-1bb2a1f4c63e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0e28065b-beec-4f8c-89c7-01197e9d2c26"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f591192-2890-4201-86ca-425bf1f350ae"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b2008f4-cefe-44dd-9a2d-89394718ecbf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Movement = m_Main.FindAction("Movement", throwIfNotFound: true);
        m_Main_LeftMouseClick = m_Main.FindAction("LeftMouseClick", throwIfNotFound: true);
        m_Main_RightMouseClick = m_Main.FindAction("RightMouseClick", throwIfNotFound: true);
        m_Main_MousePosition = m_Main.FindAction("MousePosition", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Movement;
    private readonly InputAction m_Main_LeftMouseClick;
    private readonly InputAction m_Main_RightMouseClick;
    private readonly InputAction m_Main_MousePosition;
    public struct MainActions
    {
        private @PlayerMovement m_Wrapper;
        public MainActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Main_Movement;
        public InputAction @LeftMouseClick => m_Wrapper.m_Main_LeftMouseClick;
        public InputAction @RightMouseClick => m_Wrapper.m_Main_RightMouseClick;
        public InputAction @MousePosition => m_Wrapper.m_Main_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @LeftMouseClick.started -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftMouseClick;
                @LeftMouseClick.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftMouseClick;
                @LeftMouseClick.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftMouseClick;
                @RightMouseClick.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRightMouseClick;
                @RightMouseClick.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRightMouseClick;
                @MousePosition.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LeftMouseClick.started += instance.OnLeftMouseClick;
                @LeftMouseClick.performed += instance.OnLeftMouseClick;
                @LeftMouseClick.canceled += instance.OnLeftMouseClick;
                @RightMouseClick.started += instance.OnRightMouseClick;
                @RightMouseClick.performed += instance.OnRightMouseClick;
                @RightMouseClick.canceled += instance.OnRightMouseClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLeftMouseClick(InputAction.CallbackContext context);
        void OnRightMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
