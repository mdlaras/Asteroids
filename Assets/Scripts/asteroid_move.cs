using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_move : MonoBehaviour
{
    Vector3 MovementVector;
    [SerializeField] float speed;

    void Start()
    {
        MovementVector = new Vector3(Random.Range(-speed,speed), Random.Range(-speed, speed));
    }

    void Update()
    {
        transform.position = transform.position + MovementVector * Time.deltaTime;

        if (transform.position.x < -7 || transform.position.x > 7)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 5.2 || transform.position.y < -5.2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, transform.position.z);
        }
    }
}
