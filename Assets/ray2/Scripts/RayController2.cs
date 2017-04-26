using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController2 : MonoBehaviour {

    public GameObject player;
    Vector3 newPlayerPosition;
    private float time;

	
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            time = 0;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit = new RaycastHit ();

            if(Physics.Raycast(ray, out hit)) {
                newPlayerPosition = hit.point;
            }
        }
        time += Time.deltaTime * 0.1f;
        player.transform.position = Vector3.Lerp (player.transform.position, newPlayerPosition, time);
    }
}
