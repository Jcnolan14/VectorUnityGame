using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreserveScore : MonoBehaviour {

    public float correctAnswers;
    public float answerAtempts;
    QuestionMechanic questionMechanic;

    private void Awake()
    {
        GameObject scoreObject = GameObject.Find("Score Objcet");
        if (!(scoreObject == null))
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            questionMechanic = FindObjectOfType<QuestionMechanic>();
        }
    }


    private void Update()
    {
        if (!(questionMechanic.nextQuestion == null)) {
            answerAtempts = questionMechanic.answerAtempts;
            correctAnswers = questionMechanic.correctAnswers;
        }         
    }
}
