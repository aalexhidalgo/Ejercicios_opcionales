using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //Variables de tipo entero
    public int Divisor = 3;
    private int NumEnemies = 1;

    //Variables de tipo GameObject
    public GameObject SphereEnemyPrefab;
    public GameObject CubeEnemyPrefab;
    public GameObject CylinderPrefab;
    public GameObject CapsuleEnemyPrefab;

    //Variable de tipoVector3
    private Vector3 GrowScale = new Vector3 (0.2f, 0.2f, 0.2f);

    //Variables de tipo float
    private float Timer = 1.5f;
    private float SecondTimer = 2f;
    private float GrowingTimer = 0.5f;

    //Variables que guardan Arrays
    public int[] intArray;
    public Material[] MatArray;
    public GameObject[] GoArray;
    public string[] StrArray;
    // Start is called before the first frame update
    void Start()
    {
        Ejercicio7();
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
        for (int i = 0; i < 20; i++)
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

    public Vector3 RandomSpawnPos()
    {
        float Limit = 8f;
        return new Vector3 (Random.Range(-Limit, Limit), Random.Range(-Limit, Limit), Random.Range(-Limit, Limit));
    }
    private void Ejercicio5()
    {
        Debug.Log("Love me or DIE... hehehe...");
        for (int i = 1; i <= NumEnemies; i++)
        {
            Instantiate(SphereEnemyPrefab, RandomSpawnPos(), SphereEnemyPrefab.transform.rotation);
        }
    }

    private void Ejercicio6()
    {
        Debug.Log("Ser?s mi nuevo ingrediente para las Cangreburgers, ?am!");
        for (int i = 1; i <= NumEnemies; i++)
        {
            Vector3 CubeEnemyPos = new Vector3 (i, i, 0); 
            Instantiate(CubeEnemyPrefab, CubeEnemyPos , CubeEnemyPrefab.transform.rotation);
        }
    }

    private void Ejercicio7()
    {
        Debug.Log("Chantaje es una palabra muy fea, yo prefiero extorsi?n, la X le da mucha clase... jejejejeje");
        foreach (Material Mat in MatArray)
        {
            Instantiate(CylinderPrefab, RandomSpawnPos(), CylinderPrefab.transform.rotation);
            CylinderPrefab.GetComponent<MeshRenderer>().material = Mat; 
        }
    }

    private IEnumerator Ejercicio8()
    {
        GameObject CapsulePrefab = Instantiate(CapsuleEnemyPrefab, RandomSpawnPos(), CapsuleEnemyPrefab.transform.rotation);
        Debug.Log("Podr? no ser un perro inteligente, pero s? qu? es que atropellen a alguien.");
        for (int i = 0; i < 10; i++)
        {
            CapsulePrefab.transform.localScale += GrowScale;
            yield return new WaitForSeconds(Timer);
        }
    }

    private IEnumerator Ejercicio9()
    {
        for (int i = 0; i < GoArray.Length; i++)
        {
            GoArray[i].SetActive(true);
            yield return new WaitForSeconds(SecondTimer);
        }
    }

    private IEnumerator Ejercicio10()
    {
        for (int i = 0; i < StrArray.Length; i++)
        {
            Debug.Log(StrArray[i]);
            yield return new WaitForSeconds(GrowingTimer * i);
        }
    }

    //Bucles con WHILE

    private void Ejercicio1_WHILE()
    {
        int i = 0;

        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                Debug.Log($"{i}");
            }

            i++;
        }
    }

    private void Ejercicio2_WHILE()
    {
        int i = 0;

        while (i < 20)
        {
            i++;
            Debug.Log("Hola, holita, vecinito");
        }
    }

    private void Ejercicio3_WHILE()
    {
        int i = 0;
        int Divisor = 3;

        while (i < 500)
        {
            if (i % Divisor == 0)
            {               
                Debug.Log($"{i}");
            }

            i++;
        }
    }

    private void Ejercicio4_WHILE()
    {
        int i = 0;

        while (i < intArray.Length)
        {
            Debug.Log($"{intArray[i]}");
            i++;
        }
    }

    private void Ejercicio5_WHILE()
    {
        int i = 0;
        Debug.Log("Love me or DIE... hehehe...");

        while(i < NumEnemies)
        {
            Instantiate(SphereEnemyPrefab, RandomSpawnPos(), SphereEnemyPrefab.transform.rotation);
            i++;
        }
    }

    private void Ejercicio6_WHILE()
    {
        int i = 0;
        Debug.Log("Ser?s mi nuevo ingrediente para las Cangreburgers, ?am!");

        while (i < NumEnemies)
        {
            Vector3 CubeEnemyPos = new Vector3(i, i, 0);
            Instantiate(CubeEnemyPrefab, CubeEnemyPos, CubeEnemyPrefab.transform.rotation);
            i++;
        }
    }

    private void Ejercicio7_WHILE()
    {
        int i = 0;
        Debug.Log("Chantaje es una palabra muy fea, yo prefiero extorsi?n, la X le da mucha clase... jejejejeje");

        while (i < MatArray.Length)
        {
            Instantiate(CylinderPrefab, RandomSpawnPos(), CylinderPrefab.transform.rotation);
            CylinderPrefab.GetComponent<MeshRenderer>().material = MatArray[i];
            i++;
        }
    }

    private IEnumerator Ejercicio8_WHILE()
    {
        int i = 0;
        GameObject CapsulePrefab = Instantiate(CapsuleEnemyPrefab, RandomSpawnPos(), CapsuleEnemyPrefab.transform.rotation);
        Debug.Log("Podr? no ser un perro inteligente, pero s? qu? es que atropellen a alguien.");

        while (i < 10)
        {
            CapsulePrefab.transform.localScale += GrowScale;
            yield return new WaitForSeconds(Timer);
            i++;
        }
    }

    private IEnumerator Ejercicio9_WHILE()
    {
        int i = 0;

        while (i < GoArray.Length)
        {
            GoArray[i].SetActive(true);
            yield return new WaitForSeconds(SecondTimer);
            i++;
        }
    }

    private IEnumerator Ejercicio10_WHILE()
    {
        int i = 0;

        while (i < StrArray.Length)
        {
            Debug.Log(StrArray[i]);
            yield return new WaitForSeconds(GrowingTimer * i);
            i++;
        }
    }
}
