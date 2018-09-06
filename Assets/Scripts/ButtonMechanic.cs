using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMechanic : MonoBehaviour {

   
    QuestionMechanic counter;
    int currentScene;
    

    public void Start()
    {
        counter = FindObjectOfType<QuestionMechanic>();
        currentScene = SceneManager.GetActiveScene().buildIndex;
       
    }

   
    public void Quit()
    {
        Application.Quit();
    }

   public void CountAnswers()
    {
        counter.answerAtempts++;
    }
    public void ButtonA()
    {
        counter.guessedAnswer = 0;
        CountAnswers();
    }
    public void ButtonB()
    {
        counter.guessedAnswer = 1;
        CountAnswers();
    }
    public void ButtonC()
    {
        counter.guessedAnswer = 2;
        CountAnswers();
    }
    public void ButtonD()
    {
        counter.guessedAnswer = 3;
        CountAnswers();
    }

    public void RestartGame()
    {
        GameObject scoreObject = GameObject.Find("Score Object");
        Destroy(scoreObject);
        SceneManager.LoadScene(1);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
}

