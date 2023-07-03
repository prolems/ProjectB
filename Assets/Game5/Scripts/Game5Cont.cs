using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game5Cont : MonoBehaviour
{
    public static Game5Cont Instance;
    public enum State
    {
        Play,
        Stop,
    }
    [SerializeField] Transform line;
    [SerializeField] private TMP_Text countTxt;
    [SerializeField] private Button mainBttn;
    private float power = 3;
    private State state = State.Stop;
    private int count = 3;

    public State SetState
    {
        set
        {
            state = value;
        }
    }
    void Start()
    {
        Instance = this; // 자기자신을 접근
        InvokeRepeating("Count", 1f, 1f);
    }

    void Update()
    {
        if (state == State.Stop)
            return;
        
            line.Translate(Vector3.right * Time.deltaTime * power);
            if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3 pos = line.localPosition;
                pos.x -= 1.5f;
                line.localPosition = pos;
            }
        
       
    }
    void Count()
    {
        countTxt.text = count.ToString();
        count--;
        if(count < 0)
        {
            countTxt.text = string.Empty;
            state = State.Play;
            CancelInvoke("Count");
        }
    }
    public void OnclickMaion()
    {
        SceneManager.LoadScene("Main");
    }
}
