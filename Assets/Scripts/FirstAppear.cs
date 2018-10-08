using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAppear : MonoBehaviour {

    public Animator helpAnimator;
    private bool firstEnter = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (firstEnter)
        {
            print("holi");
            helpAnimator.Play("Intro2");
            firstEnter = false;
        }
    }
}
