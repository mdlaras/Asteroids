using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_move : MonoBehaviour
{
    ship_move ShipMovement;
    public Vector3 MovementVector;

    // Start is called before the first frame update
    void Start()
    {
        ShipMovement = FindObjectOfType<ship_move>();
        MovementVector = ShipMovement.newVector;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MovementVector * Time.deltaTime * 10;

        if (transform.position.x < -7 || transform.position.x > 7)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > 5.2 || transform.position.y < -5.2)
        {
            Destroy(gameObject);
        }
    }

}
