using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gemugamen1 : MonoBehaviour
{
    public void PushGoToMainButton()
    {
        //ここで移りたいシーンを指定します。
        SceneManager.LoadScene("gemugamen");
    }
}
