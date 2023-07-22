using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -Time.deltaTime * 5.0f);

        if (transform.position.x < 0)
        {
            Destroy(this);
        }
    }
}
