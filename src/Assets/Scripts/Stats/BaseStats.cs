using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SRC.Stats
{
    public class BaseStats : MonoBehaviour
    {
        [Range(1, 99)]
        [SerializeField] int startingLevel = 1;
        [SerializeField] CharacterClass characterClass;
        [SerializeField] Progression progression = null;

        public float GetHealth() =>
            progression.GetHealth(characterClass, startingLevel);
    }
}