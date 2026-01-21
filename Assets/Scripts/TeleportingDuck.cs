//Add a sprite to the scene. Make a new script and attach it to this game object. Write a timer script that
//counts up to 3 seconds. When the time is up, set the transform position to a new random position and restart
//the timer.

using UnityEngine;

public class TeleportingDuck : MonoBehaviour
{
    Vector3 location;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            timer = 0;
            location = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);
            transform.position = location;
        }
    }
}