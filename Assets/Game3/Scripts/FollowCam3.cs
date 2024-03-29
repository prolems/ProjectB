using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam3 : MonoBehaviour
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
        pos.y = target.position.y +2.05f;
        // pos.z = -(Mathf.Abs(target.position.z) -3f); // 음수를 양수로 만들어줌 부호를없애줌
        pos.z = target.position.z - 3.5f;
        transform.position = Vector3.Lerp(target.position, pos , 1f);

        transform.rotation = Quaternion.Euler(8f, 0, 0);

    }
}
