using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    public static InputPlayer Instance;
    
    private IptAct_Standard _playerActionSet;
    private InputAction _wasd;
    private InputAction _mouseDelta;

    private void Awake()
    {
        _playerActionSet = new IptAct_Standard();
    }

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        _playerActionSet._3DScene.Enable();
        _wasd = _playerActionSet._3DScene.wasd;
        _mouseDelta = _playerActionSet._3DScene.MouseDelta;
    }

    private void OnDisable()
    {
        _playerActionSet._3DScene.Disable();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public InputAction GetWASD()
    {
        return _wasd;
    }

    public InputAction GetMouseDelta()
    {
        return _mouseDelta;
    }
}
