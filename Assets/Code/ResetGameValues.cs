using UnityEngine;

public class ResetGameValues : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<ScoreManager>().SetScore(0);
    }
}
