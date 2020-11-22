using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    public int CurAmmo;
    public int maxAmmo;
    public float speed;
    public float Firerate;
    private float lastShootTime;
    public bool isPlayer;
    public AudioSource firesound;
    // Start is called before the first frame update

    private void Awake()
    {
        if (GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        }

        firesound = GetComponent<AudioSource>();
    }

    public bool CanShoot()
    { if(Time.time- lastShootTime >= Firerate)
        {
            if (CurAmmo > 0)
            {
                return true;
            }
        }

        return false;
    }

    public void Shoot()
    {
        lastShootTime = Time.time;
        firesound.Play();
        CurAmmo--;
        GameObject projectile = Instantiate(bullet, muzzle.position, muzzle.rotation);
        projectile.GetComponent<Rigidbody>().velocity = muzzle.forward * speed;
    }

  
    
}
