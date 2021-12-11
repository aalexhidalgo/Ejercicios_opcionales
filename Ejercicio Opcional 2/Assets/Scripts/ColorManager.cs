using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color Cyan()
    {
        return new Color(0f, 1f, 1f);
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Cyan();
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            OnMouseDown();
        }
    }

    private void OnMouseDown()
    {
        GetComponent<Camera>().backgroundColor = Cyan();
    }
}
