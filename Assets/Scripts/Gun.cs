using UnityEngine;
using TMPro;
public class Gun : MonoBehaviour
{
    public Camera Cam;
    public Transform bulletSpawnPoint; 
    public GameObject bullet;
    public TextMeshProUGUI ammunitionDisplay;
    
    public float bulletSpeed, upForce, timeBetweenShooting, reloadTime;
    public int magazineSize;
    public bool allowBurst;
    int bulletsLeft, bulletsShot;
    bool shooting, readyToShoot, reloading;
    public bool allowInvoke = true;

    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;
    }

    private void Update()
    {
        MyInput();


        if (ammunitionDisplay != null)
        {
            ammunitionDisplay.color = Color.black;
            ammunitionDisplay.SetText( "Ammo: " + bulletsLeft + " / " + magazineSize);
        }
        
        if (reloading)
        {
            ammunitionDisplay.color = Color.red;
            ammunitionDisplay.SetText("Reloading...");
        }
            
        
    }
    private void MyInput()
    {
        if (allowBurst) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);
        
        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();
        
        if (readyToShoot && shooting && !reloading && bulletsLeft <= 0) Reload();

        
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = 0;

            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;
        
        Ray ray = Cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75);
        
        Vector3 direction = targetPoint - bulletSpawnPoint.position;
        
        
        GameObject currentBullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity); 
        currentBullet.transform.forward = direction.normalized;
        
        currentBullet.GetComponent<Rigidbody>().AddForce(direction.normalized * bulletSpeed, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(Cam.transform.up * upForce, ForceMode.Impulse);

        bulletsLeft--;
        bulletsShot++;
        
        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;
        }
    }
    private void ResetShot()
    {
        readyToShoot = true;
        allowInvoke = true;
    }

    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime);
    }
    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }
}
