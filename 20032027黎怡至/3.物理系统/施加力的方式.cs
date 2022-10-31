using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody rigid;
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        // 获取刚体组件
        rigid = GetComponent<Rigidbody>();
        // 设置重心
        rigid.centerOfMass = new Vector3(0.5f, 1, 0.5f);
        Debug.Log("Center of Mass : " + rigid.centerOfMass.ToString());
        Debug.Log("FixedUpdate delta time : " + Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update delta time : " + Time.deltaTime);
        // 让小球旋转
        if (Input.GetKeyDown(KeyCode.R))
        {
            rigid.angularVelocity = new Vector3(0, 60, 0);
        }
        // 施加的力高于重心
        if (Input.GetKeyDown(KeyCode.H))
        {
            rigid.AddForceAtPosition(new Vector3(0, 0, -10), new Vector3(0.5f, 1.5f, 0.5f));
        }

        // 施加的力等于重心
        if (Input.GetKeyDown(KeyCode.E))
        {
            rigid.AddForceAtPosition(new Vector3(-10, 0, 0), new Vector3(0.5f, 1f, 0.5f));
        }

        // 施加的力低于重心
        if (Input.GetKeyDown(KeyCode.L))
        {
            rigid.AddForceAtPosition(new Vector3(0, 0, -10), new Vector3(0.5f, 0.5f, 0.5f));
        }

    }
}
