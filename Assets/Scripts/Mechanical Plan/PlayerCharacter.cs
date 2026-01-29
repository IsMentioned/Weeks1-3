using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    Camera main;
    Vector2 mousePosition;
    Vector2 objectPosition;
    Vector2 startPos = new Vector2(-3, 0);

    public bool timerIsRunning = false;
    public float activationTimer = 0;
    public bool active = false;
    float activeTimer;

    public AbilityCharge charge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Convert mouse position to world space vector
        mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // Timer runs if distance between the mouse and the object is less than 1.
        if (charge.abilityRecharged && Vector2.Distance(mousePosition, startPos) < 1)
        {
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning = false;
        }

        //If the timer has been runnning for at least 2 seconds, the object is 'active'.
        if (timerIsRunning)
        {
            activationTimer += Time.deltaTime;
        }
        else
        {
            activationTimer = 0;
        }
        if(activationTimer >= 2)
        {
            //Setting the 'ability recharged' to false ensures the 'active' state is only set once per charge.
            charge.abilityRecharged = false;
            active = true;
        }

        //Timer runs only when 'active'.
        if (active)
        {
            activeTimer += Time.deltaTime;
        }
        else
        {
            activeTimer = 0;
        }

        //Active phase ends after 0.5 seconds.
        if (activeTimer > 0.5f)
        {
            active = false;
        }
    }
}
