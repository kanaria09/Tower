using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    Rigidbody rigid;
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //控制旋转，射线检测
        //鼠标射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //检测结果
        RaycastHit hitInfo;
        //如果碰撞到了
        if (Physics.Raycast(ray, out hitInfo, 200))
        {
            transform.LookAt(new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z));
            Debug.Log("Click " + hitInfo.collider.gameObject.name);
            // 绘制点击点
            Debug.DrawRay(hitInfo.point, hitInfo.normal * 5, Color.green, 20, false);
        }
    }
}
