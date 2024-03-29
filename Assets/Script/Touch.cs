//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Script/Touch.inputactions
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

public partial class @Touch: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Touch()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Touch"",
    ""maps"": [
        {
            ""name"": ""Touch to Cut"",
            ""id"": ""f66c6960-b425-44f6-83b7-fae056353dfe"",
            ""actions"": [
                {
                    ""name"": ""Cut"",
                    ""type"": ""Button"",
                    ""id"": ""9c87a299-ac67-4fbc-977d-1d74486a0bc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4154a7f3-4c06-4bde-af67-ebcee022182a"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44dba9c3-29ef-4f64-8869-a6e0cc60f801"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch to Cut
        m_TouchtoCut = asset.FindActionMap("Touch to Cut", throwIfNotFound: true);
        m_TouchtoCut_Cut = m_TouchtoCut.FindAction("Cut", throwIfNotFound: true);
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

    // Touch to Cut
    private readonly InputActionMap m_TouchtoCut;
    private List<ITouchtoCutActions> m_TouchtoCutActionsCallbackInterfaces = new List<ITouchtoCutActions>();
    private readonly InputAction m_TouchtoCut_Cut;
    public struct TouchtoCutActions
    {
        private @Touch m_Wrapper;
        public TouchtoCutActions(@Touch wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cut => m_Wrapper.m_TouchtoCut_Cut;
        public InputActionMap Get() { return m_Wrapper.m_TouchtoCut; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchtoCutActions set) { return set.Get(); }
        public void AddCallbacks(ITouchtoCutActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchtoCutActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchtoCutActionsCallbackInterfaces.Add(instance);
            @Cut.started += instance.OnCut;
            @Cut.performed += instance.OnCut;
            @Cut.canceled += instance.OnCut;
        }

        private void UnregisterCallbacks(ITouchtoCutActions instance)
        {
            @Cut.started -= instance.OnCut;
            @Cut.performed -= instance.OnCut;
            @Cut.canceled -= instance.OnCut;
        }

        public void RemoveCallbacks(ITouchtoCutActions instance)
        {
            if (m_Wrapper.m_TouchtoCutActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchtoCutActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchtoCutActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchtoCutActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchtoCutActions @TouchtoCut => new TouchtoCutActions(this);
    public interface ITouchtoCutActions
    {
        void OnCut(InputAction.CallbackContext context);
    }
}
