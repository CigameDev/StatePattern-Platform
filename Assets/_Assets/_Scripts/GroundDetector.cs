using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public Collider2D agentCollider;
    public LayerMask groundMask;

    public bool isGrounded = false;

    [Header("Gizmo parameter")]
    [Range(-2f, 2f)]
    public float boxCastYOffset = -0.1f;
    [Range(-2f, 2f)]
    public float boxCastXOffset = -0.1f;
    [Range(0, 2)]
    public float boxCastWidth = 1, boxCastHeight = 1;
    public Color gizmoColorNotGrounded = Color.red, gizmoColorIsGrounded = Color.green;


    private void Awake()
    {
        if(agentCollider == null)
        {
            agentCollider = GetComponent<Collider2D>();
        }    
    }

    public void CheckIsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(agentCollider.bounds.center + new Vector3(boxCastXOffset, boxCastYOffset, 0f)
            , new Vector2(boxCastHeight, boxCastHeight), 0, Vector2.down, 0, groundMask);

        if(raycastHit.collider == null)
        {
            isGrounded = false;
        }    
        else
        {
            isGrounded = true;
        }    
    }    

    private void OnDrawGizmos()
    {
        if (!agentCollider) return;
        Gizmos.color = gizmoColorNotGrounded;
        if(isGrounded == true)
        {
            Gizmos.color = gizmoColorIsGrounded;
        }    

        Gizmos.DrawCube(agentCollider.bounds.center + new Vector3(boxCastXOffset,boxCastYOffset,0f),
            new Vector3(boxCastWidth,boxCastHeight,0f));
    }

}
