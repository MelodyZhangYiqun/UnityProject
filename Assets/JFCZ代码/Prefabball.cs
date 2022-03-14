using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prefabball : MonoBehaviour {
    public GameObject ball;        //声明一个GameObject类型的ball
    public int number=20;          //生成球体的数量为20个
    public bool numSwitch=true;    //开关，防止多次加载场景
	void Update () {
        //当number大于0的时候，按下左键生成一个小球并且number减减  当else的时候就表示过关了，延迟1.5秒执行OnWinWin方法
        if (number > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject Bullet = Instantiate(ball) as GameObject;
                number--;
            }
        }else
        {
            if (numSwitch)
            {
                Invoke("OnWinWin", 1.5f);
                numSwitch = false;
            }
            
        }
        //遍历场景中的三个预制球体T1、2、3,并更新他们Text的内容，这个先不写
        for(int i = 1; i <= 3; i++)
        {
            GameObject.Find("T"+i).GetComponent<Text>().text = (number-i+1).ToString();
        }

        if (number <= 2)
        {
            if(GameObject.Find("Ball" + number))
            {
                GameObject.Find("Ball" + number).SetActive(false);
            } 
        }
    }

    void OnWinWin()
    {
        transform.GetComponent<Levleup>().OnWin();
    }
}
