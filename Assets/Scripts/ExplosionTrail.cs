﻿using UnityEngine;
using System.Collections;

public class ExplosionTrail : MonoBehaviour
{
    
    public GameObject trail;
    private ParticleSystem pSystem;
    private ParticleSystem.Particle[] particles;
    private bool firstUpdate = true;
    private GameObject[] trails;


    void Start()
    {
        InitializeIfNeeded();
        StartCoroutine(DestroySelf());
    }

    void LateUpdate()
    {
       
        if (firstUpdate)
        {
            firstUpdate = false;
            int noParticles = pSystem.GetParticles(particles);
            trails = new GameObject[noParticles];
            for (int i = 0; i < noParticles; i++)
            {
                GameObject t = Instantiate(trail);
                t.transform.parent = transform;
                t.transform.localPosition = particles[i].position;
                trails[i] = t;

            }
        }
        else
        {
            int noParticles = pSystem.GetParticles(particles);
            for (int i = 0; i < noParticles; i++)
            {
                trails[i].transform.localPosition = particles[i].position;
                Color c = particles[i].color;
                c.a = particles[i].remainingLifetime / particles[i].startLifetime;
                trails[i].GetComponent<TrailRenderer>().material.SetColor("_TintColor", c );
            }
        }
        
    }

    void InitializeIfNeeded()
    {
        if (pSystem == null)
            pSystem = GetComponent<ParticleSystem>();

        if (particles == null || particles.Length < pSystem.maxParticles)
            particles = new ParticleSystem.Particle[pSystem.maxParticles];
    }

    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
