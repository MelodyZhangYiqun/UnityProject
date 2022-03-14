using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Up : MonoBehaviour {
    public int Velocity = 1;            //发射小球的速度
    public bool ZTSwitch = true;        //开关，当等于Ture的时候小球能运动，等于False的时候小球停下，详见Update中的方法
    private GameObject Center;          //中心位置物体
    private LineRenderer Line;          //声明私有的LineRenderer
    public GameObject musicObj;         //获取音乐播放物体，用于获取其身上的脚本

    void Start () {
        //初始化赋值
        Center = GameObject.Find("Center");
        Line = this.GetComponent<LineRenderer>();
        musicObj = GameObject.Find("Music");
    }
	
	void Update () {
        //当开关等于true，物体开始沿着Y轴移动，当物体的Y轴到了一定的位置就固定物体的位置，物体的Transform的父物体等于中心，同时播放音效开关为false
        //当开关等于false的时候就开始执行else
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
        }else
        {
            Line.SetPosition(1, transform.position);
        }
	}
    //每个小球都添加一个触碰的方法，当触碰的物体的标签等于Ball的时候，就播放音乐，同时停止中心点旋转并延迟0.5秒执行OnOver方法
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            musicObj.GetComponent<Music>().MusicPlay2();
            Center.GetComponent<Turn>().OnStop();
            Invoke("OnOver", .5f);
        }
    }
    //重新加载当前场景
    void OnOver()
    {
        SceneManager.LoadScene(0);
    }
}
