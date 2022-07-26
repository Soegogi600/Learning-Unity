using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offset;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTransform.position;
    }

    // 카메라 이동은 보통 LateUpdate에서 이루어짐
    void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
