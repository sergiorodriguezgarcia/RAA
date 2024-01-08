using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoresGame : MonoBehaviour
{

    public GameObject semaforo;
    List<int> correctOrder = new List<int> {0, 1, 2, 3}; // Cambia esto al orden correcto de tus elementos
    List<int> userSelection = new List<int>();

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToUserSelection(int color)
    {
        // si el color ya está selecionado no hace nada
        if (userSelection.Contains(color))
        {
            return;
        }

        Debug.Log("Agregando color " + color);


        userSelection.Add(color);
        if (userSelection.Count == correctOrder.Count)
        {
            CheckUserSelection();
        }
    }

    void CheckUserSelection()
    {
        for (int i = 0; i < correctOrder.Count; i++)
        {
            if (correctOrder[i] != userSelection[i])
            {
                Debug.Log("Incorrecto");

                // el color del objeto semaforo se pone a Color.red
                semaforo.GetComponent<Renderer>().material.color = Color.red;



                userSelection.Clear();
                return;
            }
        }
        semaforo.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("Correcto");
    }
    
}
