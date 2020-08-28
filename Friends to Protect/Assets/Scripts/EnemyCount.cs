using UnityEngine;

using System.Collections;



public class EnemyCount : MonoBehaviour

{

    public UnityEngine.UI.Text scoreLabel;

    public void Update()

    {

        int count = GameObject.FindGameObjectsWithTag("Kids").Length;

        scoreLabel.text = count.ToString();

    }

}
