using UnityEngine;
using System.Collections;

public class movingInCircle : MonoBehaviour
{

    public Transform center;
    public float degreesPerSecond = -65.0f;

    private Vector3 v;

    void Start()
    {
        v = transform.position - center.position;
    }

    void Update()
    {

        //renvoit les coordonnées X,Y,Z de l'objet en mouvement circulaire à une vitesse donnée.
        //Vector3.up est là pour indiquer l'axe Y
        //On dirait que le quaternion est un mouvement circulaire à lui seul.

        v = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.up) * v;
        transform.position = center.position + v;

    }
}