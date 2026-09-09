using System.Collections.Generic;
using UnityEngine;

public class AlienArmyScript : MonoBehaviour
{
    private C_AlienFactory alienFactory;
    private List<GameObject> aliens = new List<GameObject>();

    private void Awake()
    {
        alienFactory = GetComponent<C_AlienFactory>();
    }

    private void Start()
    {
        CreateArmy();
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
}
