using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class live : MonoBehaviour
{
    [SerializeField] int lives_left;
    [SerializeField] Image[] health;
    [SerializeField] Sprite available_life;
    [SerializeField] Sprite disabled_life;
 
    public void reduce_live(int reducer)
    {
        lives_left -= reducer;
        if(lives_left < 0)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        for (int healthiterator = 0; healthiterator < health.Length; healthiterator++)
        {
            
            if(healthiterator < lives_left)
            {
                health[healthiterator].sprite = available_life;
            }
            else
            {
                health[healthiterator].sprite = disabled_life;
            }
                
        }
    }
}
