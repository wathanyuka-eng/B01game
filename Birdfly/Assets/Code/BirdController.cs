using UnityEngine;
using UnityEngine.InputSystem; 
using UnityEngine.SceneManagement; 

public class BirdController : MonoBehaviour
{
    public float flapForce = 4.5f; 
    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        bool isActionPressed = false;
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame ||
            Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            isActionPressed = true;
        }

        
        if (isActionPressed && !isDead)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            rb.velocity = Vector2.up * flapForce;
        }

        
        if (isActionPressed && isDead)
        {
            RestartGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (!isDead)
        {
            isDead = true;
            Debug.Log("Game Over! Press Space/Click to Restart.");

            
            Time.timeScale = 0f;
        }
    }

    void RestartGame()
    {
        Time.timeScale = 1f; 
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}