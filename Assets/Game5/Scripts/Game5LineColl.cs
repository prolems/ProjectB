using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Game5LineColl : MonoBehaviour
{
    [SerializeField] private TMP_Text result;

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "Win")
        {
            Debug.Log("�¸�");
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.text = "�¸�!";
        }
        else if(other.name == "Lose")
        {
            // ȥ�ڸ� ���� LogError
            Debug.Log("�й�");
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.text = "�й�!";
        }
    }
}
