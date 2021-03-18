using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_collision : MonoBehaviour
{
    [SerializeField] float collision_boundary;
    [SerializeField] make_child childmaker;
    [SerializeField] bool is_asteroid;
    [SerializeField] live live;
    [SerializeField] float collision_timespan;
    [SerializeField] Animator hit_animator;
    score score_manager;
    [SerializeField] int hit_score;
    bool collided=false;
    float collision_time = 0;


    // Start is called before the first frame update
    void Start()
    {
        score_manager = FindObjectOfType<score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - collision_time > collision_timespan && collided==true)
        {
            collided = false;
            hit_animator.SetBool("Ship Hit", false);
        }

        if (is_asteroid is true)
        {
            var projectiles = FindObjectsOfType<projectile_move>();
            foreach (projectile_move projectile in projectiles)
            {
                var projectile_relative_position = Mathf.Pow(projectile.transform.position.x - transform.position.x, 2) + Mathf.Pow(projectile.transform.position.y - transform.position.y, 2);
                if (projectile_relative_position < collision_boundary)
                {
                    Destroy(projectile.gameObject);
                    score_manager.Update_Score(hit_score);
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
                if (asteroid_relative_position < collision_boundary && collided ==false)
                {
                    live.reduce_live(1);
                    collided = true;
                    hit_animator.SetBool("Ship Hit", true);
                    collision_time= Time.time;
                }
            }
        }
    }
}
