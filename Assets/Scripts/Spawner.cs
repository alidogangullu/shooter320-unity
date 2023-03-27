using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    private float areaX, areaZ;
    private double enemyCount;
    private double difficulty = 0;
    private int maxEnemy = 2;
    public TextMeshProUGUI waveText;
    public int wave = 1;

    private void Start()
    {
        waveText.SetText("WAVE 1 !");
    }

    void Update()
    {
        
            if (enemyCount < maxEnemy)
            {
                areaX = Random.Range(0, 54);
                areaZ = Random.Range(0, 54);
                Instantiate(Enemy, new Vector3(areaX,  1, areaZ),Quaternion.identity);
                enemyCount++;
            }
            
            if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
            {
                difficulty += 0.3;
                enemyCount = 0;
                maxEnemy = (int) (maxEnemy + difficulty);
                wave++;
                waveText.SetText("WAVE " + wave + " !");
            }
        
    }
}
