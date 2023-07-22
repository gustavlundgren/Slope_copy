using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] private float spawnRate = 2.0f;

    private float timer = 0.0f;

    private void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            Instantiate(obstacle, new Vector3(Random.Range(-3.5f, 3.0f), transform.position.y, transform.position.z), transform.rotation);
            timer = 0.0f;
            Debug.Log("Spawn!");
        }
    }
}
