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
        if (other.GetComponent<Wood>())
        {
            other.GetComponent<CapsuleCollider>().isTrigger = false;
            Vector3 vec = transform.position;
            vec.x -= 1;
            transform.position = vec;
            Destroy(other.GetComponent<CapsuleCollider>());
            
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
        GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 0;
        GetComponent<Animator>().SetTrigger("Wave");

    }
    public void SitDown()
    {
        GetComponent<CapsuleCollider>().center = new Vector3(0, 0.25f, 0);
        GetComponent<CapsuleCollider>().height = 0.5f;
    }
    public void StandUP()
    {
        GetComponent<CapsuleCollider>().height = 1f;
        GetComponent<CapsuleCollider>().center = new Vector3(0, 0.5f, 0);
    }
}
