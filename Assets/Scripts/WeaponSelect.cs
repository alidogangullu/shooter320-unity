using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public static bool isBlueWeapon;
    public static bool isGreenWeapon = true;
    public GameObject blueWeapon;
    public GameObject greenWeapon;
    private void Awake()
    {
        if (isBlueWeapon)
        {
            isGreenWeapon = false;
            blueWeapon.SetActive(true);
            greenWeapon.SetActive(false);
        }
        else if (isGreenWeapon)
        {
            isBlueWeapon = false;
            greenWeapon.SetActive(true);
            blueWeapon.SetActive(false);
        }
    }
}
