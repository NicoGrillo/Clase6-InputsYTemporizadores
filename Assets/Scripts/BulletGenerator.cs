using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public float delayStart = 1f;
    public float delayShot = 1f;

    void Start()
    {
        InvokeRepeating("Shoot", delayStart, delayShot);
    }

    private void Shoot()
    {
        int indexBullet = Random.Range(0, bulletPrefabs.Length);
        Instantiate(bulletPrefabs[indexBullet], transform);
    }

}
