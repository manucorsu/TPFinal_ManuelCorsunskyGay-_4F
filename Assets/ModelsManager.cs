using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] models;
    public int currentIndex = -1;
    void Start()
    {
        DeactivateAll();
        Debug.Log("Flecha derecha para avanzar, flecha izquierda para retroceder.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= models.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivateByIndex(currentIndex);
            Debug.Log($"Modelo nro. {currentIndex}.");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivateByIndex(currentIndex);
            Debug.Log($"Modelo nro. {currentIndex}.");
        }
    }
    void DeactivateAll()
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(false);
        }
    }
    void ActivateByIndex(int index)
    {
        models[index].SetActive(true);
    }
}
