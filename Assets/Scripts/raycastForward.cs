using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        float theDistance;

        Vector3 forward = transform.TransformDirection(Vector3.up) *1000;
        Debug.DrawRay(transform.position, forward, Color.red);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            theDistance = hit.distance;
            //sprint("Objet touché" + " " + hit.collider.gameObject.name + " " + "distance" + " " + hit.distance);
        }
	}
}
