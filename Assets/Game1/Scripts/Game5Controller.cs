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
    string[] strs = { "무","궁","화","꽃","이","피","었","습","니","다"};

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
        InvokeRepeating("WaitTime", 1f, 1f); //1초뒤에 1초마다 반복실행   

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
            txt.text = $"통과";
        }
    }
     

    void WaitTime()
    {
        txt.text = $"게임시작 대기{waitTimer}초 전...";
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
        txt.text = "실패";
        p.Dead();
        audioSource.Play();
    }
}
