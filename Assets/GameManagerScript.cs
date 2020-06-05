using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManagerScript : MonoBehaviour
{
    public Questions[] questions;
    public States[] stateList;
    private static List<Questions> unansweredQuestions;
    private Questions currentQuestion;
    
    void Start() {
        if(unansweredQuestions == null){
                unansweredQuestions = questions.ToList<Questions>();
        }
        getRandomQuestion();
        Debug.Log(currentQuestion.prompt +" .Liberal Value = "+ currentQuestion.isLiberal+" bs");
    }
    void getRandomQuestion(){
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex]; 
        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }
    
}
