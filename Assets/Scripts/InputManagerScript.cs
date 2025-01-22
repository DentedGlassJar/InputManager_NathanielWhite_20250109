using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerScript : MonoBehaviour, GameInput.IGameplayActions
{
    // --VARIABLES--
    
    // Reference to the gameInput class
    public GameInput gameInput;


    // --METHODS--

    private void Start()
    {
        // Makes an instance to GameInput
        gameInput = new GameInput();

        // Enables the actions map so it'll start listening
        gameInput.Gameplay.Enable();

        // Makes it so it sets this script as the callback handler for player actions
        gameInput.Gameplay.SetCallbacks(this);
    }

    // Method used for invoking the jumpEvent when the "Q" button is pressed 
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actions.jumpEvent?.Invoke();
        }

        if (context.performed)
        {
            Actions.spinEvent?.Invoke();
        }

        if (context.canceled)
        {
            Actions.fallEvent?.Invoke();
        }
    }

    // Method used for invoking the events for the Cylinder when the "W" button is pressed 
    public void OnGrow(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actions.squashEvent?.Invoke();
        }

        if (context.performed)
        {
            Actions.stretchEvent?.Invoke();
        }

        if (context.canceled)
        {
            Actions.turnToNormalEvent?.Invoke();
        }
    }

    // Method used for invoking the Events for the Sphere when the "E" button is released 
    public void OnDisappear(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actions.greenEvent?.Invoke();
        }
        
        if (context.performed)
        {
            Actions.yellowEvent?.Invoke();
        }
        
        if (context.canceled)
        {
            Actions.disappearEvent?.Invoke();
        }
    }
}
