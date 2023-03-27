using UnityEngine;

public class Aim : MonoBehaviour
{
    public Vector3 focusPos;
    public Vector3 normalPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            transform.localPosition = focusPos;
        }

        if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = normalPos;
        }
        {
            
        }
    }
}
