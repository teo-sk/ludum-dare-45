using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Asteroid : MonoBehaviour
{
    public GameObject destroyEffect;


    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {
        var source = GetComponent<AudioSource>();
        source.PlayOneShot(source.clip);
        var e = Instantiate(destroyEffect, transform.position, transform.rotation);
    }
}
