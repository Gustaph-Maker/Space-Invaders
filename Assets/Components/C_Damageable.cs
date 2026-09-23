using System;
using UnityEngine;

public class C_Damageable : MonoBehaviour
{
    [SerializeField] private int maxHealth = 1;

    private int currentHealth;

    public event Action<Damage> Died;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Died?.Invoke(this);

        Destroy(gameObject);
    }
}
