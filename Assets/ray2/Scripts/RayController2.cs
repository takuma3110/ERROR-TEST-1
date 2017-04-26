using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController2 : MonoBehaviour {

    public GameObject player;
    Vector3 newPlayerPosition;
    private int time;

	
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            time = 0;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit = new RaycastHit ();

            if(Physics.Raycast(ray, out hit)) {
                newPlayerPosition = hit.point;
            }
        }
	    time = Time.time * 0.1f;
        player.transform.position = Vector3.Lerp (player.transform.position, newPlayerPosition, time);
    }
}
