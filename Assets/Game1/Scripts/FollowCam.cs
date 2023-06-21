using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = target.position;
        pos.z = target.position.x;
        pos.y = target.position.y +1.05f;
        // pos.z = -(Mathf.Abs(target.position.z) -3f); // ������ ����� ������� ��ȣ��������
        pos.z = target.position.z - 1.5f;
        transform.position = Vector3.Lerp(target.position, pos , 1f);

        transform.rotation = Quaternion.Euler(5.5f, 0, 0);

    }
}
