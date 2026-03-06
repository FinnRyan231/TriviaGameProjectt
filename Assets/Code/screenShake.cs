using UnityEngine;

public class screenShake : MonoBehaviour
{
    public Animator canAnim;

    public void CamShake()
    {
        canAnim.SetTrigger("shake");
    }
}
