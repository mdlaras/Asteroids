using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    [SerializeField] AudioSource crash_audio;
    public void GameOver()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayCrashSound(){
        crash_audio.Play(0);
    }
}
