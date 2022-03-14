using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shengcheng : MonoBehaviour {
    public GameObject ball;
    public int number = 20;
    public bool numSwitch = true;


    void Update() {
        if ( number> 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject Bullet = Instantiate(ball) as GameObject;
                number--;

            }
            else
            {
                if (numSwitch)
                {
                    Invoke("Onwinwin", 1.5f);
                    numSwitch = false;
                }
            }
            for(int i = 1; i <= 3; i++)
            {
                GameObject.Find("T" + i).GetComponent<Text>().text = (number - i + 1).ToString();
            }
            if (number <= 2)
            {
                if (GameObject.Find("ball"))
                {

                }
            }
        }


    }
    void onwinwin()
    {
        print("win");
    }
}
