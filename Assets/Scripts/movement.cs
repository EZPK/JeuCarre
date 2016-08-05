using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    public float moveSpeed;
    private Vector3 input;
    public float maxSpeed = 5f;

    public Vector3 jumpInput;

    public float jumpSpeed;

	
	// Update is called once per frame
	void Update () {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        {
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        jumpInput = new Vector3(0, 100, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(jumpInput * jumpSpeed);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {      
            GameManager.CompleteLevel();
        }
    }
}


