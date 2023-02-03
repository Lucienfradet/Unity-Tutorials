using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public const float SPEED = 0.01f;

    public float lowPosition = 0f;
    public float highPosition = 4.3f;
    public float speed = -SPEED;
    float position = 0f;
    bool counterFlag = false;
    const int counterMax = 75;
    float counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.GetComponent<Transform>().Translate(speed, 0, 0, Space.Self);
        if (this.transform.position.y >= highPosition && speed >= 0)
        {
            if (!counterFlag && counter == 0)
            {
                speed = 0.0f;
                counterFlag = true;
            }
            if (counter > counterMax)
            {
                counter = 0;
                counterFlag = false;
                speed = -SPEED;
            }
        }
        if (this.transform.position.y <= lowPosition && speed <= 0)
        {
            if (!counterFlag && counter == 0)
            {
                speed = 0.0f;
                counterFlag = true;
            }
            if (counter > counterMax)
            {
                counter = 0;
                counterFlag = false;
                speed = SPEED;
            }
        }

        if (counterFlag)
        {
            counter++;
        }
    }
}
