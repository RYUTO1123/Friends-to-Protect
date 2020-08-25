using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(-0.4f * Time.deltaTime, 0f, -0.01f);
    }
}
