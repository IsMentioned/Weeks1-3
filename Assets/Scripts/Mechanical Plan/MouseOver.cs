using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class MouseOver : MonoBehaviour
{
    public PlayerCharacter playerCharacter;
    float size;
    float loadTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Displays a growing circle in sync with the 'player character' active state initialization.
        if (playerCharacter.timerIsRunning)
        {
            loadTimer += Time.deltaTime /2;
            size = Mathf.Lerp(0, 0.1f, loadTimer);
        }
        else
        {
            loadTimer = 0;
            size = 0;
        }
            transform.localScale = Vector2.one * size;
    }
}
