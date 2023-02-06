using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //gun properties

    public float damage = 10f;
    public float bulletSpeed = 10f;
    public float range = 100f;
    public float fireRate = 10f;
    private float nextTimeToFire = 0f;
    public float impactForce = 50f;
    public float spread = 1;
    public bool shooting;

    //for reloading
    public float bulletsLeft, bulletsShot;

    public float magazineSize = 25;
    public float reloadTime = 3f;
    public bool reloading;

    //ojects
    public Camera fpsCam;

    public ParticleSystem muzzleFlash;
    public AudioSource ak;
    public GameObject player, bullet, bulletSpawner, impactEffect;
    public bool shot;

    private void Start()
    {
        bulletsLeft = magazineSize;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && bulletsShot < magazineSize)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            shooting = true;
        }
        else shooting = false;

        if (Input.GetKeyDown(KeyCode.R) && !reloading && bulletsLeft < magazineSize)
        {
            Reload();
            reloading = true;
        }
        if (bulletsLeft <= 0 && shooting == true)
        {
            Reload();
            reloading = true;
        }
        else reloading = false;
    }

    private void Reload()
    {
        Invoke("ReloadFinished", reloadTime);
    }

    private void ReloadFinished()
    {
        bulletsShot = 0;
        bulletsLeft = magazineSize;
    }

    private void Shoot()
    {
        //updates mag info
        bulletsShot++;
        bulletsLeft--;

        Vector3 targetPoint;
        Ray bulletRay;
        RaycastHit hit;

        //plays muzzleflash and soundeffect when method is called
        muzzleFlash.Play();
        ak.Play();

        bulletRay = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        //shoots a raycast forward from camera postion, sets a range
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //sets targetpoint to be raycasts hitpoint
            if (Physics.Raycast(bulletRay, out hit))
            {
                targetPoint = hit.point;
            }

            //just a point far from the player
            else
                targetPoint = bulletRay.GetPoint(75);

            Vector3 directionWithoutSpread = targetPoint - bulletSpawner.transform.position;

            float spreadX = Random.Range(-spread, spread);
            float spreadY = Random.Range(-spread, spread);

            Vector3 directionWithSpread = directionWithoutSpread + new Vector3(spreadX, spreadY, 0);

            //prints hit object name, checks if object has a Target scrip
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();

            //if raycast returns a value it takes damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            //adds impactForce if raycast hit isnt null
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            //spawns bullet from bulletSpawner object and sets to the middle of the screen
            GameObject currentBullet = Instantiate(bullet, bulletSpawner.transform.position, Quaternion.identity);
            currentBullet.transform.forward = directionWithSpread.normalized;

            //spawns impactParticleSystem on the hitpoint of a raycast
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}