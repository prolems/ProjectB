using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Controller : MonoBehaviour
{
    [SerializeField] List<GameObject> cars;
    [SerializeField] List<GameObject> trains;
    [SerializeField] Transform plain;

    void Start()
    {
        int randRepeat = Random.Range(4, 8);
        InvokeRepeating("SpawnCars()",1f, randRepeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float curTime = 0f;
    float carDelayTime;
    void SpawnCars()
    {
        int rand = Random.Range(0, 6);      // 차 갯수 0~5개 랜덤 생성
        for (int i = 0; i < rand; i++)
        {
            carDelayTime = Random.Range(0, 1.5f); //차 생성간격 랜덤
            curTime += Time.deltaTime;
            if (curTime> carDelayTime) // 0~1.5초 보다 커지면
            {
                curTime = 0;
                GameObject gObj = Instantiate(cars[Random.Range(0,cars.Count)], plain);
            }
        }

    }
}
