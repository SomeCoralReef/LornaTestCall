using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingPlayFunctionality : MonoBehaviour
{
    public AK.Wwise.Event TestCall_B_Toning;
    public AK.Wwise.Event TestCall_B_Silent;
    public AK.Wwise.Event Play_vo_jaya_repair1Ahhh;
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
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            Debug.Log("Playing Play_vo_jaya_repair1Ahhh");
            Play_vo_jaya_repair1Ahhh.Post(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.Alpha0)){
            Debug.Log("Stopping All");
            AkSoundEngine.StopAll();
        }
    }
}
