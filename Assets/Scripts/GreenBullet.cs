using UnityEngine;

public class GreenBullet : MonoBehaviour
{
    public static int maxDamage = 15;
    public static int minDamage = 10;
    public static float destroyTime = 4f;
    public static int upgradeLvl = 0;

    void Update()
    {
        Destroy (gameObject, destroyTime);
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
