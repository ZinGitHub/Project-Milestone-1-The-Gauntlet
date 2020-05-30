using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    // Property atrribute add a head above fields in the inspector
    // Header for components
    [Header("Components")]
    // Header field for Transform
    // tf will hold data for Transform
    public Transform tf;
    // Header field for TankMotor
    // mover will hold data for TankMotor
    public TankMotor mover;
    // Header field for TankShooter
    // shoot will hold data for TankShooter
    public TankShooter shoot;
    // Header field for TankHealth
    // health will hold data for TankHealth
    public TankHealth health;

    // Property atrribute add a head above fields in the inspector
    // Header for variables
    [Header("Variables")]
    // Public float for moveSpeed = the speed at which the tank goes forward
    public float moveSpeed;
    // Float for reverseMoveSpeed = the speed at which the tank goes backwards
    public float reverseMoveSpeed;
    // Float for rotateSpeed = the speed at which the tank rotates
    public float rotateSpeed;
    // Float for fireCooldown = the duration for how long until another bullet can be shot
    public float fireCooldown;
    // Float for score, score will start at zero
    public float score = 0;
    // Float for points, for every tank killed gives you one point
    public float points = 1;

    // Property atrribute add a head above fields in the inspector
    // Header for components
    [Header("GameObjects")]
    // Set a bulletPreFab in inspector
    public GameObject bulletPrefab;

    // Initialize the variables and game state
    private void Awake()
    {
        // Recall and intialize Transform component
        tf = GetComponent<Transform>();
        // Recall and intialize TankMotor component
        mover = GetComponent<TankMotor>();
        // Recall and intialize TankShooter component
        shoot = GetComponent<TankShooter>();
        // Recall and intialize TankHealth component
        health = GetComponent<TankHealth>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
