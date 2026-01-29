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

    }

    // Update is called once per frame
    void Update()
    {
        //Spell activates once if the player character is currently 'active'.
        if (playerCharacter.active && !spellDepleted)
        {
            runTimer += Time.deltaTime * 4;

            //Moves the spell from left to right using a Lerp.
            location = Vector2.Lerp(startPos, endPos, runTimer);

            //Increases the vertical scale of the spell using an Animation Curve.
            size = curve.Evaluate(runTimer);

            //After 1 second, the monster is considered hit and the spell is depleted.
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

        //Spell is reset when the ability is recharged.
        if (charge.abilityRecharged)
        {
            spellDepleted = false;
        }

    }
}
