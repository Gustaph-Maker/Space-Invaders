using System;
using UnityEngine;

public class C_Damageable : MonoBehaviour
{
    [SerializeField] private int maxHealth = 1;

    public int currentHealth { get; private set; }

    public event Action<C_Damageable> Died;

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
