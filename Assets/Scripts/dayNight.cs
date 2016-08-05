using UnityEngine;
using System.Collections;

public class dayNight : MonoBehaviour {

    public float cycle = 0.5f;
  
	// Update is called once per frame
	void Update () {
        transform.Rotate(cycle, 0, 0, Space.World);
	}
}
