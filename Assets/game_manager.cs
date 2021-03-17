using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    public void GameOver()
    {
        
        var current_score = GetComponent<score>().current_score;
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        var score_text = FindObjectsOfType<TextMeshProUGUI>()[1];
        score_text.text = current_score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
