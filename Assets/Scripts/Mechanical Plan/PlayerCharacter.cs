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
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        objectPosition = (Vector2)transform.position;

        if (charge.abilityRecharged && Vector2.Distance(mousePosition, objectPosition) < 1)
        {
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning = false;
        }
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
            charge.abilityRecharged = false;
            active = true;
        }
        if (active)
        {
            activeTimer += Time.deltaTime;
        }
        else
        {
            activeTimer = 0;
        }
        if(activeTimer > 0.5f)
        {
            active = false;
        }
    }
}
