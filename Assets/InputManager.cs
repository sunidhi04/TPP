using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InputManager: MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    public UnityEvent OnShiftPressed = new UnityEvent();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        OnSpacePressed?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            OnShiftPressed?.Invoke();
        }

        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            input += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input += Vector2.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            input += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input += Vector2.down;
        }
        OnMove?.Invoke(input);

    }
}