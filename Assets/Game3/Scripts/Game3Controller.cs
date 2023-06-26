using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game3Controller : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] Transform maps;
    [SerializeField] Transform parent;
    [SerializeField] List<GameObject> blocks;

   
    void Start()
    {
        InstantBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantBlock()
    {
        for (int b = 0; b < 14; b += 2)   //애드된블록갯수만큼(총14개)
        {
            for (int j = 0; j < prefabs.Count; j++)
            {
                GameObject myInstance = Instantiate(prefabs[j], maps);  //한줄에 두개 생성
                blocks.Add(myInstance);         // 블락리스트에 두개애드
            }
                Vector3 vec = blocks[b].transform.localPosition;
                Vector3 vecc = blocks[b+1].transform.localPosition;
                vec.z +=b;
                vecc.z+=b;
                SwitchTrans(vec, vecc, b); // x좌표 랜덤위치 변경
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
