using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform pfHealthBar;
    private HealthSystem healthSystem;
    private HealthBar healthBar;

    private void Start()
    {
        healthSystem = new HealthSystem(100);

        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(transform.position.x, 2.0f, transform.position.z), Quaternion.identity);
        healthBar = healthBarTransform.GetComponent<HealthBar>();

        healthBar.SetUp(healthSystem);
    }

    private void Update()
    {  
        if(healthSystem.GetHealth() == 0) 
        {
            Destroy(healthBar);
            Destroy(gameObject);
        }
    }

    public void Damage(int damageAmount)
    {
        healthSystem.Damage(damageAmount);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Obstacle obstacle = collider.GetComponent<Obstacle>();

        if (obstacle != null)
        {
            obstacle.Damage(10);
            Destroy(gameObject);
        }
    }
}
