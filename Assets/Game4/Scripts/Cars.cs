using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float carSpeed;
    void Update()
    {
        //x -
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * carSpeed);
    }
}
