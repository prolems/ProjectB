using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < 3)
        {
            GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 0;
        }
    }
}
