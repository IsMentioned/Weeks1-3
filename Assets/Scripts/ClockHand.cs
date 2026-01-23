//Make a clock hour hand, add a script that makes it rotate at a speed you can set with a public variable.

using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(0.1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotation = transform.eulerAngles;
        Rotation.z -= rotationSpeed * Time.deltaTime;

        transform.eulerAngles = Rotation;

    }
}
