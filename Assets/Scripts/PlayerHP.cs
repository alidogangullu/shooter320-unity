using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerHP : MonoBehaviour
{
    public int HealthPoint;
    private int getDamage;
    public TextMeshProUGUI hpBar;
    private bool isDead = false;
    public String LVL;
    public static String Level;

    private void Start()
    {
        Level = LVL;
    }

    void Update()
    {
        hpBar.SetText(" HP: " + HealthPoint);
        
        if(HealthPoint <= 0)
        {
            hpBar.SetText("Game Over");
            isDead = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScene");
            Cursor.visible = true;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyBullet") && isDead==false)
        {
            getDamage = Random.Range(other.gameObject.GetComponent<EnemyBullet>().minDamage,
                other.gameObject.GetComponent<EnemyBullet>().maxDamage);

            HealthPoint = HealthPoint - getDamage;

        }

        if (other.gameObject.CompareTag("Finish"))
        {
            HealthPoint = 0;
        }
    }
}
