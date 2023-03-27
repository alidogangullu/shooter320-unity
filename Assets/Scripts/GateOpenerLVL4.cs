using UnityEngine;

public class GateOpenerLVL4 : MonoBehaviour
{
    public GameObject Gate;
    public GameObject Boss;

    private void Start()
    {
        Gate.SetActive(false);
    }

    void Update()
    {
        if (Boss.GetComponent<HP>().healthPoint<=0)
        {
            Gate.SetActive(true);
        }
    }
}
