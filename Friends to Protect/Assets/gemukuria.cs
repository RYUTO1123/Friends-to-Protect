using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gemukuria : MonoBehaviour
{
    public void PushGoToMainButton()
    {
        //ここで移りたいシーンを指定します。
        SceneManager.LoadScene("taitoru");
    }
}
