using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    [SerializeField] AudioSource crash_audio;
    public void End_Game()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }

    public void Restart_Game()
    {
        SceneManager.LoadScene(1);
    }

    public void Play_Crash_Sound(){
        crash_audio.Play(0);
    }

    public void Warp_Object(Transform object_tobe_warped){
        if (object_tobe_warped.position.x < -7 || object_tobe_warped.position.x > 7)
        {
            object_tobe_warped.position = new Vector3(object_tobe_warped.position.x * -1, object_tobe_warped.position.y, object_tobe_warped.position.z);
        }

        if (object_tobe_warped.position.y > 5.2 || object_tobe_warped.position.y < -5.2)
        {
            object_tobe_warped.position = new Vector3(object_tobe_warped.position.x, object_tobe_warped.position.y * -1, object_tobe_warped.position.z);
        }
    }
}
