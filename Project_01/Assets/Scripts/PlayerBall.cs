using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� �ʿ���
// scene ����� ���ؼ��� file - build setting ���� �߰����־����
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audio;
    public GameManager gm; // �巡�� ������� ���
    public float jumpPower = 10;
    public int itemCount = 0;
    bool isJumping = false;
   

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rb.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Floor")
        {
            isJumping = false;
        } 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            gm.GetItem(itemCount);
        }
        else if (other.tag == "Goal")
        {
            if(itemCount == gm.totalItemCount)
            {
                // Game Clear
                SceneManager.LoadScene("Example_" + (gm.stage + 1));
            }
            else
            {
                SceneManager.LoadScene("Example_" + gm.stage);
            }
        }
    }
}
