using TMPro;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int healthPoint = 10;
    private int getDamage;
    public TextMeshPro hpBar;
    void Update()
    {
        hpBar.SetText("HP: " + healthPoint);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            if (WeaponSelect.isBlueWeapon)
            {
                getDamage = Random.Range(BlueBullet.minDamage,
                    BlueBullet.maxDamage);
            }
            else if (WeaponSelect.isGreenWeapon)
            {
                getDamage = Random.Range(GreenBullet.minDamage,
                    GreenBullet.maxDamage);
            }

            healthPoint -= getDamage;
            
            if(healthPoint <= 0)
            {
                if (gameObject.GetComponent<EnemyShoot>().isLevelBoss)
                {
                    Cursor.visible = true;
                    UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<EnemyShoot>().isBoss)
                {
                    Score.score++;
                    gameObject.SetActive(false);
                }
                else
                {
                    Score.score++;
                    Destroy(gameObject);
                }
                
            }
            
        }
    }
}
