using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset; //고정값
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    void LateUpdate() //update이후에 실행된다 ,ui나 카메라 업데이트 관련(update에서 연산 다 하고 뒤에 따라붙는 것이기 때문).
    {
        transform.position = playerTransform.position + Offset;
    }
}
