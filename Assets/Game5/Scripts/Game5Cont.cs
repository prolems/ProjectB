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
    [SerializeField] private Button reBttn;
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

        Instance = this; // �ڱ��ڽ��� ����
        InvokeRepeating("Count",0, 1);
        mainBttn.transform.GetChild(0).GetComponent<TMP_Text>().text = "��������";
    }

    void Update()
    {
        if (state == State.Stop)
        {
            mainBttn.gameObject.SetActive(true);
            reBttn.gameObject.SetActive(true);

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
        countTxt.color = Color.black;
        countTxt.text = count.ToString();
        count--;
        if(count < -1)
        {
            countTxt.text = string.Empty;
            CancelInvoke("Count");
        }
        else if(count < 0)
        {
            countTxt.color = Color.green;
            countTxt.text ="����";
            state = State.Play;
            mainBttn.gameObject.SetActive(false);
            reBttn.gameObject.SetActive(false);
        }
    }
    public void OnClickMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnClickRe()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
