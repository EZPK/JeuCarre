using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class dmg : MonoBehaviour {


    public int maxhp = 5;
    public int currenthp;

    private Vector3 spawn;


	// Use this for initialization
	void Start () {
        spawn = transform.position;
        currenthp = maxhp;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currenthp -= 1;
            print("mes hp actuels sont:" + currenthp);
            if(currenthp <= 0)
            {
                transform.position = spawn;
                GameManager.RestartLevel(); 
            }
        }
    }


}
