using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color MyColor;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = MyColor;
    }

    private void OnMouseDown()
    {
        Camera.main.GetComponent<Camera>().backgroundColor = MyColor;
    }
}
