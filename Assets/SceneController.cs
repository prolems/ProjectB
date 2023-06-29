using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
    void Awake()
    {
        if (Instance == null) // 중복방지 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬변경이 있어도 삭제되지않는다
        }
    }
    private void Start()
    {
    
    }

    public void OnSceneChange(string str)
    {
        SceneManager.LoadScene(str); // 버튼눌렀을때 씬변경 , addactive
        //ceneManager.LoadSceneAsync 로딩화면 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            OnSceneChange("Main");
        }
    }
}
