using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.GetComponent<BirdController>() != null)
        {
            
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore();
            }
        }
    }
}