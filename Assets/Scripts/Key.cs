using TMPro;
using UnityEngine;

public class Key : MonoBehaviour
{
    public TextMeshProUGUI keyText;
    public static bool hasKey = false;

    void Update()
    {
        transform.Rotate(Vector3.up * (25 * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasKey = true;
            keyText.SetText("Blue key collected, it can be used with the blue button.");
            Destroy(gameObject);
            Destroy(keyText, 4);
        }
    }
}
