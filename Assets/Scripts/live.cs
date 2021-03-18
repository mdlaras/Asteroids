using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class live : MonoBehaviour
{
    [SerializeField] int lives_left;
    [SerializeField] Image[] health;
    [SerializeField] Sprite available_life;
    [SerializeField] Sprite disabled_life;
    [SerializeField] score score_manager;
    [SerializeField] TextMeshProUGUI game_over_text;
    [SerializeField] game_manager game_Manager;

    public void reduce_live(int reducer)
    {
        lives_left -= reducer;
        if(lives_left < 0)
        {
            game_Manager.End_Game();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        for (int health_iterator = 0; health_iterator < health.Length; health_iterator++)
        {
            
            if(health_iterator < lives_left)
            {
                health[health_iterator].sprite = available_life;
            }
            else
            {
                health[health_iterator].sprite = disabled_life;
            }
                
        }
    }
}
