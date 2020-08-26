using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    GameObject[] enemyObjects;
    int enemyNum;
    void Start()
    {
        enemyObjects = GameObject.FindGameObjectsWithTag("Kids");
        enemyNum = enemyObjects.Length;
    }
}
