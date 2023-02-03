using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour {
    //static const double ROTATION_SPEED = 0.1D;
    public GameObject player;
    public float rotationSpeedY = 0.8f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    //Garantees it will run with a fix intervall (doen't corresponds to the frames)
    void FixedUpdate() {
        this.GetComponent<Transform>().Rotate(0, rotationSpeedY, 0, Space.World);
    }
}
