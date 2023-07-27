using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet bullet;
    [SerializeField] Transform muzzle;
    private float timer = 0f;
    private float BulletSpawnRate = 0.2f;

    private void Update()
    {
        if(timer < BulletSpawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            Instantiate(bullet, muzzle);
            timer = 0f;
        }
    }
}
