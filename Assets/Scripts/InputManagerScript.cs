using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerScript : MonoBehaviour, GameInput.IGameplayActions
{
    public GameInput gameInput;
    private Action jumpEvent;

    // --METHODS--


    private void Start()
    {
        gameInput = new GameInput();

        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Jump Performed");
            jumpEvent?.Invoke();
        }    
    }

}
