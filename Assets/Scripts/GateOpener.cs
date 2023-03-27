using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public GameObject rotate1, rotate2, key;

    private void Start()
    {
        key.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Key.hasKey)
        {
            rotate1.transform.rotation = Quaternion.Euler(0,180,0);
            rotate2.transform.rotation = Quaternion.Euler(0,180,0);
        }
    }

    private void Update()
    {
        if (Score.score == 4)
        {
            Score.score++;
            key.SetActive(true);
        }
    }
}
