using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionThree : MonoBehaviour
{
    public GameObject nextQuestion;
    public GameObject currentQuestion;
    public GameObject currentHitbox;
    public GameObject nextHitbox;
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject questionNumber;
    public GameObject popUp;
    

    // [SerializeField]
    // private TMP_Text pointsText;
    // int points;
    // PointsSystem pointsSystem;

void Start()
    {
        // pointsSystem = FindObjectOfType<PointsSystem>();
        // points = pointsSystem.CurrentPoints;
        // pointsText.text = points + "";
    }


void completeQuestion()
    {
        nextQuestion.SetActive(true);
        nextHitbox.SetActive(true);
        currentHitbox.SetActive(false);
        currentQuestion.SetActive(false);
        correctAnswer.SetActive(false);
        wrongAnswer.SetActive(false);
        tennaTV.SetActive(true);
    }

void DeletePopup()
{
    popUp.SetActive(false);
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("completeQuestion", 1);
        Invoke("DeletePopup", 1);
        
        if(gameObject.tag == "Correct")
            {
                Debug.Log("yay");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                correctAnswer.SetActive(true);

                // points += 100;
                // pointsText.text = points + "";
                // pointsSystem.SetPoint(points);
            }
            else if(gameObject.tag == "Incorrect")
            {
                Debug.Log("boo");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                wrongAnswer.SetActive(true);
            }
    }
}


}