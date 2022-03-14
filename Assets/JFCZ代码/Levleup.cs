using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levleup : MonoBehaviour {
    public int level = 1;                 //关卡等级
    public GameObject[] LevelObject;      //关卡开始时需要加载的物体（预制体）
    private Text CenterText;              //中心点显示的关卡书UI-Text
	// Use this for initialization
	void Start () {
        level = PlayerPrefs.GetInt("X",1);                               //获取key为X的值
        CenterText = GameObject.Find("T100").GetComponent<Text>();     //在场景中找到名为“T100”并获取身上的Text组件，然后赋值给CenterText
        CenterText.text = level.ToString();                            //CenterTexr显示的内容等于level
        GameObject levelprefab = Instantiate(LevelObject[level-1])as GameObject;   //在一开始生成预制体，数组下标从0开始  所以需要减1
        levelprefab.transform.parent = GameObject.Find("Center").transform;         //设置生成预制物体的父物体等于场景中名为“Center”
    }
    /// <summary>
    /// 当前关卡赢得游戏之后
    /// </summary>
    public void OnWin()
    {
        //当关卡为3的时候，就设置X的值为1，这样就可以重复游戏了，当关卡树不等于3的时候，level就自加并设置X的值等于level，不管是哪种都需要加载场景
        if(level==3)
        {
            PlayerPrefs.SetInt("X", 1);
            SceneManager.LoadScene(0);
        }
        else
        {
            level++;
            PlayerPrefs.SetInt("X", level);
            SceneManager.LoadScene(0);
        }
    }
}
