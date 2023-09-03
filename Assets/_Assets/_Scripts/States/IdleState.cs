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
    }

    protected override void HandleMovement(Vector2 input)
    {
        agent.TransitonToState(MoveState,this);
    }
}
