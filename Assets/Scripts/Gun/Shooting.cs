using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public float damage = 10;
    public float range = 100;
    public float fireRate = 10;
    public float impactForce = 30;

    public Camera fpsCam;
    public ParticleSystem muzzleflash;

    public AudioSource akSound;

    private float nextTimeToFire = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        muzzleflash.Play();
        akSound.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}