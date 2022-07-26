using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    AudioSource audio;
    public float rotateSpeed;

    void Awake()
    {
        audio = GetComponent<AudioSource>();    
    }

    void Update()
    {
        // Rotate : 회전함수
        // 두번째 변수로 축의 좌표계 지정 가능
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
