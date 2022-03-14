using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int Velocity = 1, centerState = 1;
    public bool Switch = true;
	void Update () {
        if (Switch){
                if (centerState == 1)
        {
            transform.Rotate(0, 0, -Velocity * Time.deltaTime);
        }else if (centerState == 2){
            transform.Rotate(0, 0, Velocity * Time.deltaTime);

        }
            }
		
	}
    public void OnPlay()
    {
        Switch = true;

    }
    public void OnStop()
    {
        Switch = false;
    }
}
