using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator RotateCoroutine()
    {
        for (float i = 90; i < 180; i += rotation)
        {
            transform.rotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }
    

}