using UnityEngine;
using System;
using UnityEngine.Events;


public class InputManager : MonoBehaviour
{
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
     
    }
}
