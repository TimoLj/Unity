using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = cube.position.x;
        Mathf.Lerp(x, 10, 0.1f);
    }
}
