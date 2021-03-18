using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_move : MonoBehaviour
{
    ship_move ship_movement;
    public Vector3 movement_vector;

    // Start is called before the first frame update
    void Start()
    {
        ship_movement = FindObjectOfType<ship_move>();
        movement_vector = ship_movement.new_ship_position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movement_vector * Time.deltaTime * 10;

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
