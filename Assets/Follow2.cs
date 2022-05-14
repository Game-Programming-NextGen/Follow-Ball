using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2 : MonoBehaviour
{
   public GameObject Ball;
   public Vector3 offset = new Vector3(-11f,6f,-23f);

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + offset;
    }
}
