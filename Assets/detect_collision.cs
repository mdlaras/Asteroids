using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_collision : MonoBehaviour
{
    [SerializeField] float collision_boundary;
    [SerializeField] make_child childmaker;
    [SerializeField] bool is_asteroid;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (is_asteroid is true)
        {
            var projectiles = FindObjectsOfType<projectile_move>();
            foreach (projectile_move projectile in projectiles)
            {
                var projectile_relative_position = Mathf.Pow(projectile.transform.position.x - transform.position.x, 2) + Mathf.Pow(projectile.transform.position.y - transform.position.y, 2);
                if (projectile_relative_position < collision_boundary)
                {
                    Destroy(projectile.gameObject);
                    childmaker.instantiate_child(transform);
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            var asteroids = FindObjectsOfType<asteroid_move>();
            foreach (asteroid_move asteroid in asteroids)
            {
                var asteroid_relative_position = Mathf.Pow(asteroid.transform.position.x - transform.position.x, 2) + Mathf.Pow(asteroid.transform.position.y - transform.position.y, 2);
                if (asteroid_relative_position < collision_boundary)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
