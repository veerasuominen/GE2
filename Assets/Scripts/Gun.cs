using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //gun properties
    public float damage = 10f;

    public float range = 100f;
    public float fireRate = 10f;
    private float nextTimeToFire = 0f;

    //ojects
    public Camera fpsCam;

    public ParticleSystem muzzleFlash;
    public AudioSource ak;
    public GameObject player, bullet, bulletSpawner;
    public bool shot;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            shot = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            shot = false;
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        muzzleFlash.Play();
        ak.Play();
        Instantiate(bullet, bulletSpawner.transform.position, transform.rotation);

        //shoots a raycast forward from camera postion, sets a range
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //prints hit object name, checks if object has a Target scrip
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();

            //if raycast returns a value it takes damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}