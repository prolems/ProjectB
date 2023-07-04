using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game5Enemy : MonoBehaviour
{
    [SerializeField] private Player p;
    [SerializeField] private Game1Cont g;
    void Start()
    {
        
    }
    float firedelay =0;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(p.transform);
        if (g.isStop)
        {
            Vector3 lookPos = g.pPos;
            if ((int)lookPos.z != (int)p.transform.position.z)
            {
                GetComponent<Animator>().SetTrigger("atk");
            }
        }
    }

    
}
