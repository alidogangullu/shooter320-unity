using UnityEngine;

public class Level4BossFix : MonoBehaviour
{
    public GameObject Boss;

    private void Start()
    {
        Boss.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Boss.SetActive(true);
        }
    }
}
