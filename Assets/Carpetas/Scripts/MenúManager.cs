using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúManager : MonoBehaviour
{
    public GameObject Opciones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Option()
    {
        Opciones.SetActive(true);
    }
    
    public void Empezar()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Salir()
    {
        Debug.Log("Saliste");
        Application.Quit();
    }
}
