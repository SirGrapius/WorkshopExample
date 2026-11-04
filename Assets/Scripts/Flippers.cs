using UnityEngine;
using UnityEngine.InputSystem;

public class Flippers : MonoBehaviour
{
    [SerializeField] Rigidbody2D rightFlipper;
    [SerializeField] Rigidbody2D leftFlipper;
    
    [SerializeField] float maxRightRotation;
    [SerializeField] float minRightRotation;
    [SerializeField] float maxLeftRotation;
    [SerializeField] float minLeftRotation;

    [SerializeField] float rotationSpeed;

    
    void Update()
    {
        if (Keyboard.current[Key.W].isPressed && leftFlipper.rotation <= maxLeftRotation)
        {
            leftFlipper.rotation += rotationSpeed * Time.deltaTime;
        }
        if (Keyboard.current[Key.S].isPressed && leftFlipper.rotation >= minLeftRotation)
        {
            leftFlipper.rotation -= rotationSpeed * Time.deltaTime;
        }
        
        if (Keyboard.current[Key.UpArrow].isPressed && rightFlipper.rotation >= maxRightRotation)
        {
            rightFlipper.rotation -= rotationSpeed * Time.deltaTime;
        }
        if (Keyboard.current[Key.DownArrow].isPressed && rightFlipper.rotation <= minRightRotation)
        {
            rightFlipper.rotation += rotationSpeed * Time.deltaTime;
        }
    }
}
