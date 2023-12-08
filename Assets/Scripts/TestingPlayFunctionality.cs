using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingPlayFunctionality : MonoBehaviour
{
    public AK.Wwise.Event TestCall_B_Toning;
    public AK.Wwise.Event TestCall_B_Silent;

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Debug.Log("Playing TestCall_B_Toning");
            TestCall_B_Toning.Post(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            Debug.Log("Playing TestCall_B_Silent");
            TestCall_B_Silent.Post(gameObject);
        }
    }
}
