using UnityEngine;
using System.Collections;

public class ExplosionControl : MonoBehaviour
{
    
    public GameObject trail;
    private ParticleSystem pSystem;
    private ParticleSystem.Particle[] particles;
    private bool firstUpdate = true;
    private GameObject[] trails;


    void Start()
    {
        InitializeIfNeeded();
    }

    // Update is called once per frame
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
            //Debug.Log("First");
            int noParticles = pSystem.GetParticles(particles);
            for (int i = 0; i < noParticles; i++)
            {
                trails[i].transform.localPosition = particles[i].position;
                Color c = particles[i].color;
                c.a = particles[i].lifetime / particles[i].startLifetime;
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
}
