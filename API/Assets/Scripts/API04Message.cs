using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API04Message : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target.BroadcastMessage("Attack", null, SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
