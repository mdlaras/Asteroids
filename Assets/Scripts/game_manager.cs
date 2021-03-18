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
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
