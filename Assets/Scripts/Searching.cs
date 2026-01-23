//Write a script to move a sprite:
//• Declare two Vector2 variables, one for the starting position and one for the destination
//• In Start set the starting position with the transform position of the sprite, and pick a random position
//for the destination
//• In Update use Lerp to move from the starting position to the destination

//When the shape arrives at the destination call a function that:
//• Updates the starting position to be its current position
//• Picks a new random position for the destination
//• Resets the t variable for your timer so the shape keeps moving

using UnityEngine;

public class Searching : MonoBehaviour
{
    Vector2 StartingPos;
    Vector2 EndPos;
    public float progress = 0;
    public Vector2 output;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartingPos = transform.position;
        EndPos = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / 2f;
        output = Vector2.Lerp(StartingPos, EndPos, progress);
        transform.position = output;
        if (progress > 1)
        {
            StartingPos = transform.position;
            EndPos = new Vector2(Random.Range(-5, 5), Random.Range(-5, -5));
            progress = 0;
        }
    }
}
