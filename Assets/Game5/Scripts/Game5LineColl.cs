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
            result.text = "½Â¸®";
        }
        else if(other.name == "Lose")
        {
            // È¥ÀÚ¸¸ ¾µ¶§ LogError
            Game5Cont.Instance.SetState = Game5Cont.State.Stop;
            result.color = Color.red;
            result.text = "ÆÐ¹è";
        }
    }
}
