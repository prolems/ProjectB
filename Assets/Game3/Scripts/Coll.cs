using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coll : MonoBehaviour
{
  

    private void Start()
    {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Game3Controller.Instance.Setstate = Game3Controller.State.Stop;
            Game3Controller.Instance.SetResult = Game3Controller.Result.Win;
        }
    }

}
