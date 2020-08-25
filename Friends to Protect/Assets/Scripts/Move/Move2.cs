using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0f * Time.deltaTime, 0f, -0.01f);
    }
}
