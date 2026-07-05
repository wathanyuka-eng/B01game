using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Settings")]
    public float speed = 3f;      
    public float deadZone = -15f; 

    void Update()
    {
        
        transform.position += Vector3.left * speed * Time.deltaTime;

        
        if (transform.position.x < deadZone)
        {
            
            Destroy(gameObject);
        }
    }
}