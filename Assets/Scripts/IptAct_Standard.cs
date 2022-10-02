//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scripts/IptAct_Standard.inputactions
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

public partial class @IptAct_Standard : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IptAct_Standard()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""IptAct_Standard"",
    ""maps"": [
        {
            ""name"": ""3DScene"",
            ""id"": ""c45e127b-6b4d-41b4-9785-af62964ca50a"",
            ""actions"": [
                {
                    ""name"": ""wasd"",
                    ""type"": ""Value"",
                    ""id"": ""bdffde83-e59d-49d7-aa6c-f05a4ac2e9a5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""7b763d27-aa43-45d3-82a5-f50801f8a1f7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MiddleClickTap"",
                    ""type"": ""Button"",
                    ""id"": ""97dc8512-7dd9-4b38-a7df-6026614e89ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.15)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiddleClickHold"",
                    ""type"": ""Button"",
                    ""id"": ""6afc401b-ba48-4cb9-92c7-6d9f218749f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.15,pressPoint=0.5)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiddleClickDoublTap"",
                    ""type"": ""Button"",
                    ""id"": ""aea608b3-4257-4a45-95dd-923baa21f37b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapDelay=0.2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""87a2413d-2cb2-46a4-92fe-f6e4b360c2a5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wasd"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7acb17db-893c-47d2-8064-a6f4a579db79"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""89a1f8b7-a171-4e37-9043-3da04b12471c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ebb9699d-f745-41c6-87a0-e3c1975621e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0c566a35-d18f-4af1-8302-75dfa37fef26"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""wasd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0dafaf5b-ceab-4159-9577-3302ac75b586"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""982175a7-45fc-4fc7-bbf4-6baadeecc9fa"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""MiddleClickTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""496be6f2-7384-4b90-86f3-941dca2faebc"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""MiddleClickHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7c2583d-7f96-4991-b4f3-f8b37241669d"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""MiddleClickDoublTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Standard"",
            ""bindingGroup"": ""Standard"",
            ""devices"": []
        }
    ]
}");
        // 3DScene
        m__3DScene = asset.FindActionMap("3DScene", throwIfNotFound: true);
        m__3DScene_wasd = m__3DScene.FindAction("wasd", throwIfNotFound: true);
        m__3DScene_MouseDelta = m__3DScene.FindAction("MouseDelta", throwIfNotFound: true);
        m__3DScene_MiddleClickTap = m__3DScene.FindAction("MiddleClickTap", throwIfNotFound: true);
        m__3DScene_MiddleClickHold = m__3DScene.FindAction("MiddleClickHold", throwIfNotFound: true);
        m__3DScene_MiddleClickDoublTap = m__3DScene.FindAction("MiddleClickDoublTap", throwIfNotFound: true);
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

    // 3DScene
    private readonly InputActionMap m__3DScene;
    private I_3DSceneActions m__3DSceneActionsCallbackInterface;
    private readonly InputAction m__3DScene_wasd;
    private readonly InputAction m__3DScene_MouseDelta;
    private readonly InputAction m__3DScene_MiddleClickTap;
    private readonly InputAction m__3DScene_MiddleClickHold;
    private readonly InputAction m__3DScene_MiddleClickDoublTap;
    public struct _3DSceneActions
    {
        private @IptAct_Standard m_Wrapper;
        public _3DSceneActions(@IptAct_Standard wrapper) { m_Wrapper = wrapper; }
        public InputAction @wasd => m_Wrapper.m__3DScene_wasd;
        public InputAction @MouseDelta => m_Wrapper.m__3DScene_MouseDelta;
        public InputAction @MiddleClickTap => m_Wrapper.m__3DScene_MiddleClickTap;
        public InputAction @MiddleClickHold => m_Wrapper.m__3DScene_MiddleClickHold;
        public InputAction @MiddleClickDoublTap => m_Wrapper.m__3DScene_MiddleClickDoublTap;
        public InputActionMap Get() { return m_Wrapper.m__3DScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_3DSceneActions set) { return set.Get(); }
        public void SetCallbacks(I_3DSceneActions instance)
        {
            if (m_Wrapper.m__3DSceneActionsCallbackInterface != null)
            {
                @wasd.started -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnWasd;
                @wasd.performed -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnWasd;
                @wasd.canceled -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnWasd;
                @MouseDelta.started -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMouseDelta;
                @MiddleClickTap.started -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickTap;
                @MiddleClickTap.performed -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickTap;
                @MiddleClickTap.canceled -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickTap;
                @MiddleClickHold.started -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickHold;
                @MiddleClickHold.performed -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickHold;
                @MiddleClickHold.canceled -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickHold;
                @MiddleClickDoublTap.started -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickDoublTap;
                @MiddleClickDoublTap.performed -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickDoublTap;
                @MiddleClickDoublTap.canceled -= m_Wrapper.m__3DSceneActionsCallbackInterface.OnMiddleClickDoublTap;
            }
            m_Wrapper.m__3DSceneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @wasd.started += instance.OnWasd;
                @wasd.performed += instance.OnWasd;
                @wasd.canceled += instance.OnWasd;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @MiddleClickTap.started += instance.OnMiddleClickTap;
                @MiddleClickTap.performed += instance.OnMiddleClickTap;
                @MiddleClickTap.canceled += instance.OnMiddleClickTap;
                @MiddleClickHold.started += instance.OnMiddleClickHold;
                @MiddleClickHold.performed += instance.OnMiddleClickHold;
                @MiddleClickHold.canceled += instance.OnMiddleClickHold;
                @MiddleClickDoublTap.started += instance.OnMiddleClickDoublTap;
                @MiddleClickDoublTap.performed += instance.OnMiddleClickDoublTap;
                @MiddleClickDoublTap.canceled += instance.OnMiddleClickDoublTap;
            }
        }
    }
    public _3DSceneActions @_3DScene => new _3DSceneActions(this);
    private int m_StandardSchemeIndex = -1;
    public InputControlScheme StandardScheme
    {
        get
        {
            if (m_StandardSchemeIndex == -1) m_StandardSchemeIndex = asset.FindControlSchemeIndex("Standard");
            return asset.controlSchemes[m_StandardSchemeIndex];
        }
    }
    public interface I_3DSceneActions
    {
        void OnWasd(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnMiddleClickTap(InputAction.CallbackContext context);
        void OnMiddleClickHold(InputAction.CallbackContext context);
        void OnMiddleClickDoublTap(InputAction.CallbackContext context);
    }
}