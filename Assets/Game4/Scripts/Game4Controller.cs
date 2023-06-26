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
        int rand = Random.Range(0, 6);      // �� ���� 0~5�� ���� ����
        for (int i = 0; i < rand; i++)
        {
            carDelayTime = Random.Range(0, 1.5f); //�� �������� ����
            curTime += Time.deltaTime;
            if (curTime> carDelayTime) // 0~1.5�� ���� Ŀ����
            {
                curTime = 0;
                GameObject gObj = Instantiate(cars[Random.Range(0,cars.Count)], plain);
            }
        }

    }
}
