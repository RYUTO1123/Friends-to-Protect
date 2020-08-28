using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    
    public Health health;
    // Use this for initialization
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("ChangeScene", 1.5f);
    }
    void ChangeScene()

     {
        if (health != true)
        {

         SceneManager.LoadScene("GameclearScene");  

        }
        string GX = health.score + "";
        
     }

    
}