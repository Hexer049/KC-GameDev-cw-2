using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paddle : MonoBehaviour
{
    private Rigidbody2D rg;
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = new Vector2(Input.GetAxis("Horizontal") *speed , 0);



    }
}
