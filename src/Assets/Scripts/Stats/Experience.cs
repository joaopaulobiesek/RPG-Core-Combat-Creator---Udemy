using System;
using SRC.Saving;
using UnityEngine;

namespace SRC.Stats
{
    public class Experience : MonoBehaviour, ISaveable
    {
        [SerializeField] float experiencePoints = 0;

        public void GainExperience(float experience) =>
            experiencePoints += experience;

        public float GetPoints() =>
            experiencePoints;

        public object CaptureState()
        {
            return experiencePoints;
        }

        public void RestoreState(object state)
        {
            experiencePoints = (float)state;
        }
    }
}