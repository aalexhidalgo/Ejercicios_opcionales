using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParImpar : MonoBehaviour
{
    private int num;

    public void EsParImpar(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log($"El número {num} es par.");
        }
        else
        {
            Debug.Log($"El número {num} es impar.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
            EsParImpar(num);
        }
    }
}
