using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector] public bool isStart = false;
    [HideInInspector] public bool isFinish = false;
    [SerializeField] private Animator m_animator = null;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_animator.SetBool("crouch", true);
        }
       else if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_animator.SetBool("crouch", false);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "EndColl")
        {
            isFinish = true;
        }
        if (other.GetComponent<Wood>())
        {
            other.GetComponent<CapsuleCollider>().isTrigger = false;
            Vector3 vec = transform.position;
            vec.x -= 0.5f;
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
