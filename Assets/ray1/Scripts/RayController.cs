using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

    void Update () {
        if(Input.GetMouseButtonDown(1)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            print(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                GameObject selectedObj = hit.gameObject;
                print("name: " + selectedObj.name + selectedObj.transform.position);
            }
        }
    }
}
