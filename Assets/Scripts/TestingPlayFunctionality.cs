using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingPlayFunctionality : MonoBehaviour
{
    public AK.Wwise.Event TestCall_B_Toning;
    public AK.Wwise.Event TestCall_B_Silent;
    private bool TestCall_B_SilentPlaying = false;

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Debug.Log("Playing TestCall_B_Toning");
            TestCall_B_Toning.Post(gameObject);
            //TestCall_B_Silent.Stop(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            if(TestCall_B_SilentPlaying){
                Debug.Log("Stopping TestCall_B_Silent");
                TestCall_B_Silent.Stop(gameObject);
                TestCall_B_SilentPlaying = false;
            } else {
                Debug.Log("Playing TestCall_B_Silent");
                TestCall_B_Silent.Post(gameObject);
                TestCall_B_SilentPlaying = true;
            }
        }
    }
}
