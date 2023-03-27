using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveLVL4 : MonoBehaviour
{
    public int attackDist = 12;
    private int startHP;

    private GameObject player;

    private void Awake()
    {
        startHP = gameObject.GetComponent<HP>().healthPoint;
        player = GameObject.Find("Player");
    }

    void Update()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
        
        if (Vector3.Distance(transform.position, player.transform.position) <= attackDist)
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
            gameObject.GetComponent<EnemyShoot>().canAttack = true;
        }
        else if (gameObject.GetComponent<HP>().healthPoint<startHP)
        {
            attackDist = 20;
            gameObject.GetComponent<EnemyShoot>().canAttack = true;
        }
    }
}