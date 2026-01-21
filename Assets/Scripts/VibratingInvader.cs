//Add a sprite to the scene. Make a new script and attach it to this game object.
//• If the mouse position is near the shape (use Vector2.Distance) set a “timer is running” bool to true
//• If the “timer is running” variable is true, make a timer variable count up in seconds
//• If the mouse moves away from the shape, set the “timer is running” bool to false and reset the timer
//variable to 0
//Declare a public AnimationCurve.When the timer is running use the curve and the timer variable to change the
//sprite’s position or localScale variable so that it vibrates when the mouse is over it.


using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class VibratingInvader : MonoBehaviour
{
    Camera main;
    Vector2 mousePosition;
    Vector2 objectPosition;
    bool timerIsRunning = false;
    public float timer;
    public AnimationCurve vibrate;
    public Vector3 scale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        objectPosition = (Vector2)transform.position;

        if (Vector2.Distance(mousePosition, objectPosition) < 2)
        {
            timerIsRunning = true;
        } else
        {
            timerIsRunning = false;
        }
        if (timerIsRunning)
        {
            timer += Time.deltaTime;
        } else
            timer = 0;

        //Assign the vertical component o 'Scale' to the animation curve.
        scale.x = vibrate.Evaluate(timer);
        scale.y = vibrate.Evaluate(timer);

        //Set the scale of the object to 'Scale'.
        transform.localScale = scale;



    }
}