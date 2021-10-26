// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""75437cbf-5eab-4b94-ae76-0698390c90e1"",
            ""actions"": [
                {
                    ""name"": ""PassTurn"",
                    ""type"": ""Button"",
                    ""id"": ""35d10b6f-44a7-4ec1-8bb8-3a15c9e86550"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""29d0167c-950d-4db1-a72a-9f39e966ce51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right1"",
                    ""type"": ""Button"",
                    ""id"": ""6813bea0-80ee-464c-a122-de57cdffef44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e4cb7d1d-e0ad-4568-8543-9eb609f00202"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PassTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4862b7ea-d41d-4dfb-b0dd-11c2be13d589"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""532c527a-e212-44db-9530-f72131cb3995"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_PassTurn = m_Gameplay.FindAction("PassTurn", throwIfNotFound: true);
        m_Gameplay_Left = m_Gameplay.FindAction("Left", throwIfNotFound: true);
        m_Gameplay_Right1 = m_Gameplay.FindAction("Right1", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_PassTurn;
    private readonly InputAction m_Gameplay_Left;
    private readonly InputAction m_Gameplay_Right1;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PassTurn => m_Wrapper.m_Gameplay_PassTurn;
        public InputAction @Left => m_Wrapper.m_Gameplay_Left;
        public InputAction @Right1 => m_Wrapper.m_Gameplay_Right1;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @PassTurn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPassTurn;
                @PassTurn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPassTurn;
                @PassTurn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPassTurn;
                @Left.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeft;
                @Right1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight1;
                @Right1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight1;
                @Right1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRight1;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PassTurn.started += instance.OnPassTurn;
                @PassTurn.performed += instance.OnPassTurn;
                @PassTurn.canceled += instance.OnPassTurn;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right1.started += instance.OnRight1;
                @Right1.performed += instance.OnRight1;
                @Right1.canceled += instance.OnRight1;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnPassTurn(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight1(InputAction.CallbackContext context);
    }
}
