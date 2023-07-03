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
            Debug.Log("½Â¸®");
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.text = "½Â¸®!";
        }
        else if(other.name == "Lose")
        {
            // È¥ÀÚ¸¸ ¾µ¶§ LogError
            Debug.Log("ÆÐ¹è");
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.text = "ÆÐ¹è!";
        }
    }
}
