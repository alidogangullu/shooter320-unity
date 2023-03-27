using UnityEngine;

public class Level4Gate : MonoBehaviour
{
    public GameObject moveTo;
    private GameObject player;
    
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMove.teleporting = true;
            gameObject.SetActive(false);
            player.transform.position = moveTo.transform.position;
        }
    }
}
