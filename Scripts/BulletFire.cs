using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour
{
    public float fireTime = 1f;
    public GameObject bullet;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Fire", fireTime, fireTime);
    }

    void Fire()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
