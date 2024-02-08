using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRC.Core
{
    public class DestroyAfterEffect : MonoBehaviour
    {
        void Update()
        {
            if (!GetComponent<ParticleSystem>().IsAlive())
                Destroy(gameObject);
        }
    }
}