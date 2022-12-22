using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public enum Modos
    {
        EnEspera,
        MoverCamara,
        CrearObjeto,
        MoverObjeto,
        SoltarObjeto,
        EsperaTrasCrear
    }

    public GameObject objetoSeleccionado;

    [SerializeField]
    Modos modo = Modos.EnEspera;
    [SerializeField]
    GameObject camera;
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject menuCameraMode;
    [SerializeField]
    GameObject menuCreateMode;

    GameObject camara;

    private void Start()
    {
        LeanTween.moveLocalX(menuCreateMode, 1111f, 0f);
        LeanTween.moveLocalY(menuCameraMode, -600f, 0f);
        LeanTween.moveLocalY(menu, -650f, 0f);
        LeanTween.moveLocalY(menu, -400f, 0.5f);
    }

    private void Update()
    {
        switch (modo)
        {
            case Modos.EnEspera:
                modo = Modos.EnEspera;
                break;
        }
    }

    public void CameraMode()
    {
        LeanTween.moveLocalY(menu, -650f, 0.5f);
        LeanTween.moveLocalY(menuCameraMode, -486, 1f);
        modo = Modos.MoverCamara;
    }
    public void CancelCameraMode()
    {
        LeanTween.moveLocalY(menuCameraMode, -600f, 0.5f);
        LeanTween.moveLocalY(menu, -400f, 1f);
        modo = Modos.EnEspera;
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
        modo = Modos.EnEspera;
    }
    public void CrearObjecto(GameObject objectoACrear)
    {
        objetoSeleccionado = Instantiate(objectoACrear, Vector3.zero, Quaternion.identity);
        modo = Modos.EsperaTrasCrear;
    }


}
