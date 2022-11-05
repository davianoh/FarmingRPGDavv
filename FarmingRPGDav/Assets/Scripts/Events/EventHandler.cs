using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandler : MonoBehaviour
{
    public static event Action<MovementArgs> OnMovement;

    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect, 
        bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown, 
        bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown, bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown, 
        bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {
        OnMovement?.Invoke(new MovementArgs()
        {
            inputX = inputX,
            inputY = inputY,
            isWalking = isWalking,
            isRunning = isRunning,
            isIdle = isIdle,
            isCarrying = isCarrying,
            toolEffect = toolEffect,
            isUsingToolRight = isUsingToolRight,
            isUsingToolLeft = isUsingToolLeft,
            isUsingToolUp = isUsingToolUp,
            isUsingToolDown = isUsingToolDown,
            isLiftingToolRight = isLiftingToolRight,
            isLiftingToolLeft = isLiftingToolLeft,
            isLiftingToolUp = isLiftingToolUp,
            isLiftingToolDown = isLiftingToolDown,
            isPickingRight = isPickingRight,
            isPickingLeft = isPickingLeft,
            isPickingUp = isPickingUp,
            isPickingDown = isPickingDown,
            isSwingingToolRight = isSwingingToolRight,
            isSwingingToolLeft = isSwingingToolLeft,
            isSwingingToolUp = isSwingingToolUp,
            isSwingingToolDown = isSwingingToolDown,
            idleUp = idleUp,
            idleDown = idleDown,
            idleLeft = idleLeft,
            idleRight = idleRight
        });
    }
}

public class MovementArgs : EventArgs
{
    public float inputX;
    public float inputY;
    public bool isWalking;
    public bool isRunning;
    public bool isIdle;
    public bool isCarrying;
    public ToolEffect toolEffect;
    public bool isUsingToolRight;
    public bool isUsingToolLeft;
    public bool isUsingToolUp;
    public bool isUsingToolDown;
    public bool isLiftingToolRight;
    public bool isLiftingToolLeft;
    public bool isLiftingToolUp;
    public bool isLiftingToolDown;
    public bool isPickingRight;
    public bool isPickingLeft;
    public bool isPickingUp;
    public bool isPickingDown;
    public bool isSwingingToolRight;
    public bool isSwingingToolLeft;
    public bool isSwingingToolUp;
    public bool isSwingingToolDown;
    public bool idleUp;
    public bool idleDown;
    public bool idleLeft;
    public bool idleRight;
}
