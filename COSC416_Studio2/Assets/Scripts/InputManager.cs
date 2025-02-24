using UnityEngine;
using System;
using UnityEngine.Events;


public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    public UnityEvent OnResetPressed = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public UnityEvent onSpacePressed = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            onSpacePressed?.Invoke();
        }

        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
             {
             input += Vector2.right;
             }

         if (Input.GetKey(KeyCode.D))
             {
             input += Vector2.left;
             }

        OnMove?.Invoke(input);

        if (Input.GetKeyDown(KeyCode.R))
        {
            OnResetPressed?.Invoke();
        }

    }
}
