using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour {

    float correctAnswers;
    PreserveScore preserveScore;
    TextMeshProUGUI textDisplay;
    
    private void Start()
    {
        
        preserveScore = FindObjectOfType<PreserveScore>();
        correctAnswers = preserveScore.correctAnswers;
        textDisplay = FindObjectOfType<TextMeshProUGUI>();
        float scorePercentage = CalculateScore(correctAnswers, preserveScore.answerAtempts);
        ShowScore(scorePercentage);
    }

    private float CalculateScore(float correctAnswers, float answerAtempts)
    {
        float scorePercentage = (correctAnswers / answerAtempts) * 100;
        return scorePercentage;
    }

    public void ShowScore(float scorePercentage)
    {
        textDisplay.text = ("You scored a "+scorePercentage.ToString()+"%");
    }
}
