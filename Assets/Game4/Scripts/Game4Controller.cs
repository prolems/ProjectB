using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Game4Controller : MonoBehaviour
{
    [SerializeField] Button mainBttn;
    [SerializeField] TMP_Text txt;
    void Start()
    {
        txt.text = "메인으로";
    }
  
    public void OnClickMain()
    {
        SceneManager.LoadScene("Main");
    }
}
