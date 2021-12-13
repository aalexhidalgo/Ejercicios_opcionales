using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color MyColor;

    // Start is called before the first frame update
    void Start()
    {
        //Accedemos al material, al color
        GetComponent<MeshRenderer>().material.color = MyColor;
    }

    //Cuando presionemos encima del material se transformará el color del fondo con el color del material
    private void OnMouseDown()
    {
        Camera.main.GetComponent<Camera>().backgroundColor = MyColor;
    }
}
