using UnityEngine;

public class Spell : MonoBehaviour
{
    Vector2 startPos = new Vector2(-3, 0);
    Vector2 endPos = new Vector2(3, 0);
    Vector2 location;
    public float size;
    
    public PlayerCharacter playerCharacter;
    float runTimer = 0;
    bool spellDepleted = false;

    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCharacter.active && !spellDepleted)
        {
            runTimer += Time.deltaTime;

            location = Vector2.Lerp(startPos, endPos, runTimer * 4);
            transform.position = location;

            size = curve.Evaluate(runTimer * 4);
            transform.localScale = Vector3.one * size;

        }
        else
        {
            runTimer = 0;
        }

    }
}
