using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ここで移りたいシーンを指定します。
        // SceneManager.LoadScene("Titie");
    }

    public void PushGoToMainButton()
    {
        SceneManager.LoadScene("Title");
    }
}