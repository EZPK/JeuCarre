using UnityEngine;
using System.Collections;

public class destroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider gameObject)
    {
        if(gameObject.tag == "bullet")
        {
            Destroy(gameObject.gameObject);

        }
    }
}
