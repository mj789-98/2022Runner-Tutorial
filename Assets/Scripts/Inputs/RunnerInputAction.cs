// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/RunnerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RunnerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @RunnerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RunnerInputAction"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""0cc67c65-1e56-4a10-88f9-aa8b8f868a81"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""17a2fe23-3cd3-4225-bbed-f83140114bc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""337405ba-d2d4-4ec5-8e3c-d9286b3168b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EndDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e9ba15f3-2afb-4506-8425-13a0388a9e49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""StartDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ce48cf38-ce5d-4fd4-a739-404b0acb51cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c7eb3b6-9546-40cc-b492-1dfc7f91b4ae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""320d3e55-f920-43a5-ac87-8c250c4e76d0"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afec512a-48bc-4ea3-a912-500f9ecd2881"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a6de9c1-c9a5-4ff7-8ec4-983bb81e8cf2"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d948670-96b7-489b-b602-e1c4aca409aa"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5f9c330-d9e7-45a3-b4d3-bea179ad69a9"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d37f3752-9964-48ac-976d-f663bcdf6fec"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""556e3be7-df6c-432c-9b7f-6c5b5a671656"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Computer"",
            ""bindingGroup"": ""Computer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Tap = m_GamePlay.FindAction("Tap", throwIfNotFound: true);
        m_GamePlay_TouchPosition = m_GamePlay.FindAction("TouchPosition", throwIfNotFound: true);
        m_GamePlay_EndDrag = m_GamePlay.FindAction("EndDrag", throwIfNotFound: true);
        m_GamePlay_StartDrag = m_GamePlay.FindAction("StartDrag", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Tap;
    private readonly InputAction m_GamePlay_TouchPosition;
    private readonly InputAction m_GamePlay_EndDrag;
    private readonly InputAction m_GamePlay_StartDrag;
    public struct GamePlayActions
    {
        private @RunnerInputAction m_Wrapper;
        public GamePlayActions(@RunnerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_GamePlay_Tap;
        public InputAction @TouchPosition => m_Wrapper.m_GamePlay_TouchPosition;
        public InputAction @EndDrag => m_Wrapper.m_GamePlay_EndDrag;
        public InputAction @StartDrag => m_Wrapper.m_GamePlay_StartDrag;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTap;
                @TouchPosition.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTouchPosition;
                @EndDrag.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEndDrag;
                @EndDrag.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEndDrag;
                @EndDrag.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnEndDrag;
                @StartDrag.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartDrag;
                @StartDrag.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartDrag;
                @StartDrag.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartDrag;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @EndDrag.started += instance.OnEndDrag;
                @EndDrag.performed += instance.OnEndDrag;
                @EndDrag.canceled += instance.OnEndDrag;
                @StartDrag.started += instance.OnStartDrag;
                @StartDrag.performed += instance.OnStartDrag;
                @StartDrag.canceled += instance.OnStartDrag;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_ComputerSchemeIndex = -1;
    public InputControlScheme ComputerScheme
    {
        get
        {
            if (m_ComputerSchemeIndex == -1) m_ComputerSchemeIndex = asset.FindControlSchemeIndex("Computer");
            return asset.controlSchemes[m_ComputerSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnTap(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnEndDrag(InputAction.CallbackContext context);
        void OnStartDrag(InputAction.CallbackContext context);
    }
}
