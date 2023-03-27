using UnityEngine;

public class EnemyMoveEndless : MonoBehaviour
{
    private float speed;
    private GameObject player;
    private GameObject enemySpawner;
    public int attackDist;

    private void Start()
    {
        enemySpawner = GameObject.Find("EnemySpawner");
        speed = 0.75f + (enemySpawner.GetComponent<Spawner>().wave-1)*0.075f;
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, player.transform.position) <= attackDist)
        {
            gameObject.GetComponent<EnemyShoot>().canAttack = true;
        }
        else
        {
            gameObject.GetComponent<EnemyShoot>().canAttack = false;
        }
    }
    
}
