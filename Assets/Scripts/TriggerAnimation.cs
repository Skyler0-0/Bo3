using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public string attack;
    public float delay = 0f;
    public float resetTime = 0f;
    public KeyCode triggerKey = KeyCode.None;
    public Animator animator;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey))
        {
            CallTrigger();
        }
    }

    public void CallTrigger()
    {
        StartCoroutine(AwaitDelay(delay));
        StartCoroutine(AwaitReset(0f));
    }

    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetTrigger(attack);
        if (audioSource != null) audioSource.Play();
    }
    private IEnumerator AwaitReset(float time)
    {
        yield return new WaitForSeconds(time);
        animator.ResetTrigger(attack);
    }
}
