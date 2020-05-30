using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITypeChange : AIController
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Switch statment to change the behavior of the AI to either idle or shoot mode
        switch (currentAIType)
        {
            // If designer changes the AI type to Idle
            case AITypes.Idle:
                // Initialize into Idle AI type (AI tank will do nothing)
                Idle();
                break;
            
            // If designer changes the AI type to Shoot
            case AITypes.Shoot:
                // Initialize into Shoot AI type (AI tank will shoot bullets but won't move)
                Shoot();
                break;
        }
    }
}
