using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionMechanic : MonoBehaviour {

    [SerializeField] Button[] answerButtons;
    [SerializeField] Question currentQuestion;
    public Question nextQuestion;
    Sprite questionGraph;
    [SerializeField] Image graphSpace;
    Sprite[] answerGraphs;
    public float answerAtempts;
    int correctAnswer;
    public int guessedAnswer = -1;
    public float correctAnswers;
    

    private void Start()
    {
        GetQuestionComponents();
        DisplayQuestion();
    }

    public void Update()
    {
        CheckAnswer();
        NoMoreQuestions();
    }

    public void GetQuestionComponents()
    {// gets components of question for use
        nextQuestion = currentQuestion.ReturnNextQuestion();
        questionGraph = currentQuestion.ReturnQuestionGraph();
        answerGraphs = currentQuestion.ReturnAnswerGraphs();
        correctAnswer = currentQuestion.ReturnCorrectAnswer();
    }

    public void DisplayQuestion()
    {
        //Displays graph user bases answer off of
        graphSpace.sprite = questionGraph;

        //Assigns graph image to the answer buttons
        for (int i = 0; i < answerGraphs.Length; i++)
        {
            Button currentButton = answerButtons[i];
            currentButton.image.sprite = answerGraphs[i];
        }
    }

    public void UpdateQuestion()
    {// Changes to next qestion and gets realtive components and displays
        correctAnswers++;
        currentQuestion = nextQuestion;
        GetQuestionComponents();
        DisplayQuestion();
        guessedAnswer = -1;
        
    }

    public void CheckAnswer()
    {
        if (guessedAnswer == correctAnswer)
        {
            UpdateQuestion();
        } 
    }
    public IEnumerable<WaitForSeconds> NoMoreQuestions()
    {
        if (nextQuestion == null)
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
