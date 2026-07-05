using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; 

public class Bird : MonoBehaviour
{
    [Header("Settings")]
    public float flyForce = 6f;

    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if ((Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame ||
             Pointer.current != null && Pointer.current.press.wasPressedThisFrame) && !isDead)
        {
            rb.linearVelocity = Vector2.up * flyForce;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (isDead) return;

        isDead = true;
        rb.linearVelocity = Vector2.zero;
        Debug.Log("Game Over! นกชนแล้ว กำลังเริ่มเกมใหม่...");

       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
