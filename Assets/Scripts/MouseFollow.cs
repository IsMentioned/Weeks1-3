using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollow : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //Using the camera to convert the mouse posision from screen space (pixels) to mouse space (gameObjects)
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        transform.position = worldMousePosition;

        //Screen.width;
        //Screen.height;
        //gameCamera.WorldToScreenPoint(//somerandomvector));

    }
}
