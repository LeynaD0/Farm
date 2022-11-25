using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject menuCameraMode;
    [SerializeField]
    GameObject menuCreateMode;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalX(menuCreateMode, 1111f, 0f);
        LeanTween.moveLocalY(menuCameraMode, -600f, 0f);
        LeanTween.moveLocalY(menu, -650f, 0f);
        LeanTween.moveLocalY(menu, -400f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CameraMode()
    {
        LeanTween.moveLocalY(menu, -650f, 0.5f);
        LeanTween.moveLocalY(menuCameraMode, -486, 1f);
        
    }
    public void CancelCameraMode()
    {
        LeanTween.moveLocalY(menuCameraMode, -600f, 0.5f);
        LeanTween.moveLocalY(menu, -400f, 1f);
    }

    public void CreateMode()
    {
        LeanTween.moveLocalY(menu, -650f, 0.5f);
        LeanTween.moveLocalX(menuCreateMode, 810, 1f);
    }

    public void CancelCreateMode()
    {
        LeanTween.moveLocalX(menuCreateMode, 1111f, 0.5f);
        LeanTween.moveLocalY(menu, -400f, 1f);
    }
}
