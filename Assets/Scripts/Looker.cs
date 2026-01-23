//WEEK THREE
using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float rotationSpeed;
    public float zMax, zMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ROTATING IN A DIRECTION (SWAPPING)

        ////If we wanted to move the object, we would use transform.position
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;

        //transform.eulerAngles = currentRotation;

        //if (transform.eulerAngles.z > zMax)
        //{
        //    rotationSpeed *= -1;
        //}
        //if (transform.eulerAngles.z < zMin)
        //{
        //    rotationSpeed *= -1;
        //}

        //Debug.Log(transform.eulerAngles);

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //Setting the direction we're looking in
        //To get the direction , we subtract the position of the object from the position of the mouse
        transform.up = worldMousePosition - transform.position;

        transform.position += transform.up * 1f * Time.deltaTime;
    }
}