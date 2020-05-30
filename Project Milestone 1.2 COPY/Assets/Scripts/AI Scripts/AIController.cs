using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    // Connect data from the TankData class with pawn 
    public TankData pawn;
    
    // Creating a enum for the different types of AI
    public enum AITypes
    {
        // Idle = AI tank won't do anything
        // Shoot = AI will just shoot (won't move)
        Idle, Shoot
    }

    // Creating a variable to adjust AI type
    public AITypes currentAIType;

    // Function for Idle
    public void Idle()
    {
        // AI tank will do nothing
    }

    // Function for Shoot
    public void Shoot()
    {
        // If the pawn AI tank is not null then shoot bullet
        if(pawn != null)
        {
            // Shooting action
            pawn.shoot.Shoot(pawn.bulletPrefab);
        }
        
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
