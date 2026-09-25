using System.Collections.Generic;
using UnityEngine;

public class AlienArmyScript : MonoBehaviour
{
    private C_AlienFactory alienFactory;
    private List<AlienScript> aliens = new List<AlienScript>();
    private float timer;
    private Vector3 moveDirection;
    private bool hasCollidedWithBorder;
    [SerializeField] private float actionInterval = 1f;

    private void Awake()
    {
        alienFactory = GetComponent<C_AlienFactory>();
    }

    private void Start()
    {
        timer = 0f;
        moveDirection = Vector3.right;
        CreateArmy();
    }

    private void Update()
    {
        hasCollidedWithBorder = false;

        if(timer >= actionInterval)
        {
            foreach(AlienScript alien in aliens)
            {
                alien.Move(moveDirection);
                alien.Shoot();
            }

            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void CreateArmy()
    {
        for (int row = 0; row < 5; row++)
        {
            for (int column = 0; column < 10; column++)
            {
                Vector3 position = new Vector3(
                    column * 1.5f - (1.5f * 4.5f),
                    row * 1.0f,
                    0
                );

                AlienScript alien = alienFactory.CreateAlien(position);
                C_Damageable damageable = alien.GetComponent<C_Damageable>();

                damageable.Died += AlienDied;

                aliens.Add(alien);
            }
        }
    }

    private void AlienDied(C_Damageable deadAlien)
    {
        aliens.Remove(deadAlien.GetComponent<AlienScript>());

        int remainingAliens = aliens.Count;

        //If half of aliens remains act twice as often
        if (remainingAliens <= 27)
            actionInterval = 0.5f;
        //If one alien remains act 10 times as often
        if (remainingAliens <= 1)
            actionInterval = 0.1f;
    }

    public void BorderCollision()
    {
        if (hasCollidedWithBorder)
        {
            return;
        }

        moveDirection *= -1; 

        foreach (AlienScript alien in aliens)
        {
            for(int i=0; i<3; i++)
            {
                alien.Move(Vector3.down);
            }
            
        }

        hasCollidedWithBorder = true;
    }
}
