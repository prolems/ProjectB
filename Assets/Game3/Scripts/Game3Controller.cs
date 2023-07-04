using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game3Controller : MonoBehaviour
{
    public static Game3Controller Instance;
    public enum State
    {
        Stop,
        Play,
    }
    private State state;
    public State Setstate
    {
        set
        {
            state = value;
        }
    }
    public enum Result
    {

        Win,
        Lose,
        Default,
    }
    private Result result;
    public Result SetResult
    {
        set
        {
            result = value;
        }
    }

    [SerializeField] TMP_Text countTxt;
    [SerializeField] TMP_Text mainTxt;
    [SerializeField] Button mainBttn;
    [SerializeField] TMP_Text reTxt;
    [SerializeField] Button reBttn;
    //=================
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] Transform maps;
    [SerializeField] Transform parent;
    [SerializeField] List<GameObject> blocks;
    [SerializeField] GameObject startLine;
   
    void Start()
    {
        Instance = this;
        InstantBlock();
        state = State.Stop;
        result = Result.Default;
        InvokeRepeating("Count", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Play)
        {
            startLine.gameObject.SetActive(false);
            mainBttn.gameObject.SetActive(false);
            reBttn.gameObject.SetActive(false);
        }
        else if (state == State.Stop)
        {
            startLine.gameObject.SetActive(true);
            mainBttn.gameObject.SetActive(true);
            mainTxt.text = "��������";
            reBttn.gameObject.SetActive(true);
            reTxt.text = "�ٽ��ϱ�";
            if (result == Result.Default)
                return;
            else if (result == Result.Win)
            {
                countTxt.text = "�¸�";
            }
            else if(result == Result.Lose)
            {
                countTxt.text = "�й�";
            }
        }
        
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnClickMain()
    {
        SceneManager.LoadScene("Main");
    }
    int count = 3;
    void Count()
    {
        countTxt.text = count.ToString();
        count--;
        if (count < 0)
        {
            state = State.Play;
            countTxt.text = string.Empty;
            CancelInvoke("Count");
        }
    }
    void InstantBlock()
    {
        for (int b = 0; b < 14; b += 2)   //�ֵ�Ⱥ�ϰ�����ŭ(��14��)
        {
            for (int j = 0; j < prefabs.Count; j++)
            {
                GameObject myInstance = Instantiate(prefabs[j], maps);  //���ٿ� �ΰ� ����
                blocks.Add(myInstance);         // �������Ʈ�� �ΰ��ֵ�
            }
                Vector3 vec = blocks[b].transform.localPosition;
                Vector3 vecc = blocks[b+1].transform.localPosition;
            bool rand = Random.value > 0.5f;
            vec = blocks[b].transform.localPosition;
            vecc = blocks[b + 1].transform.localPosition;
            Debug.Log(rand);
            if (rand)
            {
                vec.x += 1;
                vecc.x -= 1;
            }
                vec.z +=b;
                vecc.z+=b;
            blocks[b].transform.localPosition = vec;
                blocks[b+1].transform.localPosition = vecc;
        }
    }
    public void SwitchTrans(Vector3 vec, Vector3 vecc, int b)
    {
        bool rand = Random.value > 0.5f;
        vec = blocks[b].transform.localPosition;
        vecc = blocks[b + 1].transform.localPosition;
        Debug.Log(rand);
        if (rand)
        {
            vec.x += 1;
            vecc.x -= 1;       
        }
    }      
}          
