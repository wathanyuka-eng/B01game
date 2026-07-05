using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            gameManager.AddScore(); 
        }
    }
}