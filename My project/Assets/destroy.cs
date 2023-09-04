using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    AudioSource snd;

    void Update()
    {
        snd = GetComponent<AudioSource>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);


    }

    private void oncollisionEnter2D (Collision2D collision)
    {
        snd.Play();

    }

   
}
