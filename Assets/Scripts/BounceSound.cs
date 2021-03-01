using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    public AudioSource Bouncer;
    public Rigidbody Sphere;
    private float speed;
    private void Start()
    {
        Sphere = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        speed = Sphere.velocity.magnitude;
    }
    void OnCollisionEnter(Collision collision)
    {
        Bouncer.volume = speed;
        Bouncer.Play();
    }
}
