using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public int attackDist = 12;
    private Transform targetPoint;
    private int startHP;

    public GameObject player, spawnPoint, otherPoint;

    private void Awake()
    {
        startHP = gameObject.GetComponent<HP>().healthPoint;
        targetPoint = otherPoint.transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= attackDist)
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
            gameObject.GetComponent<EnemyShoot>().canAttack = true;
        }
        else if (gameObject.GetComponent<HP>().healthPoint<startHP)
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
            attackDist = 20;
            gameObject.GetComponent<EnemyShoot>().canAttack = true;
        }
        else if (Vector3.Distance(transform.position, player.transform.position) >= attackDist)
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(targetPoint.position);
            gameObject.GetComponent<EnemyShoot>().canAttack = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == spawnPoint)
        {
            targetPoint = otherPoint.transform;
        }
        else if (other.gameObject == otherPoint)
        {
            targetPoint = spawnPoint.transform;
        }
    }
}
