using UnityEngine;

public class BlueBullet : MonoBehaviour
{
    public static int maxDamage = 20;
    public static int minDamage = 10;
    public static int upgradeLvl = 0;

    void Update()
    {
        Destroy (gameObject, 1.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Bullet"))
        {
            //nothing
        }
        gameObject.SetActive(false);
        
    }
}
