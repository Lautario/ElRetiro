using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecorridoControl : MonoBehaviour {

    public GameObject Pagina;
    public GameObject Pagina2;
    public GameObject SlideOne;
    private RectTransform X;

    private bool state;
    private bool state2;

    // Use this for initialization
    void Start()
    {
        X = SlideOne.GetComponent<RectTransform>();
        Pagina.SetActive(true);
        Pagina2.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void Atras()
    {
        SceneManager.LoadScene(0);
    }

    public void aR1()
    {
        SceneManager.LoadScene(1);
    }

    public void aR2()
    {
        SceneManager.LoadScene(6);
    }

    public void aR3()
    {
        SceneManager.LoadScene(4);
    }

    public void aR4()
    {
        SceneManager.LoadScene(3);
    }
    public void P1()
    {
        Pagina.SetActive(false);
        Pagina2.SetActive(true);
    }

   
}
