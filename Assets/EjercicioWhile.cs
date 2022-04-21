using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioWhile : MonoBehaviour
{
    public int numero1;
    public int numero2;
    void Start()
    {
        if (numero1 != numero2 && numero1 > numero2)
        {
            while (numero2 <= numero1)
            {
                Debug.Log(numero1);
                numero1--;
            }
        }
        else
        {
            Debug.Log("Los numeros son iguales o el primer numero es mayor al segundo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
