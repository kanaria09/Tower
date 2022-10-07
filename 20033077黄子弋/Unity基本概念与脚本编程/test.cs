using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Button Button;
    public GameObject i;
    void Start()
    {
        GameObject i1 = GameObject.Find("Aparment_Door");   
        GameObject i2 = GameObject.FindWithTag("Untagged");  
        GameObject i3 = GameObject.Find("Canvas/DoorTxt");  
        GameObject i4 = GameObject.Find("Key").GetComponentInChildren<KeyController>();   
        GameObject i5 = i1.transform.GetChild(0).gameObject;   
        GameObject i6 = i1.transform.FindChild("SimpleDoor_DoorFrame_LOD0").gameObject;
        GameObject.FindObjectOfType<Camera>();   
        //获取游戏场景内所有组件
        foreach (var item in GameObject.FindObjectsOfType<Camera>()){
        }
        //获取所有子对象中的组件
        foreach (var item in go.GetComponentsInChildren<Camera>()){
        }
        //获取父对象中的组件
        foreach (var item in go.GetComponentsInParent<Camera>()){
        }
        this.GetComponent<Text>();   
        i.transform.parent.Find("Button");  
        ii.GetComponent<Button>();   
    }
  
}
