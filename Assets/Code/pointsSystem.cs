using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    string pointsKey = "Points";
    public int CurrentPoints { get; set; }

    private void Awake()
    {
        CurrentPoints = PlayerPrefs.GetInt(pointsKey);
    }

    public void SetPoint(int points)
    {
        PlayerPrefs.SetInt(pointsKey, points);
    }
}
