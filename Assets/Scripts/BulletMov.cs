using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    public Vector3 direction = new Vector3(0, 0, 0);
    public float speed = 1f;
    public int damage = 1;
    public float lifeTime = 5f;

    private void Start() 
    {
        Invoke("DestroyDelay",lifeTime);
    }

    void Update()
    {
        Move(speed, direction);
    }

    private void Move(float speedValue, Vector3 dirValue)
    {
        //transform.position += dirValue * speedValue * Time.deltaTime;
        transform.Translate(dirValue * speedValue * Time.deltaTime);
    }

    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}

