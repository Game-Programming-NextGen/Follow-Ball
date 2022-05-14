using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswitch : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera2;
    public float time = 5f;


    // Start is called before the first frame update
    void StartCoroutine()
    {
        MainCamera.SetActive(true);
        Camera2.SetActive(false);
       //StartCoroutine(SwitchCamera());
    }

    public IEnumerator SwitchCamera()
    {
        yield return new WaitForSeconds(time);
        MainCamera.SetActive(false);
        Camera2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("7")){
            CameraOne ();
        }

         if (Input.GetKeyDown("1")){
            CameraTwo ();
    }
}

    void CameraOne (){
        MainCamera.SetActive(true);
        Camera2.SetActive(false);
    }

     void CameraTwo (){
        MainCamera.SetActive(false);
        Camera2.SetActive(true);
    }
}
