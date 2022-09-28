using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button Button;
    public GameObject g;
    void Start()
    {
        GameObject g1 = GameObject.Find("Aparment_Door");//通过名称获取物体
        GameObject g2 = GameObject.FindWithTag("Untagged");//通过标签获取物体
        GameObject g3 = GameObject.Find("Canvas/DoorTxt");//通过路径获取物体
        GameObject g4 = GameObject.Find("Key").GetComponentInChildren<KeyController>();//获取Key物体下的KeyController组件
        GameObject g5 = g1.transform.GetChild(0).gameObject;//获取Aparment_Door下的第一个子对象
        GameObject g6 = g1.transform.FindChild("SimpleDoor_DoorFrame_LOD0").gameObject;//获取Aparment_Door下名称为SimpleDoor_DoorFrame_LOD0的子对象
        GameObject.FindObjectOfType<Camera>();// 获取游戏场景内单个组件
        //获取游戏场景内所有组件
        foreach (var item in GameObject.FindObjectsOfType<Camera>()){
        }
        //获取所有子对象中的组件
        foreach (var item in go.GetComponentsInChildren<Camera>()){
        }
        //获取父对象中的组件
        foreach (var item in go.GetComponentsInParent<Camera>()){
        }
        this.GetComponent<Text>();//this:当前脚本所依附的对象
        g.transform.Find("Button");//通过路径查找对象，button为当前对象子节点
        g.transform.parent.Find("Button");//parent获取父物体
        g.GetComponent<Button>();//获取Button组件
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
