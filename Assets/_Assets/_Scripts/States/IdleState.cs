using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class IdleState : State
{
    public State MoveState;
    protected override void EnterState()
    {
        agent.animationManager.PlayAnimation(AnimationType.idle);
        if(agent.groundDetector.isGrounded)
        {
            agent.rb2d.velocity = Vector2.zero;
        }    
    }

    protected override void HandleMovement(Vector2 input)
    {
        if (Mathf.Abs(input.x) > 0)
        {
            agent.TransitionToState(MoveState);
        }
    }
}
