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
    }
}
