using UnityEngine;

public class Boss : MonoBehaviour
{
    public int attackDist = 40;
    public GameObject mainBoss;
    
    private int startHP;
    private void Awake()
    {
        startHP = mainBoss.GetComponent<HP>().healthPoint;
    }
    void Update()
    {
        transform.LookAt(GameObject.FindWithTag("Player").transform);
        if (Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position) <= attackDist)
        {
            mainBoss.GetComponent<EnemyShoot>().canAttack = true;
        }
        else if (mainBoss.GetComponent<HP>().healthPoint<startHP && Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position) > attackDist)
        {
            mainBoss.GetComponent<HP>().healthPoint = startHP;
            mainBoss.GetComponent<EnemyShoot>().canAttack = true;
        }
        else if (Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position) > attackDist)
        {
            mainBoss.GetComponent<EnemyShoot>().canAttack = false;
        }
    }
}
