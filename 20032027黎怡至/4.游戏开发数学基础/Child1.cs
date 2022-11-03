using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
        //获取它的世界坐标（全局坐标）
        Debug.Log("世界坐标的位置：" + transform.position);
        Debug.Log("世界坐标的旋转：" + transform.rotation);

        //获取它的局部坐标
        Debug.Log("局部坐标的位置：" + transform.localPosition);
        Debug.Log("局部坐标的旋转：" + transform.localRotation);

        Debug.Log("Transform up：" + transform.up);
        Debug.Log("Transform up magnitude：" + transform.up.magnitude);
        Debug.Log("Transform forward：" + transform.forward);
        Debug.Log("Transform forward magnitude：" + transform.forward.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("沿着世界坐标的上方移动===================");
            Debug.Log("世界坐标的位置：" + transform.position);
            // 沿着世界坐标的上方移动一米
            transform.position += Vector3.up;
            Debug.Log("世界坐标的位置：" + transform.position);
            transform.Translate(Vector3.up, Space.World);
            Debug.Log("世界坐标的位置：" + transform.position);
            //Vector3 worldUp = transform.InverseTransformPosition(Vector3.up);
            //transform.Translate(worldUp, Space.Self);
            Debug.Log("世界坐标的位置：" + transform.position);

            Debug.Log("沿着局部坐标上方移动===================");
            // 沿局部坐标上方移动一米
            Debug.Log("局部坐标的位置：" + transform.localPosition);
            transform.localPosition += Vector3.up;
            Debug.Log("局部坐标的位置：" + transform.localPosition);

            Debug.Log("沿着自身坐标的上方移动===================");
            // 沿着自身坐标的上方移动一米
            Debug.Log("世界坐标的位置：" + transform.position);
            Debug.Log("局部坐标的位置：" + transform.localPosition);
            transform.Translate(Vector3.up, Space.Self);
            Debug.Log("世界坐标的位置：" + transform.position);
            Debug.Log("局部坐标的位置：" + transform.localPosition);
            transform.position += transform.up;
            Debug.Log("世界坐标的位置：" + transform.position);
            Debug.Log("局部坐标的位置：" + transform.localPosition);

            Debug.Log("有问题的移动===================");
            // 沿着自身坐标的上方移动一米
            Debug.Log("世界坐标的位置：" + transform.position);
            Debug.Log("局部坐标的位置：" + transform.localPosition);
            transform.Translate(transform.up, Space.Self);
            Debug.Log("世界坐标的位置：" + transform.position);
            Debug.Log("局部坐标的位置：" + transform.localPosition);

        }

         // 按下鼠标左键
        if (Input.GetMouseButtonDown(0))
        {
            // 鼠标指针位置是屏幕坐标系
            Vector2 mousePos = Input.mousePosition;
            Debug.Log("鼠标指针在屏幕上的位置：" + mousePos);
                    
            // 将鼠标指针位置转化为视图坐标系时，需要利用摄像机计算
            Vector3 viewPoint = UnityEngine.Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("鼠标指针位置的视图坐标为：" + viewPoint);

            // 将鼠标指针位置转化为世界坐标系时，需要利用摄像机计算
            Vector3 worldPoint = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("鼠标指针位置的世界坐标为：" + worldPoint);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            // 向量的标准化，表示向量的方向
            Vector3 a = new Vector3(2, 1, 0);
            Vector3 an = a/a.magnitude; // 与1/a.magnitude进行数乘

            Debug.Log("向量：" + a);
            Debug.Log("向量的模：" + a.magnitude);
            Debug.Log("向量标准化后的模：" + an.magnitude);
            Debug.Log("向量标准化1：" + an);
            Debug.Log("向量标准化2：" + a.normalized);
            Debug.Log("向量标准化3：" + Vector3.Normalize(a));

        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // 利用向量的点积求投影距离
            Vector3 a = new Vector3(2, 1, 0);
            Vector3 b = new Vector3(3, 0, 0);

            float pab = Vector3.Dot(a, b.normalized);

            Debug.Log("向量a：" + a);
            Debug.Log("向量b：" + b);
            Debug.Log("向量a在向量b上的投影：" + pab);

        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // 利用向量的叉积求投法线, 法线垂直于平面，是平面的朝向
            Vector3 a = new Vector3(2, 1, 1);
            Vector3 b = new Vector3(3, 0, 2); 
            Vector3 n = Vector3.Cross(a, b);

            Debug.Log("向量a：" + a);
            Debug.Log("向量b：" + b);
            Debug.Log("向量a和向量b所在平面的法线（朝向）：" + n.normalized);
        }
 
        // 位置和向量
        if (Input.GetKeyDown(KeyCode.V))
        {
            //这是当前物体child坐标
            Vector3 childPos=transform.position;
            Debug.Log("Child的位置:" + childPos);
            //这是物体parent的坐标
            Vector3 parentPos=transform.parent.position;
            Debug.Log("Parent的位置:" + parentPos);

            // 坐标 - 坐标 = 向量
            //这是从当前物体Child到Parent的向量
            Vector3 diff=parentPos-childPos;
            Debug.Log("Child到Parent的向量:" + diff);

            // 坐标 + 向量 = 新坐标：沿向量方向移动向量大小得到新坐标
            //获得了一个新的坐标C，位于比parent远离当前物体child一倍的位置
            Vector3 p3=parentPos+diff;
            Debug.Log("比parent远离当前物体child一倍的位置:" + p3);

            // 坐标 + 向量 = 新坐标：
            //从Main Camera的位置出发，发生从child到parent的位移，得到新的坐标
            Vector3 p4 = UnityEngine.Camera.main.transform.position + diff;
            Debug.Log("Main Camera的位置出发，发生从child到parent的位移，得到新的坐标:" + p4);

            // 向量进行数乘，得到的是一个新的向量
            //调整向量的长度为一半
            Vector3 diffHalf=diff*0.5f;
        }

        // 向量坐标系转化
        if (Input.GetKeyDown(KeyCode.T))
        {
            // 向自身Z轴移动
            Debug.Log("Child world position1: " + transform.position);
            Debug.Log("Child local position1: " + transform.localPosition);
            transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
            Debug.Log("Child world position2: " + transform.position);
            Debug.Log("Child local position2: " + transform.localPosition);

            // 向世界坐标的Z轴移动
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
            Debug.Log("Child world position3: " + transform.position);
            Debug.Log("Child local position3: " + transform.localPosition);

            // 向世界坐标的Z轴移动
            // 将世界坐标系的Z轴转化成局部坐标系
            Vector3 worldForward = transform.InverseTransformDirection(Vector3.forward);
            transform.Translate(worldForward * Time.deltaTime, Space.Self);
            Debug.Log("Child world position3: " + transform.position);
            Debug.Log("Child local position3: " + transform.localPosition);
        }
    }
}
