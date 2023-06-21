using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Game5Controller: MonoBehaviour
{
    [SerializeField] private TMP_Text txt;
    [SerializeField] private Player p;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Transform boss;
    string[] strs = { "��","��","ȭ","��","��","��","��","��","��","��"};

    string curStr;
    int strIndex = 0;
    float curTimer;
    float strDelayTime = 0f;
    int waitTimer = 5;

    bool isStart = false;
    bool isStop = false;
    Vector3 pPos;
    
    void Start()
    {
        WaitTime();
        InvokeRepeating("WaitTime", 1f, 1f); //1�ʵڿ� 1�ʸ��� �ݺ�����   

    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
            return;
            curTimer += Time.deltaTime;
        if (curTimer >= strDelayTime)
        {
            curTimer = 0;
            curStr = strs[strIndex];
            txt.text = curStr;
            strIndex++;


            if (strIndex >= strs.Length)
            {
                strDelayTime = Random.Range(1f, 3f);
                isStop = true;
                boss.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0));
                curTimer = 0;
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
            txt.text = $"���";
        }
    }
     

    void WaitTime()
    {
        txt.text = $"���ӽ��� ���{waitTimer}�� ��...";
        waitTimer--;

        if (waitTimer <0)
        {
            isStart = true;
            CancelInvoke();

            if (!p.isStart)
            {
                PlayerKill();
            }
        }
    }
    void PlayerKill()
    {
        txt.text = "����";
        p.Dead();
        audioSource.Play();
    }
}
