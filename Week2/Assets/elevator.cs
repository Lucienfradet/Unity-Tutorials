using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public float lowPosition = -1.6f;
    public float highPosition = 2.66f;
    public float speed = 0.5f;
    float position = 0f;

    // Start is called before the first frame update
    void Start()
    {
        position = lowPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.GetComponent<Transform>().Translate(speed, 0, 0, Space.Self);
        if (this.transform.position.y >= highPosition && speed > 0)
        {
            speed *= -1;
        }
        if (this.transform.position.y <= highPosition && speed < 0)
        {
            speed *= -1;
        }
    }
}
