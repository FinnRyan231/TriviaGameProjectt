using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finalQThree : MonoBehaviour
{
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject BG_Regular;
    public GameObject BG_Incorrect;
    public GameObject questionNumber;

void finalQuestion()
    {
        SceneManager.LoadScene(2);
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("finalQuestion", 1);
        
        if(gameObject.tag == "Correct")
            {
                Debug.Log("yay");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                correctAnswer.SetActive(true);
            }
            else if(gameObject.tag == "Incorrect")
            {
                Debug.Log("boo");
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