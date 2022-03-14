using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centerball : MonoBehaviour {
    private LineRenderer Line;   //申明一个私有的LineRenderer
	void Start () {
        //初始化为Line赋值
            Line = this.GetComponent<LineRenderer>();
	}
	void Update () {
        //LineRenderer组件有个SetPosition，默认0的位置是0，0，0、所以我们只要设置1的位置就是本身，两点连成线
        Line.SetPosition(1, transform.position);
	}
}
