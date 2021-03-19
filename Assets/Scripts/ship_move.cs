using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_move : MonoBehaviour
{
    [SerializeField] Transform ship_body;
    [SerializeField] GameObject projectile;
    [SerializeField] Animator ship_animator; 
    float ship_z_angle_snapshot;
    float ship_z_angle;
    public Vector3 new_ship_position;
    public GameObject projectile_clone;
    Vector3 ship_offset;
    float new_ship_x_position;
    float new_ship_y_position;
    float velocity;
    Vector3 accumulated_velocity;
    float ship_thrust_timer;
    game_manager game;

    void Start()
    {
        velocity = 2f;
        ship_z_angle = ship_body.rotation.z;
        ship_z_angle_snapshot = ship_z_angle;
        new_ship_position = new Vector3(0, 1, 0f);
        game = FindObjectOfType<game_manager>();
    }

    void Rotate_Ship(string direction){
        if(direction.Equals("right")){
            ship_z_angle = -90*Time.deltaTime * 5;
        }
        else if(direction.Equals("left")){
            ship_z_angle = 90 * Time.deltaTime *5 ;
        }
        ship_z_angle_snapshot += ship_z_angle;
        ship_body.eulerAngles = new Vector3(0, 0, ship_z_angle_snapshot);
        new_ship_x_position = (Mathf.Sin(ship_z_angle_snapshot * Mathf.Deg2Rad + Mathf.PI));
        new_ship_y_position = (Mathf.Cos(ship_z_angle_snapshot * Mathf.Deg2Rad));
        new_ship_position = new Vector3(new_ship_x_position, new_ship_y_position, 0f);
    }
    void Update()
    {
        
        if (velocity > 1)
        {
            velocity -= 0.05f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate_Ship("right");
        } 
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate_Ship("left");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3.Normalize(new_ship_position);
            accumulated_velocity += new_ship_position * velocity;
            ship_animator.SetBool("Up Arrow", true);
            ship_thrust_timer = Time.time;
        }

        if (Time.time - ship_thrust_timer > 0.5f)
        {
            ship_animator.SetBool("Up Arrow", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ship_offset = new_ship_position * 0.5f;
            projectile_clone = Instantiate(projectile, ship_body.position + ship_offset, Quaternion.identity);
            projectile_clone.transform.eulerAngles = ship_body.eulerAngles;
        }
        
        ship_body.position += accumulated_velocity * Time.deltaTime;

        game.Warp_Object(ship_body);
    }
}
