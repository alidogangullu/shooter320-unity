using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int maxDamage, minDamage;

    private void Awake()
    {
        transform.LookAt(GameObject.FindWithTag("Player").transform);
    }

    private void Update()
    {
        transform.position += transform.forward * 15f * Time.deltaTime;
        Destroy (gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")||other.gameObject.CompareTag("Boss")||other.gameObject.CompareTag("Bullet"))
        {
            //nothing
        }
        else
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
