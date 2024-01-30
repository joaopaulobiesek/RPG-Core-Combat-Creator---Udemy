using System;
using UnityEngine;

namespace SRC.Core
{
    public class PersistentObjectSpawner : MonoBehaviour
    {
        [SerializeField] GameObject persistentObjectPerfab;

        static bool hasSpawne = false;

        private void Awake()
        {
            if(hasSpawne )
            return;

            SpawnPersistentObjects();

            hasSpawne = true;
        }

        private void SpawnPersistentObjects()
        {
            GameObject persistentObject = Instantiate(persistentObjectPerfab);
            DontDestroyOnLoad(persistentObject);
        }
    }
}