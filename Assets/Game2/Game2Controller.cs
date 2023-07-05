using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Controller : MonoBehaviour
{
    [SerializeField] List<Wood> trans;
    [SerializeField] SimpleSampleCharacterControl p;
 
    
    float speedCount= 1.5f;

    int nextCount = 3;
    int count = 0;
    float speed = 1f;

    void Start()
    {
        InvokeRepeating("SpawnWood",0f, speed);
        p.m_moveSpeed = 0;
        
    }
    private void Update()
    {
      
    }
    float fir = 0.6f;
    float sec = 0.7f;
    void SpawnWood()
    {
       Wood wood =  Instantiate(trans[Random.Range(0, trans.Count)], transform); // top or btm 둘중하나 생성
        wood.speed = speedCount;
        count++;
        if(count  >= nextCount)
        {
            count = 0;
            speedCount += 0.11f;
            nextCount = Random.Range(3, 6);
            speed = Random.Range(fir,sec);
            fir -= 0.02f;
            sec -= 0.02f;

            Debug.Log($"{nextCount}개 {speed}초");
            CancelInvoke("SpawnWood");
            InvokeRepeating("SpawnWood",2 , speed);
        }
      
    }
}
