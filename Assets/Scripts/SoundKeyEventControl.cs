using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;


public class SoundKeyEventControl : MonoBehaviour
{
    public AK.Wwise.Event playEventB; 
    public AK.Wwise.Event stopEventB;
    public AK.Wwise.Event playEventX;
    public AK.Wwise.Event stopEventX; // this is robin editing

    void Update()
    {
        // Check if the 'B' key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B key is pressed");
            // Stop the event associated with 'B'
            if (stopEventB != null)
            {
                stopEventB.Stop(gameObject);
            }

            // Play the event associated with 'B'
            if (playEventB != null)
            {
                playEventB.Post(gameObject);
            }
        }

        // Check if the 'X' key is pressed
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X key is pressed");
            // Stop the event associated with 'X'
            if (stopEventX != null)
            {
                stopEventX.Stop(gameObject);
            }

            // Play the event associated with 'X'
            if (playEventX != null)
            {
                playEventX.Post(gameObject);
            }
        }
    }
}
