using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void Update () {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                GameObject selectedObj = hit.collider.gameObject;
                print("name: " + selectedObj.name + selectedObj.transform.position);
            }
        }
    }
}
