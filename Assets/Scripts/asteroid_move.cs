using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_move : MonoBehaviour
{
    Vector3 movement_vector;
    [SerializeField] float velocity;
    game_manager game;

    void Start()
    {
        movement_vector = new Vector3(Random.Range(-velocity,velocity), Random.Range(-velocity, velocity));
        game = FindObjectOfType<game_manager>();
    }

    void Update()
    {
        transform.position = transform.position + movement_vector * Time.deltaTime;

        game.Warp_Object(transform);
    }
}
