using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManagerScript : MonoBehaviour
{
    public Questions[] questions;
    public States[] stateList;
    private static List<States> unusedState;
    private static List<Questions> unansweredQuestions;
    private Questions currentQuestion;
    private States currentState;

    [SerializeField]
    private Text promptText;
    [SerializeField]
    private Text promptNumText;
    [SerializeField]
    private Text stateTitleText;
    [SerializeField]
    private Text roundTitleText;
    [SerializeField]
    private Text ScoreTitleText;
    [SerializeField]
    private Slider scoreBar;

    public int promptNum=0;
    public int roundNum=0;
    public int score=50;

    void Start() {
        
        if(unansweredQuestions == null){
                unansweredQuestions = questions.ToList<Questions>();
                unusedState = stateList.ToList<States>();
        }
        getRandomQuestion();
        updatePrompt();
        updateScore();
        getRandomState();
        Debug.Log(currentQuestion.prompt +" .Liberal Value = "+ currentQuestion.isLiberal+" bs");
        
    }

    void getRandomQuestion(){
       
        
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        //Find a better place to remove the current question. Preferably after the question is answered 
        //unansweredQuestions.RemoveAt(randomQuestionIndex);
    }

    void getRandomState(){
        roundNum = roundNum + 1;
        roundTitleText.text = "ROUND "+ roundNum;
        int randomStateIndex = Random.Range(0, unusedState.Count);
        currentState = unusedState[randomStateIndex];
        stateTitleText.text = currentState.stateName;
    }

    public void updatePrompt(){
        promptNum = promptNum + 1;
        getRandomQuestion();
        promptText.text = currentQuestion.prompt;
        promptNumText.text = "Prompt Number "+promptNum+"/3";
        
    }

    public void updateScore(){
        if(score < 0){
            score = 0;
        }
        ScoreTitleText.text = "Polling Points: "+score+"%";
        scoreBar.value = score;
    }

    public void agreeButtonClicked(){
        if(currentState.isLiberal == currentQuestion.isLiberal){
                score=score+10;
        }else{
                score=score-10;
        }
        updateScore();
        updatePrompt();
    }

    public void disagreeButtonClicked(){
        if(currentState.isLiberal == currentQuestion.isLiberal){
                score=score-10;
        }else{
                score=score+10;
        }
        updateScore();
        updatePrompt();
    }

    public void neutralButtonClicked(){
        updateScore();
        updatePrompt();
    }


    
}


