using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainsController : MonoBehaviour
{
    [SerializeField] Trains trains;
    [SerializeField] Transform plain;
    float train_ranSpeed = 0;
    int train_count = 0;
    int train_nextCount = 1;
    void Start()
    {
        train_ranSpeed = Random.Range(5, 7);
        InvokeRepeating("SpawnTrains", train_ranSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTrains()
    {
        Instantiate(trains, plain);
        train_count++;
        if (train_count >= train_nextCount)
        {
            train_count = 0;
            train_ranSpeed = Random.Range(5, 7);
            CancelInvoke();
            InvokeRepeating("SpawnTrains", train_ranSpeed, 0);
        }
    }
}
