using UnityEngine;

public class API03GameObject : MonoBehaviour
{
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        // 创建方法01
        //GameObject newObject1 =  new GameObject("Cube");

        // 创建方法02   根据prefab实例化
        // 根据另一个游戏物体
        //GameObject.Instantiate(prefab); // 可以根据prefab 或者 另一个游戏物体克隆

        // 创建方法03   创建原始的几何体
        //GameObject gameObject2 =  GameObject.CreatePrimitive(PrimitiveType.Cube);
        //gameObject2.AddComponent<Rigidbody>();  // 添加刚体
        ////gameObject2.AddComponent<API01EventFunc>(); // 添加脚本

        //Debug.Log(gameObject2.activeInHierarchy);
        //gameObject2.SetActive(false);
        //Debug.Log(gameObject2.activeInHierarchy);

        //Debug.Log(prefab.name);
        //Debug.Log(prefab.GetComponent<Transform>().name);

        //Light light = FindObjectOfType<Light>();
        //light.enabled = false;

        //Transform[] ts = FindObjectsOfType<Transform>();    // 不查找 未激活的游戏物体

        //foreach(Transform t in ts)
        //{
        //    Debug.Log(t);
        //}

        GameObject gos = GameObject.FindGameObjectWithTag("MainCamera");
        gos.SetActive(false);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
