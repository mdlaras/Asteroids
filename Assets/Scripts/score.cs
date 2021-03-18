using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public int current_score = 0;
    public int high_score = 0;
    [SerializeField] TextMeshProUGUI score_text;
    [SerializeField] TextMeshProUGUI highscore_text;

    void Start()
    {
        score_text.text = current_score.ToString();
        high_score = PlayerPrefs.GetInt("highscore");
        highscore_text.text = high_score.ToString();
    }

    // Update is called once per frame
    public void Update_Score(int score_adder)
    {
        current_score += score_adder;
        score_text.text = current_score.ToString();
        if(current_score > high_score)
        {
            PlayerPrefs.SetInt("highscore", current_score);
            PlayerPrefs.Save();
            highscore_text.text = PlayerPrefs.GetInt("highscore").ToString();
        }
    }
}
