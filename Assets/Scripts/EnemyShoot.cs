using UnityEngine;
using Random = UnityEngine.Random;


public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float cooldown = 1f;
    public bool canAttack = false;
    public bool isBoss = false;
    public bool isLevelBoss = false;

    private void Update()
    {
        if (canAttack)
        {
            if (isBoss == false)
            {
                if (cooldown <= 0f)
                {
                    GameObject bullets = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
                    Destroy(bullets, 5);

                    cooldown = Random.Range(0.5f, 3f);
                }
                cooldown -= Time.deltaTime;
            }
            else if (isBoss)
            {
                if (cooldown <= 0f)
                {
                    GameObject bullets = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
                    Destroy(bullets, 5);

                    cooldown = Random.Range(0.25f, 1.5f);
                }
                cooldown -= Time.deltaTime;
            }
        }
    }
}

