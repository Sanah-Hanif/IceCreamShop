// GENERATED AUTOMATICALLY FROM 'Assets/Sanah's Game/Input Controller/PlayerInput.inputactions'

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
            ""name"": ""gameplay"",
            ""id"": ""dd3006b5-0af6-4574-91b7-be54675cfd69"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Button"",
                    ""id"": ""350e59b9-1e68-4675-bd4c-4e235d58059d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""f7b7ce6c-46c9-493e-bd8a-8b80b18ab25a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""86d38dad-5801-4471-bebb-934354fd218c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48998ec8-8e4c-413b-807b-902d59f4b434"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_move = m_gameplay.FindAction("move", throwIfNotFound: true);
        m_gameplay_select = m_gameplay.FindAction("select", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_move;
    private readonly InputAction m_gameplay_select;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_gameplay_move;
        public InputAction @select => m_Wrapper.m_gameplay_select;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @select.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
