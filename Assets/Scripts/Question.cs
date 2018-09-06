using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Question")]
public class Question : ScriptableObject {

    [SerializeField] Question nextQuestion;
    [SerializeField] Sprite questionGraph;
    [SerializeField] Sprite[] answerGraphs;
    [SerializeField] int correctAnswer;

    public Question ReturnNextQuestion()
    {
        return nextQuestion;
    }

    public Sprite ReturnQuestionGraph()
    {
        return questionGraph;
    }

    public Sprite[] ReturnAnswerGraphs()
    {
        return answerGraphs;  
    }
    public int ReturnCorrectAnswer()
    {
        return correctAnswer;
    }
}
