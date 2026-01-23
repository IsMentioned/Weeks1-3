using UnityEngine;
using UnityEngine.InputSystem;


public class Controller : MonoBehaviour
{
    Vector2 position;
    Vector3 rotation;

    public float moveSpeed;
    public float rotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if (leftIsHeld)
        {
            Debug.Log("Left mose is held");
        }
        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftIsPressed)
        {
            Debug.Log("Left mouse is pressed");
        }
        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released");
        }

        bool upArrowIsHeld = Keyboard.current.upArrowKey.isPressed;
        bool downArrowIsHeld = Keyboard.current.downArrowKey.isPressed;
        bool leftArrowIsHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowIsHeld = Keyboard.current.rightArrowKey.isPressed;


        if (upArrowIsHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        if (downArrowIsHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        Vector3 rotation = transform.eulerAngles;
        
        if (leftArrowIsHeld)
        {
            transform.eulerAngles += transform.forward * rotateSpeed * Time.deltaTime;
        }
        if (rightArrowIsHeld)
        {
            transform.eulerAngles -= transform.forward * rotateSpeed * Time.deltaTime;
        }

    }
}
