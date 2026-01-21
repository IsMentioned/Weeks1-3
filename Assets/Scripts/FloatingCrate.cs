//Add a sprite to the scene. Make a new script and attach it to this game object. Write a timer that counts up to
//1 using a public speed variable.When the timer gets to 1, reset it to 0
//Declare a public AnimationCurve, use this curve with the timer variable to change the sprite’s Y position.
//Adjust the curve and timer speed variable till you have motion that makes it look like the sprite is bobbing up
//and down in the water.


using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class FloatingCrate : MonoBehaviour
{
    public float timer;
    public AnimationCurve wave;
    Vector3 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
        }
        position.y = wave.Evaluate(timer);
        transform.position = position;

    }
}