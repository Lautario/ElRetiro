using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibreControl : MonoBehaviour {

    public GameObject Puntos;
    public GameObject Puntos2;
    private bool state;
    private bool state2;

    // Use this for initialization
    void Start () {

        Puntos.SetActive(false);
        Puntos2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Atras()
    {
        SceneManager.LoadScene(0);
    }
    public void BackTo2()
    {
        SceneManager.LoadScene(2);
    }

    public void BackTo1()
    {
        SceneManager.LoadScene(1);
    }

    public void Hist1()
    {
        SceneManager.LoadScene(3);
    }
    public void Ar1()
    {
        SceneManager.LoadScene(4);
    }

    public void Ar2()
    {
        SceneManager.LoadScene(5);
    }
    public void PuntosHistoricos()
    {
        state = !state;

        Puntos.SetActive(state);

    }

    public void PuntosAR()
    {
        state2 = !state2;

        Puntos2.SetActive(state2);

    }
}
