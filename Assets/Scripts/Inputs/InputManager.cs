using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
  // There should be only one InputManager in the scene
  private static InputManager instance;
  public static InputManager Instance {get {return instance;}}
// Action schemes
private RunnerInputAction actionScheme;

// Configuration
[SerializeField] private float sqrSwipeDeadzone = 50.0f;
#region  public properties
public bool Tap { get { return tap ;}}
public Vector2 TouchPosition { get { return TouchPosition; } }
public bool SwipeLeft { get { return swipeLeft; } }
public bool SwipeRight { get { return swipeRight; } }
public bool SwipeUp { get { return swipeUp; } }
public bool SwipeDown { get { return swipeDown; } }

#endregion

#region  privates
private bool tap;

private Vector2 touchPosition;

private Vector2 startDrag;
private bool swipeRight;
private bool swipeLeft;

private bool swipeUp;
private bool swipeDown;

#endregion
  private void Awake()
  {
      instance = this;
      DontDestroyOnLoad(gameObject);
      SetupControl();
  }

 private void LateUpdate() 
 {
      ResetInputs();
 }
private void ResetInputs()
 {
        tap = false;
        swipeLeft = false;
        swipeRight = false;
        swipeUp = false;
        swipeDown = false;
 } 

  private void SetupControl()
  {
      actionScheme = new RunnerInputAction();

      // Register different actions
      actionScheme.GamePlay.Tap.performed += ctx => OnTap(ctx);
      actionScheme.GamePlay.TouchPosition.performed += ctx => OnPosition(ctx);
        actionScheme.GamePlay.StartDrag.performed += ctx => OnStartDrag(ctx);
         actionScheme.GamePlay.EndDrag.performed += ctx => OnEndDrag(ctx);
      
  }

    private void OnEndDrag(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
       Vector2 delta = touchPosition - startDrag;
       float sqrDistance = delta.sqrMagnitude;
       // Confirmed swipe
       if(sqrDistance > sqrSwipeDeadzone)

       {
         float x = Mathf.Abs(delta.x);
         float y = Mathf.Abs(delta.y);

         if(x > y) // Left of Right
         {
             if(delta.x > 0)
             {
                 swipeRight = true;
             }
             else
             {
                 swipeLeft = true;
             }

         }
         else // Up or Down
         {
              if(delta.y > 0)
             {
                 swipeUp = true;
             }
             else
             {
                 swipeDown = true;
             }


         }
      
       }
        
        startDrag = Vector2.zero;
    }

    private void OnStartDrag(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        startDrag = touchPosition;
    }

    private void OnPosition(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        touchPosition = ctx.ReadValue<Vector2>();
    }

    private void OnTap(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        tap = true;
    }
   
   public void  OnEnable()
    {
       actionScheme.Enable();
    }

    public void OnDisable()
    {
         actionScheme.Disable();
    }










}

/*
          Dynamic Update
          InputManager that processes the inputs
          PlayerMotor uses these inputs to move
          

          
        
          Late Update
          InputMAnager resets these inputs

*/