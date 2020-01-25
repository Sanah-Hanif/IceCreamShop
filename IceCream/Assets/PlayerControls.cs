// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay1"",
            ""id"": ""90f199dc-72e7-4c26-a9ef-2450b98bd665"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ee1a17fc-0af8-4d75-a52f-b9e592d0c60c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""69bf3528-f4b5-4048-b419-48143a878256"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""468e144a-1566-47d3-bd5c-26b478d84d8d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b90e864-3fe4-4b6c-9c94-8920964b10ee"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay1
        m_GamePlay1 = asset.FindActionMap("GamePlay1", throwIfNotFound: true);
        m_GamePlay1_Move = m_GamePlay1.FindAction("Move", throwIfNotFound: true);
        m_GamePlay1_Select = m_GamePlay1.FindAction("Select", throwIfNotFound: true);
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

    // GamePlay1
    private readonly InputActionMap m_GamePlay1;
    private IGamePlay1Actions m_GamePlay1ActionsCallbackInterface;
    private readonly InputAction m_GamePlay1_Move;
    private readonly InputAction m_GamePlay1_Select;
    public struct GamePlay1Actions
    {
        private @PlayerControls m_Wrapper;
        public GamePlay1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GamePlay1_Move;
        public InputAction @Select => m_Wrapper.m_GamePlay1_Select;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlay1Actions set) { return set.Get(); }
        public void SetCallbacks(IGamePlay1Actions instance)
        {
            if (m_Wrapper.m_GamePlay1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnMove;
                @Select.started -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_GamePlay1ActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_GamePlay1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public GamePlay1Actions @GamePlay1 => new GamePlay1Actions(this);
    public interface IGamePlay1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
