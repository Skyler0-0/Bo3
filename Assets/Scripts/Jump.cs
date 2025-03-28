using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 20f;
    public float jumpAmount = 10;
    private Rigidbody rb;
    public bool onFloor = true;
    // Start is called before the first frame update

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        onFloor = false;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            onFloor = true;

        }
    }



    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            onFloor = false;


        }
    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        }
    }
}
