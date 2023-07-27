using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0.0f, 0.0f, 1.0f);
    }
}
