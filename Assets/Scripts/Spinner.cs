using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        rb.rotation += speed * Time.deltaTime;
    }
}
