using UnityEngine;

public class FinishPlatformSegment : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            Debug.Log("Ball has reached final platform.");
        }
    }
}
