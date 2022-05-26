using System;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int health;

    public void Damage(int damage)
    {
        health -= damage;
        Debug.Log("Damaged" + health);
        if (health <= 0)
            Debug.Log("I am dead!");
    }
}
