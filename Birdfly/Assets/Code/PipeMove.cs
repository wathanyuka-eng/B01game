using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 3.5f;   
    public float deadZone = -15f; 

    void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}