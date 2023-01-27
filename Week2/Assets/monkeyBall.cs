using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeyBall : MonoBehaviour
{

    public float rot = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("e"))
        {
            rot = rot * 3;
        }
        if (Input.GetKeyDown("q"))
        {
            rot = rot / 3;
        }
        this.GetComponent<Transform>().Rotate(0, rot, 0);
    }
}
