using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public HealthBar healthBar;
    private HealthSystem healthSystem;

    private void Start()
    {
        healthSystem = new HealthSystem(100);

        healthBar.SetUp(healthSystem);
    }

    private void Update()
    {  
        Debug.Log(healthSystem.GetHealth());
        healthSystem.Damage(1);
    }
}
