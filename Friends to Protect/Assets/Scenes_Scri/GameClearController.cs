using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClearController : MonoBehaviour
{
    private GameObject[] enemyObjects;

    void Update()
    {
        enemyObjects = GameObject.FindGameObjectsWithTag("Kids");

        if (enemyObjects.Length == 0)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}