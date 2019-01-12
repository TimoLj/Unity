using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API07Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Attack", 3);  // 类似于一次性定时器啊
        InvokeRepeating("Attack", 4, 2);    // 类似于循环定时器 4 为第一次执行延迟时间 2 为循环间隔
        //CancelInvoke("Attack");   // 取消循环
    }

    // Update is called once per frame
    void Update()
    {
        bool res = IsInvoking("Attack");    // 判断函数是否在等待调用
        print(res);
    }

    void Attack()
    {
        print("攻击目标");
    }
}
