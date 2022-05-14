using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
       Vector3 pos = new Vector3(4f,-1.732f,5.3f);
       transform.position = pos;

       //transform.Translate(Vector3.right * Time.deltaTime * speed);
    
    }
}
