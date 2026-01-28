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
    public bool monsterHit = false;

    public AnimationCurve curve;

    public AbilityCharge charge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCharacter.active && !spellDepleted)
        {
            runTimer += Time.deltaTime * 4;

            location = Vector2.Lerp(startPos, endPos, runTimer);

            size = curve.Evaluate(runTimer);

            if(runTimer > 1)
            {
                size = 0;
                spellDepleted = true;
                monsterHit = true;
            }

            transform.position = location;
            transform.localScale = Vector3.one * size;

        }
        else
        {
            runTimer = 0;
        }
        if (charge.abilityRecharged)
        {
            spellDepleted = false;
        }

    }
}
