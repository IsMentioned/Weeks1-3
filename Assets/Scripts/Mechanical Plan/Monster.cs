using System.Threading;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class Monster : MonoBehaviour
{
    public Spell spell;
    float runTimer;
    float output;

    Vector2 aPos = new Vector2(3, 0);
    Vector2 bPos = new Vector2(5, 0);

    Vector2 location = new Vector2(3, 0);

    public AnimationCurve stun;
    public AnimationCurve move1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = aPos;
    }

    // Update is called once per frame
    void Update()
    {
        //If the monster is hit, the object enters a sequence of actions.
        if (spell.monsterHit)
        {
            runTimer += Time.deltaTime;

            // The monsters lerps backwards quickly.
            if (runTimer > 0.01 && runTimer < 0.25)
            {
                output = move1.Evaluate(runTimer * 4);
                location = Vector2.Lerp(aPos, bPos, output);
            }

            //The monster shakes an anger using an Animation Curve.
            if (runTimer > 0.75 && runTimer < 1.25)
            {
                output = stun.Evaluate((runTimer - 0.75f) * 2);
                location.x = 5 + output;
            }

            //The monster advances towards the player using a Lerp.
            if (runTimer > 1.25 && runTimer < 2.25)
            {
                location = Vector2.Lerp(bPos, aPos, runTimer - 1.25f);
            }

            //The sequence ends.
            if (runTimer > 2.25)
            {
                spell.monsterHit = false;
            }
        }
        else
        {
            runTimer = 0;
        }
            transform.position = location;

    }
}
