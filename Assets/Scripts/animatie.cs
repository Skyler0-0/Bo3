using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatie : MonoBehaviour
{
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetTrigger("Walk");
            ani.ResetTrigger("idle");
            ani.ResetTrigger("WalkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("idle");
            ani.ResetTrigger("Walk");
        }
        else
        {
            ani.SetTrigger("idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");

        }
    }
}
