using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counterUI : MonoBehaviour
{
    // Start is called before the first frame update
    public PickerUpper player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Pickup Counter: " + player.counter;
    }
}
