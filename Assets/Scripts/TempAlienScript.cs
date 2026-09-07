using UnityEngine;

public class TempAlienScript : MonoBehaviour
{
    private C_Fire fire;
    private float timer;
    private float shootFrequenzy = 1f;
    [SerializeField] private GameObject bulletPrefab;

    private void Start()
    {
        fire = GetComponent<C_Fire>();
        timer = 0f;
    }


    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= shootFrequenzy)
        {
            fire.Fire(bulletPrefab);
            
            
            timer = 0f;
        }
    }
}
