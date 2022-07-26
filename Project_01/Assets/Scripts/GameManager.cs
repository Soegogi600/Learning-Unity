using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// UI »ç¿ë
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public Text stageCount;
    public Text playerCount;

    void Awake()
    {
        stageCount.text = "/ " + totalItemCount;    
    }

    public void GetItem(int count)
    {
        playerCount.text = count.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Example_" + stage);
        }    
    }
}
