using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move4 : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(-0.8f * Time.deltaTime, 0f, -0.01f);
    }
}
