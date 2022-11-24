using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{

    [Header("Health Properties")]
    public int value;

    [Header("Displat Properties")]
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentInChildren<Slider>();
        ResetHealth();
    }

    public void ResetHealth()
    {
        healthBar.value = 100;
        value = (int)healthBar.value;
    }

    public void TakeDamage(int damage)
    {
        healthBar.value -= damage;
        if (healthBar.value < 0)
        {
            healthBar.value = 0;
        }
        value = (int)healthBar.value;
    }

    public void healDamage(int damage)
    {
        healthBar.value += damage;
        if (healthBar.value > 100)
        {
            healthBar.value = 100;
        }
        value = (int)healthBar.value;
    }

}
