using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shang: MonoBehaviour {
    public int Velocity = 1;
    public bool ZTSwitch = true;
    private GameObject Center;
    private LineRenderer Line;
    public GameObject musicObj;
	void Start () {
        Center = GameObject.Find("Center");
        Line = this.GetComponent<LineRenderer>();
		
	}
	void Update () {
        if (ZTSwitch)
        {
            transform.Translate(0, Velocity * Time.deltaTime, 0);
            if (transform.position.y >= -2.5f)
            {
                transform.position = new Vector3(0, -2.5f, 0);
                transform.parent = Center.transform;
                musicObj.GetComponent<Music>().MusicPlay1();
                ZTSwitch = false;
            }
        }
        else
        {
            Line.SetPosition(1, transform.position);
        }
    }
}
