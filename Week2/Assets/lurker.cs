using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lurker : MonoBehaviour
{
    public GameObject target;

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
        this.GetComponent<Transform>().LookAt(target.transform);

        this.transform.Translate(new Vector3(0, 0, 0.005f), Space.Self);
    }
}
