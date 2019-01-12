using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API08Coroutinel : MonoBehaviour
{

    public GameObject cube;

    void Start()
    {
        //print("haha");
        ////changeColor();
        //StartCoroutine(changeColor());
        //// 协程方法开启后, 会继续运行下面的代码, 不会等协程方法运行结束才继续执行
        //print("emmmm");
    }

    private IEnumerator ie;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ie = Fade();
            StartCoroutine("Fade"); // 开启协程
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine("Fade");
        }

    }

    IEnumerator Fade()
    {
        //for(float i = 0; i <= 1; i += 0.1f)
        for(; ; )
        {
            //cube.GetComponent<MeshRenderer>().material.color = new Color(i, i, i, i);
            Color color = cube.GetComponent<MeshRenderer>().material.color;
            Color newColor = Color.Lerp(color, Color.red, 0.02f);
            cube.GetComponent<MeshRenderer>().material.color = newColor;
            yield return new WaitForSeconds(0.02f);
            if(Mathf.Abs(Color.red.g-newColor.g) <= 0.01f)
            {
                break;
            }
        }
    }


    // Corontines
    // 1 返回值是IEnumerator 
    // 2 返回参数的时候使用yield return
    // 3 协程方法的调用StartCoroutine(function())
    IEnumerator changeColor()
    {
        print("hhhh");
        yield return new WaitForSeconds(3); // 执行完上一部分代码 等待3秒 执行下面内容
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        print("mmmmm");
        yield return null;
    }
}
