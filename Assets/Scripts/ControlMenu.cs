using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour {

    public GameObject Biblioteca;
    private bool Estado;

    void Start() {

        Biblioteca.SetActive(false);
    }

    void Update() {

    }

    public void Recorrido()
    {
        SceneManager.LoadScene(1);
    }

    public void Libre()
    {
        SceneManager.LoadScene(2);
    }

    public void Ayuda()
    {
        SceneManager.LoadScene(6);
    }

    public void Biblio()
    {
        Estado = !Estado;
        Biblioteca.SetActive(Estado);
    }
   
  

}
