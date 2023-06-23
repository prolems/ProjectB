using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game3Controller : MonoBehaviour
{
    [SerializeField] List<Blocks> trans;
    [SerializeField] Transform parent;
    List<GameObject> madeObjs;
    bool ranBool = false;
    void Start()
    {
       // InstantBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void InstantBlock()
    {
        for (int i = 0; i < 7; i++)
        {
              int ran = trans[Random.Range(0, trans.Count);
              for (int i = 0; i < 1; i++)
              {

              }
              Instantiate(trans[Random.Range(0, trans.Count)], parent);
              madeObjs.Add()
            //  RandomBool();
              //if (ranBool)
             // {
              //    SwitchTrans();
              //}

              for (int j = 0; j < trans.Count; j++)
              {
                  Vector3 pos = trans[j].GetComponent<Transform>().position;
                  pos.z += 2;
                  trans[j].GetComponent<Transform>().position = pos;
              }

          }
      }

     /* public List<T> GetShuffledList<T>(List<T> _list)
      {
          for (int i = _list.Count-1; i > 0; i--)
          {
              int rnd = UnityEngine.Random.Range(0, i);

              T temp = _list[i];
              _list[i] 
          }
          return _list;
      }

      public void SwitchTrans()
      {
              var tempTrans = trans[0].GetComponent<Transform>().position;
              trans[1].GetComponent<Transform>().position = tempTrans;
              trans[0].GetComponent<Transform>().position = trans[1].GetComponent<Transform>().position;
      }
      public bool  RandomBool() 
      {
          if (Random.value >= 0.5)
          {
              return ranBool = true;
          }
          return ranBool = false;
      }
              */
}
