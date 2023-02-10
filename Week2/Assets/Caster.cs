using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : MonoBehaviour
{
    public GameObject prefab;
    public GameObject gem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("I Clicked");
            Ray theRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHitInfo;
            if (Physics.Raycast(theRay, out rayHitInfo))
            {
                if (rayHitInfo.collider.gameObject.CompareTag("pickUp"))
                {
                    Debug.Log("Clicked on pickup");
                }

                GameObject.Instantiate(prefab, rayHitInfo.point, Quaternion.identity);
            }
        }
    }
}
