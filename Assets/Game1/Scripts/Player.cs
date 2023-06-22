using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool isStart = false;
    [HideInInspector] public bool isFinish = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "EndLine")
        {

        }
        if(other.name == "EndBox")
        {
            isFinish = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
            if(other.name == "StartLine")
        {
            isStart = true;
        }
    }
    public void Dead()
    {
        GetComponent<Animator>().SetTrigger("Wave");

    }
    public void DeadEvent()
    {

    }
}
