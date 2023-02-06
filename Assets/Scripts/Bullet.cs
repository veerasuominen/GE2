using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10;
    public bool collided = false;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.fixedDeltaTime);
        Destroy(gameObject, 3);
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    collided = true;
    //    Destroy(collision.gameObject);
    //}
}