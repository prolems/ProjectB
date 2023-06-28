using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Controller : MonoBehaviour
{
    [SerializeField] List<Wood> trans;
    [SerializeField] SimpleSampleCharacterControl p;
 
    
    float speedCount= 2f;

    int nextCOunt = 1;
    int count = 0;
    float speed = 5f;

    void Start()
    {
        InvokeRepeating("SpawnWood",0f, speed);
        p.m_moveSpeed = 0;
        
    }
    private void Update()
    {
        //Debug.Log($"{spawnSpeed}�ʻ���");
        Debug.Log($"{speedCount}������");
    }
    void SpawnWood()
    {
       Wood wood =  Instantiate(trans[Random.Range(0, trans.Count)], transform); // top or btm �����ϳ� ����
        wood.speed = speedCount;
        count++;
        if(count  >= nextCOunt)
        {
            count = 0;
            CancelInvoke("SpawnWood");
            nextCOunt = Random.Range(2, 6);
            speed--;
            InvokeRepeating("SpawnWood", 3f, speed);
        }
        speedCount += 0.22f;
      
    }
}
