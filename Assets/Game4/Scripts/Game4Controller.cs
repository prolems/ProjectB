using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Controller : MonoBehaviour
{
    [SerializeField] List<GameObject> cars;
    [SerializeField] List<GameObject> trains;
    [SerializeField] Transform plain;

    //  int a = 조건(3<5) ? true(10) : false(100)
    // 조건 3개의 경우 조건? true: 조건(else if) ? true : false(else)
    void Start()
    {
        ranSpeed = 1;
        nextCount = 1;
        InvokeRepeating("SpawnCars", 1, ranSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ranSpeed);
    }

    float ranSpeed;
    int count;
    int nextCount;
    void SpawnCars()
    {
        count++;
        Instantiate(cars[Random.Range(0,cars.Count)], plain);
        ranSpeed = Random.Range(2.5f, 3.5f);
        if (count > nextCount)
        {
            count = 0;
            CancelInvoke();
            nextCount = Random.Range(3, 5);

        }
    }
}
