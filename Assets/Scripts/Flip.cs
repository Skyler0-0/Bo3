using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKeyDown(KeyCode.P))
        {


            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("flip");

        }
    }
}
