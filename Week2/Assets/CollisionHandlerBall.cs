using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandlerBall : MonoBehaviour
{
    public GameObject player;
    public int vectorMagnitude = 200;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100.0f, 0));
        if (collision.collider.gameObject == player)
        {
            Vector3 force = this.transform.position - collision.collider.gameObject.transform.position; //vectorial substration gives a resulting vector with the right direction
            force.Normalize();
            force *= vectorMagnitude;
            this.GetComponent<Rigidbody>().AddForce(force);
        }
    }
}
