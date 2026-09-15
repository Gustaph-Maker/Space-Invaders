using System.Collections.Generic;
using UnityEngine;

public class AlienArmyScript : MonoBehaviour
{
    private C_AlienFactory alienFactory;
    private List<GameObject> aliens = new List<GameObject>();
    private float timer;
    private Vector3 moveDirection;

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
        if(timer >= 1)
        {
            foreach(GameObject alien in aliens)
            {
                alien.GetComponent<AlienScript>().Move(moveDirection);
                alien.GetComponent<AlienScript>().Shoot();
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

                GameObject alien = alienFactory.CreateAlien(position);
                aliens.Add(alien);
            }
        }
    }

    public void BorderCollision()
    {
        moveDirection *= -1; 

        foreach (GameObject alien in aliens)
        {
            alien.GetComponent<AlienScript>().Move(Vector3.down);
        }
    }
}
