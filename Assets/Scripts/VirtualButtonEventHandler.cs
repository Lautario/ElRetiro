using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler {



    private GameObject model_1;
    private GameObject model_2;
    private GameObject model_3;
    private GameObject btn_1;
	private GameObject btn_2;
    private GameObject btn_3;

    void Start() {

   
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i) {
      
            vbs[i].RegisterEventHandler(this);
        }


		model_1 = transform.Find("Bed").gameObject;
		model_2 = transform.Find("Closet").gameObject;
        model_3 = transform.Find("BB").gameObject;
        btn_1 = transform.Find("P1").gameObject;
		btn_2 = transform.Find("P2").gameObject;
        btn_3 = transform.Find("P3").gameObject;
        model_1.SetActive(false);
		model_2.SetActive(false);
        model_3.SetActive(false);
        btn_1.SetActive(true);
		btn_2.SetActive(true);
        btn_3.SetActive(true);
    }
 
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb) {

		Debug.Log("Button pressed!");
        
		switch(vb.VirtualButtonName) {
		case "Cambio":
			btn_1.SetActive(false);
			btn_2.SetActive(true);
            btn_3.SetActive(true);
            model_1.SetActive(true);
			model_2.SetActive(false);
            model_3.SetActive(false);
                break;
		case "Cambio2":
           btn_1.SetActive(true);
           btn_2.SetActive(false);
           btn_3.SetActive(true);
           model_1.SetActive(false);
           model_2.SetActive(true);
           model_3.SetActive(false);
                break;
        case "Cambio3":
          btn_1.SetActive(true);
          btn_2.SetActive(true);
          btn_3.SetActive(false);
          model_1.SetActive(false);
          model_2.SetActive(false);
          model_3.SetActive(true);
                break;
        }
        
    }

    /// Called when the virtual button has just been released:
    public void OnButtonReleased(VirtualButtonBehaviour vb) { 
		Debug.Log("Button released!");
	}
}