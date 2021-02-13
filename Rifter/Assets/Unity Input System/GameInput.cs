// GENERATED AUTOMATICALLY FROM 'Assets/Unity Input System/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""1ab6cda7-468c-400f-93c6-355af4ed07b5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a0240726-e898-4bd2-add6-acff5c2b572e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8906ad63-0904-4675-b4fc-ff2cff441b4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AIM"",
                    ""type"": ""Value"",
                    ""id"": ""80c3d39c-cbe5-4aef-b651-55bbc164f6f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2057fb70-f50c-4e5d-92d2-aef142bd6ef2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7a21775-cf3c-4ea9-8182-96d1986f780d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1c9e9942-4b71-45ac-a963-0220960986a2"",
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
                    ""id"": ""bcdc28fe-750e-43e9-b1c9-6537f9da74fd"",
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
                    ""id"": ""b2da497d-2318-4245-845f-6f2c72ede285"",
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
                    ""id"": ""fa5c9e98-d7fb-48f8-a018-9c236962d689"",
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
                    ""id"": ""c5f55803-0da6-44a7-baba-7b73fcabe3de"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a49bdeea-beb6-407b-ad34-63b8b7fec530"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8225c07-cbca-4854-8ff8-737d039457a8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffc730ee-3992-4544-8418-6362cf810491"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory Controls"",
            ""id"": ""e5efc751-91d8-4158-a111-3af5058d1997"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""b383fffb-2662-4779-80d8-cca68f3dd0fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8e9efecd-57a4-405f-9c0e-8fee19eac06c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Settings Controls"",
            ""id"": ""8b2667a0-9230-4f0d-8df7-6c1cb2ec1f5f"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""35dfcfb8-d39a-41da-86fc-a850faf0df11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bcdca8f8-5bcf-4fbc-bf0b-f032d122da8c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Controls"",
            ""id"": ""e3db7473-f298-4104-942c-fcf82a5184c6"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""b0816abf-7319-4d2e-8234-db2576ac8b16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a93dce83-970f-4350-a735-8f041da546ed"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepads"",
            ""bindingGroup"": ""Gamepads"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Attack = m_PlayerControls.FindAction("Attack", throwIfNotFound: true);
        m_PlayerControls_AIM = m_PlayerControls.FindAction("AIM", throwIfNotFound: true);
        // Inventory Controls
        m_InventoryControls = asset.FindActionMap("Inventory Controls", throwIfNotFound: true);
        m_InventoryControls_Newaction = m_InventoryControls.FindAction("New action", throwIfNotFound: true);
        // Settings Controls
        m_SettingsControls = asset.FindActionMap("Settings Controls", throwIfNotFound: true);
        m_SettingsControls_Newaction = m_SettingsControls.FindAction("New action", throwIfNotFound: true);
        // Menu Controls
        m_MenuControls = asset.FindActionMap("Menu Controls", throwIfNotFound: true);
        m_MenuControls_Newaction = m_MenuControls.FindAction("New action", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Attack;
    private readonly InputAction m_PlayerControls_AIM;
    public struct PlayerControlsActions
    {
        private @GameInput m_Wrapper;
        public PlayerControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Attack => m_Wrapper.m_PlayerControls_Attack;
        public InputAction @AIM => m_Wrapper.m_PlayerControls_AIM;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @AIM.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAIM;
                @AIM.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAIM;
                @AIM.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAIM;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @AIM.started += instance.OnAIM;
                @AIM.performed += instance.OnAIM;
                @AIM.canceled += instance.OnAIM;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Inventory Controls
    private readonly InputActionMap m_InventoryControls;
    private IInventoryControlsActions m_InventoryControlsActionsCallbackInterface;
    private readonly InputAction m_InventoryControls_Newaction;
    public struct InventoryControlsActions
    {
        private @GameInput m_Wrapper;
        public InventoryControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_InventoryControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_InventoryControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryControlsActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryControlsActions instance)
        {
            if (m_Wrapper.m_InventoryControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_InventoryControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_InventoryControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_InventoryControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_InventoryControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public InventoryControlsActions @InventoryControls => new InventoryControlsActions(this);

    // Settings Controls
    private readonly InputActionMap m_SettingsControls;
    private ISettingsControlsActions m_SettingsControlsActionsCallbackInterface;
    private readonly InputAction m_SettingsControls_Newaction;
    public struct SettingsControlsActions
    {
        private @GameInput m_Wrapper;
        public SettingsControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_SettingsControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_SettingsControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SettingsControlsActions set) { return set.Get(); }
        public void SetCallbacks(ISettingsControlsActions instance)
        {
            if (m_Wrapper.m_SettingsControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_SettingsControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_SettingsControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_SettingsControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_SettingsControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public SettingsControlsActions @SettingsControls => new SettingsControlsActions(this);

    // Menu Controls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_Newaction;
    public struct MenuControlsActions
    {
        private @GameInput m_Wrapper;
        public MenuControlsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MenuControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);
    private int m_GamepadsSchemeIndex = -1;
    public InputControlScheme GamepadsScheme
    {
        get
        {
            if (m_GamepadsSchemeIndex == -1) m_GamepadsSchemeIndex = asset.FindControlSchemeIndex("Gamepads");
            return asset.controlSchemes[m_GamepadsSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnAIM(InputAction.CallbackContext context);
    }
    public interface IInventoryControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface ISettingsControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IMenuControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
