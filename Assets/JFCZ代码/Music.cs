using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    public AudioClip music1,music2;   //声明两个声音片段
    private AudioSource MusicSource;  //声明一个音乐播放器
	void Start () {
        //初始化，为AudioSource赋值，getCompnent表示获取组件
        MusicSource = transform.GetComponent<AudioSource>();

    }
    //下面两个方法的作用是分别播放两个音效
    public void MusicPlay1()
    {
        MusicSource.clip = music1;
        MusicSource.Play();
    }

    public void MusicPlay2()
    {
        MusicSource.clip = music2;
        MusicSource.Play();
    }
}
