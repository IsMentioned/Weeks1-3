using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0.01f;
    public float xMax = 200;
    public float xMin = -200;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        Debug.Log("moverXPos["+moverXPos.x.ToString()+"], xMin["+xMin.ToString()+"] speed["+speed.ToString()+"]");

        if (transform.position.x > xMax && speed > 0)
            speed = -speed;
        if (transform.position.x < xMin && speed < 0)
            speed = -speed;

    }
}
