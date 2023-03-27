using TMPro;
using UnityEngine;

public class Level3Gate : MonoBehaviour
{
    public TextMeshPro tutorial;
    public GameObject moveTo;
    private GameObject player;
    
    private void Start()
    {
        gameObject.SetActive(false);
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove.teleporting = true;
            Score.score++;
            Destroy(tutorial);
            gameObject.SetActive(false);
            player.transform.position = moveTo.transform.position;
        }
    }
}
