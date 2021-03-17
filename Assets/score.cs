using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public int current_score = 0;
    public int highscore = 0;
    [SerializeField] TextMeshProUGUI score_text;
    [SerializeField] TextMeshProUGUI highscore_text;

    void Start()
    {
        score_text.text = current_score.ToString();
        highscore = PlayerPrefs.GetInt("highscore");
        highscore_text.text = highscore.ToString();
    }

    // Update is called once per frame
    public void Update_Score(int adder)
    {
        current_score += adder;
        score_text.text = current_score.ToString();
        if(current_score > highscore)
        {
            PlayerPrefs.SetInt("highscore", current_score);
            PlayerPrefs.Save();
            highscore_text.text = PlayerPrefs.GetInt("highscore").ToString();
        }
    }
}
