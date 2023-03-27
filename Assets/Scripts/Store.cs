using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    private int points;
    public GameObject upgradeInfo, moneyError,
        greenWeapon,blueWeapon,
        equipGreen, equipBlue,
        upgradeG1,upgradeG2,upgradeG3,
        upgradeB1,upgradeB2,upgradeB3;
    public TextMeshProUGUI pointText;
    private float upgradeInfoTime, moneyErrorTime = 3f;
    void Awake()
    {
        upgradeInfo.SetActive(false);
        moneyError.SetActive(false);
        
        upgradeB2.SetActive(false);
        upgradeB3.SetActive(false);
        
        upgradeG2.SetActive(false);
        upgradeG3.SetActive(false);
        
        if (BlueBullet.upgradeLvl>=1)
        {
            upgradeB1.GetComponent<Button>().interactable = false;
            upgradeB2.SetActive(true);
            if (BlueBullet.upgradeLvl>=2)
            {
                upgradeB2.GetComponent<Button>().interactable = false;
                upgradeB3.SetActive(true);
            }
            if (BlueBullet.upgradeLvl>=3)
            {
                upgradeB3.GetComponent<Button>().interactable = false;
            }
        }
        
        if (GreenBullet.upgradeLvl>=1)
        {
            upgradeG1.GetComponent<Button>().interactable = false;
            upgradeG2.SetActive(true);
            if (GreenBullet.upgradeLvl>=2)
            {
                upgradeG2.GetComponent<Button>().interactable = false;
                upgradeG3.SetActive(true);
            }
            if (GreenBullet.upgradeLvl>=3)
            {
                upgradeG3.GetComponent<Button>().interactable = false;
            }
        }
        
        if (WeaponSelect.isGreenWeapon)
        {
            equipGreen.SetActive(true);
            greenWeapon.GetComponent<Button>().interactable = false;
        }
        else if (WeaponSelect.isBlueWeapon)
        {
            equipBlue.SetActive(true);
            blueWeapon.GetComponent<Button>().interactable = false;
        }
    }

    private void Update()
    {
        points = UIScore.totalScore;
        pointText.SetText("Points: " + points);
        
        if (upgradeInfoTime<=0f)
        {
            upgradeInfo.SetActive(false);
            upgradeInfoTime = 3f;
        }
        upgradeInfoTime -= Time.deltaTime;
        
        if (moneyErrorTime<=0f)
        {
            moneyError.SetActive(false);
            moneyErrorTime = 3f;
        }
        moneyErrorTime -= Time.deltaTime;
    }

    public void EquipGreen()
    {
        if (WeaponSelect.isGreenWeapon)
        {
            WeaponSelect.isGreenWeapon = false;
            WeaponSelect.isBlueWeapon = true;
            equipGreen.SetActive(false);
            equipBlue.SetActive(true);
        }
        else if (WeaponSelect.isGreenWeapon == false)
        {
            WeaponSelect.isGreenWeapon = true;
            WeaponSelect.isBlueWeapon = false;
            equipGreen.SetActive(true);
            equipBlue.SetActive(false);
            greenWeapon.GetComponent<Button>().interactable = false;
            blueWeapon.GetComponent<Button>().interactable = true;
        }
    }
    
    public void EquipBlue()
    {
        if (WeaponSelect.isBlueWeapon)
        {
            WeaponSelect.isGreenWeapon = true;
            WeaponSelect.isBlueWeapon = false;
            equipGreen.SetActive(true);
            equipBlue.SetActive(false);
        }
        else if (WeaponSelect.isBlueWeapon == false)
        {
            WeaponSelect.isBlueWeapon = true;
            WeaponSelect.isGreenWeapon = false;
            equipGreen.SetActive(false);
            equipBlue.SetActive(true);
            blueWeapon.GetComponent<Button>().interactable = false;
            greenWeapon.GetComponent<Button>().interactable = true;
        }
    }

    public void UpgradeG1()
    {
        if (points>=5)
        {
            upgradeG1.GetComponent<Button>().interactable = false;
            GreenBullet.maxDamage += 3;
            GreenBullet.minDamage += 3;
            UIScore.totalScore -= 5;
            upgradeG2.SetActive(true);
            GreenBullet.upgradeLvl = 1;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
    
    public void UpgradeG2()
    {
        if (points>=10)
        {
            upgradeG2.GetComponent<Button>().interactable = false;
            GreenBullet.maxDamage += 5;
            GreenBullet.minDamage += 5;
            UIScore.totalScore -= 10;
            upgradeG3.SetActive(true);
            GreenBullet.upgradeLvl = 2;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
    
    public void UpgradeG3()
    {
        if (points>=15)
        {
            upgradeG3.GetComponent<Button>().interactable = false;
            GreenBullet.maxDamage += 7;
            GreenBullet.minDamage += 7;
            UIScore.totalScore -= 15;
            GreenBullet.upgradeLvl = 3;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
    
    public void UpgradeB1()
    {
        if (points>=5)
        {
            upgradeB1.GetComponent<Button>().interactable = false;
            BlueBullet.maxDamage += 3;
            BlueBullet.minDamage += 3;
            UIScore.totalScore -= 5;
            upgradeB2.SetActive(true);
            BlueBullet.upgradeLvl = 1;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
    
    public void UpgradeB2()
    {
        if (points>=10)
        {
            upgradeB2.GetComponent<Button>().interactable = false;
            BlueBullet.maxDamage += 5;
            BlueBullet.minDamage += 5;
            UIScore.totalScore -= 10;
            upgradeB3.SetActive(true);
            BlueBullet.upgradeLvl = 2;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
    
    public void UpgradeB3()
    {
        if (points>=15)
        {
            upgradeB3.GetComponent<Button>().interactable = false;
            BlueBullet.maxDamage += 7;
            BlueBullet.minDamage += 7;
            UIScore.totalScore -= 15;
            BlueBullet.upgradeLvl = 3;
            upgradeInfo.SetActive(true);
        }
        else
        {
            moneyError.SetActive(true);
        }
    }
}
