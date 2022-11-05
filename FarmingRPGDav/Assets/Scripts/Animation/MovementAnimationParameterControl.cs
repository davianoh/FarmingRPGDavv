using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimationParameterControl : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.OnMovement += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.OnMovement -= SetAnimationParameters;
    }

    private void SetAnimationParameters(MovementArgs movementArgs)
    {
        animator.SetFloat(Settings.xInput, movementArgs.inputX);
        animator.SetFloat(Settings.yInput, movementArgs.inputY);
        animator.SetBool(Settings.isWalking, movementArgs.isWalking);
        animator.SetBool(Settings.isRunning, movementArgs.isRunning);
        animator.SetInteger(Settings.toolEffect, (int)movementArgs.toolEffect);

        if (movementArgs.isUsingToolRight)
            animator.SetTrigger(Settings.isUsingToolRight);
        if (movementArgs.isUsingToolLeft)
            animator.SetTrigger(Settings.isUsingToolLeft);
        if (movementArgs.isUsingToolUp)
            animator.SetTrigger(Settings.isUsingToolUp);
        if (movementArgs.isUsingToolDown)
            animator.SetTrigger(Settings.isUsingToolDown);

        if (movementArgs.isLiftingToolRight)
            animator.SetTrigger(Settings.isLiftingToolRight);
        if (movementArgs.isLiftingToolLeft)
            animator.SetTrigger(Settings.isLiftingToolLeft);
        if (movementArgs.isLiftingToolUp)
            animator.SetTrigger(Settings.isLiftingToolUp);
        if (movementArgs.isLiftingToolDown)
            animator.SetTrigger(Settings.isLiftingToolDown);

        if (movementArgs.isPickingRight)
            animator.SetTrigger(Settings.isPickingRight);
        if (movementArgs.isPickingLeft)
            animator.SetTrigger(Settings.isPickingLeft);
        if (movementArgs.isPickingUp)
            animator.SetTrigger(Settings.isPickingUp);
        if (movementArgs.isPickingDown)
            animator.SetTrigger(Settings.isPickingDown);

        if (movementArgs.isSwingingToolRight)
            animator.SetTrigger(Settings.isSwingingToolRight);
        if (movementArgs.isSwingingToolLeft)
            animator.SetTrigger(Settings.isSwingingToolLeft);
        if (movementArgs.isSwingingToolUp)
            animator.SetTrigger(Settings.isSwingingToolUp);
        if (movementArgs.isSwingingToolDown)
            animator.SetTrigger(Settings.isSwingingToolDown);

        if (movementArgs.idleUp)
            animator.SetTrigger(Settings.idleUp);
        if (movementArgs.idleDown)
            animator.SetTrigger(Settings.idleDown);
        if (movementArgs.idleLeft)
            animator.SetTrigger(Settings.idleLeft);
        if (movementArgs.idleRight)
            animator.SetTrigger(Settings.idleRight);
    }

    private void AnimationEventPlayFootstepSound()
    {

    }
}
