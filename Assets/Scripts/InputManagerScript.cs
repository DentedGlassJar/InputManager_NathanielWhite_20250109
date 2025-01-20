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
        if(context.performed)
        {
            Actions.jumpEvent?.Invoke();
        }    
    }

    // Method used for invoking the growEvent when the "W" button is pressed 
    public void OnGrow(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Actions.growEvent?.Invoke();
        }
    }

    // Method used for invoking the disappearEvent when the "E" button is pressed 
    public void OnDisappear(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Actions.disappearEvent?.Invoke();
        }
    }
}
