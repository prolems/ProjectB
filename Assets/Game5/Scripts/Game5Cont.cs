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
        mainBttn.transform.GetChild(0).GetComponent<TMP_Text>().text = "메인으로";
    }

    void Update()
    {
        if (state == State.Stop)
        {
            mainBttn.gameObject.SetActive(true);
            return;
        }
        else
        {
            line.Translate(Vector3.right * Time.deltaTime * power);
            if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3 pos = line.localPosition;
                pos.x -= 1.5f;
                line.localPosition = pos;
            }
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
            mainBttn.gameObject.SetActive(false);
            CancelInvoke("Count");
        }
    }
    public void OnClickMain()
    {
        SceneManager.LoadScene("Main");
    }
}
