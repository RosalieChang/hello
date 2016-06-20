using UnityEngine;
using System.Collections;



public class SonarFxTest : MonoBehaviour
{
    void Update()
    {
		if (Input.GetKeyDown("p")) {
			GetComponent<SonarFxSwitcher> ().Trigger ();
		}
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Press P To Trigger FX");
    }
}


