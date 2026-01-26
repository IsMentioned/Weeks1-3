using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    Camera main;
    Vector2 mousePosition;
    Vector2 objectPosition;

    bool abilityRecharged = true;
    public bool timerIsRunning = false;
    public float activationTimer = 0;
    public bool active = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        objectPosition = (Vector2)transform.position;

        if (abilityRecharged && Vector2.Distance(mousePosition, objectPosition) < 1)
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
            abilityRecharged = false;
            active = true;
        }
        //if (active)
        //{
        //
        //}
    }
}
