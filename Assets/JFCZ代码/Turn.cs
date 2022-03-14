using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {
    public int Velocity = 1,centerState=1; //旋转速度， 1为顺时针,2为逆时针
    public bool Swtich = true;             //旋转的开关
    float times;                           //计算时间用的变量，这个在项目全部完成之后再加
    void Update () {
        //这个再项目全部完成之后再加，这个是改变旋转的方向的，增加游戏难度
        times += Time.deltaTime;
        if (times > 2)
        {
            centerState = Random.Range(1, 3);
            times = 0;
        }

        //当Switch等于True的时候，如果centerState等于1，那就顺时针旋转，等于2的时候就逆时针旋转
        if (Swtich)
        {
            if (centerState == 1)
            {
                transform.Rotate(0, 0, -Velocity * Time.deltaTime);
            }
            else if (centerState == 2)
            {
                transform.Rotate(0, 0, Velocity * Time.deltaTime);
            }

        }
    }

    //游戏没结束运行的方法
    public void OnPlay()
    {
        Swtich = true;
    }
    //游戏结束需要的方法，这样就不会旋转了
    public void OnStop()
    {
        Swtich=false;
    }
}
