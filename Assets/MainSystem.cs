using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
    [SerializeField] private GameObject sceneCont;
    void Start()
    {
     if(SceneController.Instance == null)
        {
            //Instantiate(sceneCont);
            Instantiate(sceneCont).name = "[Scene Controller]";
        }  
    }

    public void OnGameChange(string gameName)
    {
        SceneController.Instance.OnSceneChange(gameName);
    }
      
}
