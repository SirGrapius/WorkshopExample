using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tutorial : MonoBehaviour
{
    [SerializeField] Rigidbody2D ball;
    [SerializeField] TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.bodyType = RigidbodyType2D.Static;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.Enter].wasPressedThisFrame)
        {
            Destroy(text);
            ball.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
