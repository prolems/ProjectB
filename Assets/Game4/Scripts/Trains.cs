using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trains : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 40);

        if (gameObject.transform.localPosition.x < -2.5f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
