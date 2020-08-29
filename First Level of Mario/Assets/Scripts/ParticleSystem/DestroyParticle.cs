using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    private ParticleSystem Particle;
    void Start()
    {
        Particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Particle)
        {
            if (!Particle.IsAlive())
            {
                Destroy(gameObject);
            }
        }
    }
}
