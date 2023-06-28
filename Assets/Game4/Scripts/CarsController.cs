using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsController : MonoBehaviour
{
    [SerializeField] List<Cars> cars;
    [SerializeField] Transform plain;
    //  int a = 조건(3<5) ? true(10) : false(100)
    // 조건 3개의 경우 조건? true: 조건(else if) ? true : false(else)
    float ranSpeed = 0;
    int count = 0;
    int nextCount = 1;
    float thatSpeed = 5f;
    void Start()
    {
        InvokeRepeating("SpawnCars", 0, 0);
    }

    void Update()
    {
        Debug.Log(ranSpeed);
    }

  
    void SpawnCars()
    {
        Cars newCars = Instantiate(cars[Random.Range(0,cars.Count)], plain);
        newCars.carSpeed = thatSpeed;
        //newCars.GetComponent<Cars>().carSpeed = thatSpeed;
        count++;
        if (count >= nextCount)
        {
            count = 0;
            ranSpeed = Random.Range(0.4f, 2);
            CancelInvoke();
            InvokeRepeating("SpawnCars", ranSpeed, 0);
        }
        thatSpeed += Random.Range(0.05f, 0.1f);
    }

   
}
