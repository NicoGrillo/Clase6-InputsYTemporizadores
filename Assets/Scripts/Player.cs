using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public float speed = 3F;
    public Vector3 direction;
    public bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    private void Movement(Vector3 value)
    {
        transform.Translate(value * speed * Time.deltaTime);
    }

    private void Shoot()
    {
        if (canShoot)
        {
            Instantiate(bulletPrefabs[0], transform.position, transform.rotation);
            canShoot = false;
            Invoke("ShootAgain", 1f);
        }
    }

    private void ShootAgain()
    {
        canShoot = true;
    }
}
