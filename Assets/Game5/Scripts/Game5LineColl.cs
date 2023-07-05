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
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.color = Color.blue;
            result.text = "�¸�";
        }
        else if(other.name == "Lose")
        {
            // ȥ�ڸ� ���� LogError
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.color = Color.red;
            result.text = "�й�";
        }
    }
}
