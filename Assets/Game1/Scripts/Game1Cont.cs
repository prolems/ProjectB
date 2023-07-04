using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Game1Cont : MonoBehaviour
{
    [SerializeField] private TMP_Text txt;
    [SerializeField] private Player p;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Transform boss;
    [SerializeField] private GameObject endColl; // �̿ϼ�
    string[] strs = { "��","��","ȭ","��","��","��","��","��","��","��"};

    string curStr;
    int strIndex = 0;
    float curTimer;
    float strDelayTime = 0f;
    int waitTimer;

    bool isStart = false;
    public bool isStop = false;
    public Vector3 pPos;
    
    void Start()
    {
        waitTimer = 5;
        WaitTime();
        InvokeRepeating("WaitTime", 1f, 1f); //1�ʵڿ� 1�ʸ��� �ݺ�����   

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"����{isStart}");
        Debug.Log($"�÷��̾�{p.isStart}");

        if (!isStart)
            return;

       else if (isStart)
        {
            curTimer += Time.deltaTime;
            if (curTimer >= strDelayTime)
            {
                curTimer = 0;
                curStr = strs[strIndex];
                txt.color = Color.black;
                txt.text = curStr;
                strIndex++;


                if (strIndex >= strs.Length)
                {
                    isStop = true;
                    strDelayTime = Random.Range(1f, 3f);
                    boss.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0));
                    strIndex = 0;
                    pPos = p.transform.position;
                }
                else
                {
                    strDelayTime = Random.Range(0.1f, 0.5f);
                    isStop = false;
                    boss.rotation = Quaternion.Euler(Vector3.zero);
                }
            }
            if (isStop)
            {
                if ((int)pPos.z != (int)p.transform.position.z)
                {
                    PlayerKill();
                }
            }
            if (p.isFinish)
            {
                isStart = false;
                txt.color = Color.blue;
                txt.text = $"���";
            }
        }
           
    }
     

    void WaitTime()
    {
        txt.color = Color.black;
        txt.text = $"���ӽ���{waitTimer}�� ��...";
        waitTimer--;

        if (waitTimer < 0)
        {
            if (!p.isStart)
            {
                PlayerKill();
                isStart = false;
            }
            else
            {
                isStart = true;
            }
            CancelInvoke("WaitTime");
        }
    }
    void PlayerKill()
    {
        txt.color = Color.red;
        txt.text = "����";
        audioSource.Play();
        p.Dead();
      
    }
}
