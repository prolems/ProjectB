using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    [SerializeField] Button mainBttn;
    [SerializeField] Button reBttn;
    public void OnClickMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnClickRe()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
