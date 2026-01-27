using UnityEngine;

public class AbilityCharge : MonoBehaviour
{
    public PlayerCharacter playerCharacter;
    public float rechargeTimer;
    Vector2 startPos = new Vector2(-4, -1.5f);
    Vector2 endPos = new Vector2(-4, 0f);
    Vector2 location = new Vector2(-4, 0);
    Vector2 size = new Vector2(1, 1);
    public bool abilityRecharged = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (abilityRecharged == false)
        {
            rechargeTimer += Time.deltaTime;
            location = Vector2.Lerp(startPos, endPos, rechargeTimer /3);
            size.y = Mathf.Lerp(0, 1, rechargeTimer /3);


        }

        if(rechargeTimer > 3)
        {
            abilityRecharged = true;
            rechargeTimer = 0;
        }

        transform.position = location;
        transform.localScale = size;
    }
}
