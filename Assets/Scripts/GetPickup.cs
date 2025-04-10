using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private AudioSource source;
    private ParticleSystem ps;
    private Renderer r;
    private KeepScore scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        ps = GetComponent<ParticleSystem>();
        source = GetComponent<AudioSource>();
        scoreScript = FindObjectOfType<KeepScore>();
        ps.Stop();
        source.Stop();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            source.Play();
            ps.Play();
            GameObject.Destroy(gameObject, 0.5f);
            scoreScript.AddScore(5);
        }
    }
}