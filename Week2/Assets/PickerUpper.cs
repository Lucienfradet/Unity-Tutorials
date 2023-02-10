using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter = 0;
    public AudioSource audio;
    public AudioClip pickUpAudio;
    public AudioClip lurkerAudio;
    public GameObject particleSystem;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audio = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("pickUp"))
        {
            particleGo(collision);
            GameObject.Destroy(collision.collider.gameObject);
            counter++;
            Debug.Log("amount of gems picked up :" + counter);

            audio.PlayOneShot(pickUpAudio);
        }

        if (collision.collider.gameObject.CompareTag("lurker"))
        {
            audio.PlayOneShot(lurkerAudio);
            Debug.Log("collided with luker");
        }
    }

    private void particleGo(Collision collision)
    {
        GameObject.Instantiate(particleSystem, collision.collider.gameObject.transform.position, Quaternion.identity);
    }
}
