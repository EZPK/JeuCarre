using UnityEngine;
using System.Collections;

public class nextScene : MonoBehaviour {
    private int currentLevel = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision other)
    {
        currentLevel++;
        if (other.gameObject.name == "Player")
        {
           
        }
    }
}
