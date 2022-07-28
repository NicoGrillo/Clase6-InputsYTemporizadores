using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public float speed = 3F;
    public Vector3 direction;
    public bool canShoot = true;
    private Vector3 directionPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* MODO 1
        directionPlayer = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            directionPlayer += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            directionPlayer += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            directionPlayer += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            directionPlayer += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (directionPlayer != Vector3.zero)
        {
            Movement(directionPlayer);
        }
        */
        MoveAxis();
    }
    private void MoveAxis()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(ejeHorizontal, 0, ejeHorizontal) * speed * Time.deltaTime);
    }

    private void Movement(Vector3 value) //MODO 1
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
