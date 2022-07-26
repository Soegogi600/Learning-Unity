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
        // Rotate : ȸ���Լ�
        // �ι�° ������ ���� ��ǥ�� ���� ����
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
