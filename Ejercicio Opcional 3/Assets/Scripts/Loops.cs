using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //Variables
    public int Divisor = 3;
    public int[] intArray;
    // Start is called before the first frame update
    void Start()
    {
        Ejercicio4();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Bucles con FOR/FOREACH

    public void Ejercicio1()
    {
        for (int i = 0; i <= 100; i = i + 2)
        {
            Debug.Log(i);
        }
    }

    private void Ejercicio2()
    {
        for (int i = 0; i <= 19; i++)
        {
            Debug.Log("Hola, holita, vecinito");
        }
    }

    private void Ejercicio3()
    { 
        for (int i = 1; i <= 500; i++)
        {
            if (i % Divisor == 0)
            {
                Debug.Log(i);
            }
        }
    }

    private void Ejercicio4()
    {
        foreach (int i in intArray)
        {
            Debug.Log(i);
        }
    }

}
