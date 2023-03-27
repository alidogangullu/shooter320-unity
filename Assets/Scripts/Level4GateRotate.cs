using UnityEngine;

public class Level4GateRotate : MonoBehaviour
{
    public GameObject Boss; 
    public GameObject ramp1, ramp2, ramp3;
    void Update()
    {
        if (Boss.GetComponent<HP>().healthPoint<=0)
        {
            ramp1.transform.rotation = Quaternion.Euler(0,90,0);
            ramp2.transform.rotation = Quaternion.Euler(0,90,0);
            ramp3.transform.rotation = Quaternion.Euler(0,90,0);
        } 
    }
}
