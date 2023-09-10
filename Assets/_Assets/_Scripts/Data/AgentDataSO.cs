using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AgentDataSO", menuName = "SO/AgentDataSO")]
public class AgentDataSO : ScriptableObject
{
    [Header("Movement data")]
    [Space]
    public float maxSpeed = 5f;
    public float acceleration = 50f;
    public float deacceleration = 50f;

    [Header("Jump data")]
    [Space]
    public float jumpForce = 12f;
    public float lowJumpMultiplier = 2f;
    public float gravityModifier = 0.5f;
}
