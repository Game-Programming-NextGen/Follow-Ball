using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aerialcam : MonoBehaviour
{
   public Transform target;
   public float height = 12;
   public float distance = 8;
   public float angle = 50;
   public float smoothness = 0.6f;
   public Vector3 referenceVelocity;

   void Start()
   {
     target = GameObject.FindGameObjectWithTag("Player").transform;
     aCam();


   }

   void aCam ()
   {
     if (!target)
     return;

     Vector3 worldPos = (Vector3.forward * -distance) + (Vector3.up * height);
     Vector3 angleVector = Quaternion.AngleAxis(angle,Vector3.up) * worldPos;
     Vector3 flatPos = target.position;
     flatPos.y = 0;
     Vector3 finalPos = flatPos + angleVector;

     transform.position = Vector3.SmoothDamp(transform.position, finalPos, ref referenceVelocity,smoothness);
     transform.LookAt(flatPos);
   }

   private void Update(){
       aCam();
   }

}
