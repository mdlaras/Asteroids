using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_asteroids : MonoBehaviour
{
    [SerializeField] int asteroids_density;
    [SerializeField] asteroid_move big_asteroid;
    [SerializeField] asteroid_move medium_asteroid;
    [SerializeField] asteroid_move small_asteroid;

    void Instantiate_Random_Asteroids(Vector3 position){
        var size = Random.Range(1, 3);
        if(size == 1)
            {
                Instantiate(big_asteroid, position, Quaternion.identity);
            } 
            if(size == 2)
            {
                Instantiate(medium_asteroid, position, Quaternion.identity);
            }
            if(size == 3)
            {
                Instantiate(small_asteroid, position, Quaternion.identity);
            }
    }

    void Start()
    {
        for (int asteroid_iterator = 0; asteroid_iterator < asteroids_density; asteroid_iterator++)
        {
            var asteroid_position = new Vector3(Random.Range(-7, 7), Random.Range(-5, 4.9f), 0);
            Instantiate_Random_Asteroids(asteroid_position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var generator_randomizer = Random.Range(1,1000);

        if(generator_randomizer < asteroids_density/5)
        {
            var x_randomizer = Random.value;
            var y_randomizer = Random.value;
            var position_randomizer = Random.value;
            float asteroid_position_x;
            float asteroid_position_y;
            if(position_randomizer < 0.5)
            {
                if (y_randomizer < 0.5)
                {
                    asteroid_position_y = -5;
                }
                else
                {
                    asteroid_position_y = 4.8f;
                }
                asteroid_position_x = Random.Range(-7, 7);
            }
            else
            {
                if (x_randomizer < 0.5)
                {
                    asteroid_position_x = -7;
                }
                else
                {
                    asteroid_position_x = 7;
                }
                asteroid_position_y = Random.Range(-5, 4.9f);
            }

            

            var asteroid_position = new Vector3(asteroid_position_x, asteroid_position_y, 0);
            var size = Random.Range(1, 3);
            Instantiate_Random_Asteroids(asteroid_position);
        }
    }
}
