using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
    void Awake()
    {
        if (Instance == null) // �ߺ����� 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �������� �־ ���������ʴ´�
        }
    }
    private void Start()
    {
    
    }

    public void OnSceneChange(string str)
    {
        SceneManager.LoadScene(str); // ��ư�������� ������ , addactive
        //ceneManager.LoadSceneAsync �ε�ȭ�� 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            OnSceneChange("Main");
        }
    }
}
