using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate_asteroids : MonoBehaviour
{
    [SerializeField] int density;
    [SerializeField] asteroid_move big_ast;
    [SerializeField] asteroid_move med_ast;
    [SerializeField] asteroid_move small_ast;

    void Start()
    {
        for (int asteroid_iterator = 0; asteroid_iterator < density; asteroid_iterator++)
        {
            var ast_position = new Vector3(Random.Range(-7, 7), Random.Range(-5, 4.9f), 0);
            var size = Random.Range(1, 3);
            if(size == 1)
            {
                Instantiate(big_ast, ast_position, Quaternion.identity);
            } 
            if(size == 2)
            {
                Instantiate(med_ast, ast_position, Quaternion.identity);
            }
            if(size == 3)
            {
                Instantiate(small_ast, ast_position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        var generator_randomizer = Random.Range(1,1000);

        if(generator_randomizer < 2)
        {
            var randomizer_x = Random.value;
            var randomizer_y = Random.value;
            var post_randomizer = Random.value;
            float ast_position_x;
            float ast_position_y;
            if(post_randomizer < 0.5)
            {
                if (randomizer_y < 0.5)
                {
                    ast_position_y = -5;
                }
                else
                {
                    ast_position_y = 4.8f;
                }
                ast_position_x = Random.Range(-7, 7);
            }
            else
            {
                if (randomizer_x < 0.5)
                {
                    ast_position_x = -7;
                }
                else
                {
                    ast_position_x = 7;
                }
                ast_position_y = Random.Range(-5, 4.9f);
            }

            

            var ast_position = new Vector3(ast_position_x, ast_position_y, 0);
            var size = Random.Range(1, 3);
            if (size == 1)
            {
                Instantiate(big_ast, ast_position, Quaternion.identity);
            }
            if (size == 2)
            {
                Instantiate(med_ast, ast_position, Quaternion.identity);
            }
            if (size == 3)
            {
                Instantiate(small_ast, ast_position, Quaternion.identity);
            }
        }
    }
}
