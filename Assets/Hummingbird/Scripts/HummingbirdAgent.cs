using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

/// <summary>
/// A hummingbird Machine Learning Agent
/// </summary>
public class HummingbirdAgent : Agent
{
    [Tooltip("Force to apply when moving")]
    public float moveForce = 2f;

    [Tooltip("Speed to pitch up or down")]
    public float pitchSpeed = 100f;

    [Tooltip("Speed to rotate around the up axis")]
    public float yawSpeed = 100f;

    [Tooltip("Transfrom at the tip of the beak")]
    public Transform beakTip;

    [Tooltip("The agent's camera")]
    public Camera agentCamera; //for the human player

    [Tooltip("Training mode or gameplay mode")]
    public bool trainingMode;

    /// <summary>
    /// The amount of the nectar the agent has obtained this episode
    /// </summary>
    public float NectarObtained { get; private set; }

    //The rigidbody of the agent
    private Rigidbody rb;

    //The flower area that the agent is in
    private FlowerArea flowerArea;

    //The nearest flower to the agent
    private Flower nearestFlower;

    //Allows for smoother pitch changes
    private float smoothPitchChange = 0f;

    //Allows for smoother yaw changes
    private float smoothYawChange = 0f;

    //Maximum angle that the bird can pitch up or down
    private const float MaxPitchAngle = 80f;

    //Maximum distance from the beak tipo to accept nectar collision
    private const float BeakTipRadius = 0.008f;

    //The agent is frozen (intentionally not flying)
    private bool frozen = false;
}
