using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Cinemachine;

public class questionOne : MonoBehaviour
{
    public GameObject nextQuestion;
    public GameObject currentQuestion;
    public GameObject currentHitbox;
    public GameObject nextHitbox;
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject questionNumber;
    public GameObject BG_Regular;
    public GameObject BG_Incorrect;
    public GameObject popUp;


void completeQuestion()
    {
        nextQuestion.SetActive(true);
        nextHitbox.SetActive(true);
        tennaTV.SetActive(true);
        BG_Regular.SetActive(true);
        currentHitbox.SetActive(false);
        currentQuestion.SetActive(false);
        correctAnswer.SetActive(false);
        wrongAnswer.SetActive(false);
        BG_Incorrect.SetActive(false);
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
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                correctAnswer.SetActive(true);


            }
            else if(gameObject.tag == "Incorrect")
            {

                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                wrongAnswer.SetActive(true);
                BG_Incorrect.SetActive(true);
                BG_Regular.SetActive(false);
                CameraShakeManager.Instance.Shake(2f, 1f);
            }
    }
}


}