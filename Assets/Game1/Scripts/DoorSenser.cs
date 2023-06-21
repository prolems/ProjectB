using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSenser : MonoBehaviour
{
    [SerializeField] GameObject doorAnchor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            OpenAnimation();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Invoke("CloseAnimation", 2f);
        }
    }

    public void OpenAnimation()
    {
        doorAnchor.gameObject.GetComponent<Animator>().SetBool("open", true);
        doorAnchor.gameObject.GetComponent<Animator>().SetBool("close", false);
    }
    public void CloseAnimation()
    {
        doorAnchor.gameObject.GetComponent<Animator>().SetBool("close", true);
        doorAnchor.gameObject.GetComponent<Animator>().SetBool("open", false);
    }

}
