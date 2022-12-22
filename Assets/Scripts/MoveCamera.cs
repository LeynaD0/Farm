using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Vector3 elMousePosition;
    public float cameraSpeed = 2.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            FuncionMoverCamara();
        }
        elMousePosition = Input.mousePosition;
    }

    void FuncionMoverCamara()
    {
        Vector3 deltaPos = elMousePosition - Input.mousePosition;

        Camera.main.transform.position += new Vector3 (deltaPos.x, 0.0f, deltaPos.y)  * cameraSpeed * Time.deltaTime;
    }
}
