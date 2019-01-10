using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API02Time : MonoBehaviour
{
    public Transform cube;
    public int runCount = 10000;

    // Start is called before the first frame update
    void Start()
    {
        float time1 = Time.realtimeSinceStartup;
        for (int i = 0; i < runCount; i++)
        {
            fun1();
        }
        float time2 = Time.realtimeSinceStartup;
        Debug.Log(time2-time1);


        float time3 = Time.realtimeSinceStartup;
        for(int i = 0; i < runCount; i++)
        {
            fun2();
        }
        float time4 = Time.realtimeSinceStartup;
        Debug.Log(time4 - time3);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Time.deltTime:" + Time.deltaTime);   // 每一帧的时间间隔
        //Debug.Log("Time.fixedDeltaTimeL:" + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime:" + Time.fixedTime);
        //Debug.Log("Time.frameCount:" + Time.frameCount);    // 帧数
        //Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);    // 游戏开始到现在运行的时间,包括暂停 后台运行
        //Debug.Log("Time.somoothDeltaTime" + Time.smoothDeltaTime);
        //Debug.Log("Time.time:" + Time.time);    // 游戏运行占用的时间
        //Debug.Log("Time.timeScale:" + Time.timeScale);  // 用来设置游戏运行比例
        //Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledTime:" + Time.unscaledTime);
        cube.Translate(Vector3.forward * Time.deltaTime * 3);
    }

    void fun1()
    {
        int i = 1 + 2;
    }

    void fun2()
    {
        int i = 1 * 2;
    }
}
