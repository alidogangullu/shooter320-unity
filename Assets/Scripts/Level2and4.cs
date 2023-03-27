using UnityEngine;


public class Level2and4 : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3.5f;
    public int stopAt = 8;
    private float cooldown = 0f;
    void Update()
    {
        if (Score.score<stopAt && cooldown <= 0f)
        {
            Instantiate(enemy,gameObject.transform.position ,Quaternion.identity);

            cooldown = spawnTime;
        }
        cooldown -= Time.deltaTime;
    }
}
