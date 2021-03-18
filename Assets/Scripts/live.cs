﻿using System.Collections;
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
            game_Manager.GameOver();
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