using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move4 : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(-1.5f * Time.deltaTime, 0f, 0f);
    }
}
