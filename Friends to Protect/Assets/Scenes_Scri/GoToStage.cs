using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ここで移りたいシーンを指定します。
       // SceneManager.LoadScene("Main");
    }

    public void PushGoToMainButton()
    {
        SceneManager.LoadScene("stage");
    }
}
