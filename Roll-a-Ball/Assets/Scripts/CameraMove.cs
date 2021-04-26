using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset; //������
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    void LateUpdate() //update���Ŀ� ����ȴ� ,ui�� ī�޶� ������Ʈ ����(update���� ���� �� �ϰ� �ڿ� ����ٴ� ���̱� ����).
    {
        transform.position = playerTransform.position + Offset;
    }
}
