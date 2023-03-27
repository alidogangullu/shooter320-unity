using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject key, elevator;
    private bool canUp = false;
   
    void Start()
    {
        key.SetActive(false);
        
    }
    
    private void FixedUpdate()
    {
        if (Score.score == 8)
        {
            key.SetActive(true);
            Score.score++;
        }

        if (canUp && elevator.transform.position.y<20f)
        {
           elevator.transform.position += elevator.transform.up * 3f*Time.deltaTime;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Key.hasKey)
        {
            canUp = true;
        }
    }
}
