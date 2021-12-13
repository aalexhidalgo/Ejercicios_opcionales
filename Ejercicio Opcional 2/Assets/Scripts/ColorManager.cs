using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = RandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Camera.main.GetComponent<Camera>().backgroundColor = RandomColor();
    }
}
