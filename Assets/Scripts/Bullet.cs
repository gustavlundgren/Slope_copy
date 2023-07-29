using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 100f;

    private void Start()
    {
        Destroy(gameObject, 5f); ;
    }

    void Update()
    {
        transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * moveSpeed;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Obstacle obstacle = collider.GetComponent<Obstacle>();
        
        if(obstacle != null)
        {
            obstacle.Damage(10);
            Destroy(gameObject);
        }
    }
}
