using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_move : MonoBehaviour
{
    [SerializeField] Transform shipBody;
    [SerializeField] GameObject Projectile;
    float shipZAngleSnapShot;
    float shipZAngle;
    public Vector3 newVector;
    public GameObject ProjectileClone;
    Vector3 Offset;
    float x2;
    float y2;
    float velocity;
    Vector3 AccumulatedVelocity;

    void Start()
    {
        velocity = 2f;
        shipZAngle = shipBody.rotation.z;
        shipZAngleSnapShot = shipZAngle;
        newVector = new Vector3(0, 1, 0f);
    }

    void Update()
    {
        if (velocity > 1)
        {
            velocity -= 0.05f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            shipZAngle = -90*Time.deltaTime * 5;
            shipZAngleSnapShot += shipZAngle;
            shipBody.eulerAngles = new Vector3(0, 0, shipZAngleSnapShot);
            x2 = ( Mathf.Sin(shipZAngleSnapShot * Mathf.Deg2Rad + Mathf.PI));
            y2 = ( Mathf.Cos(shipZAngleSnapShot * Mathf.Deg2Rad));
            newVector = new Vector3(x2, y2, 0f);
        } 
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            shipZAngle = 90 * Time.deltaTime *5 ;
            shipZAngleSnapShot += shipZAngle;
            shipBody.eulerAngles = new Vector3(0, 0, shipZAngleSnapShot);
            x2 = (Mathf.Sin(shipZAngleSnapShot * Mathf.Deg2Rad + Mathf.PI));
            y2 = (Mathf.Cos(shipZAngleSnapShot * Mathf.Deg2Rad));
            newVector = new Vector3(x2, y2, 0f);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3.Normalize(newVector);
            AccumulatedVelocity += newVector * velocity;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Offset = newVector * 0.5f;
            ProjectileClone = Instantiate(Projectile);
            ProjectileClone.transform.position = shipBody.position + Offset;
            ProjectileClone.transform.eulerAngles = shipBody.eulerAngles;
        }
        
        shipBody.position += AccumulatedVelocity * Time.deltaTime;

        if (shipBody.position.x < -7 || shipBody.position.x > 7)
        {
            shipBody.position = new Vector3(shipBody.position.x * -1, shipBody.position.y, shipBody.position.z);
        }

        if (shipBody.position.y > 5.2 || shipBody.position.y < -5.2)
        {
            shipBody.position = new Vector3(shipBody.position.x, shipBody.position.y * -1, shipBody.position.z);
        }
    }
}
