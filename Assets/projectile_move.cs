using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_move : MonoBehaviour
{
    [SerializeField] ship_move ShipMovement;
    public Vector3 MovementVector;

    // Start is called before the first frame update
    void Start()
    {
        MovementVector = ShipMovement.newVector;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MovementVector * Time.deltaTime * 10;
    }
}
