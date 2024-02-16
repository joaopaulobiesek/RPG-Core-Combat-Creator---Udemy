using System;
using UnityEngine;
using UnityEngine.UI;

namespace SRC.Stats
{
    public class ExperienceDisplay : MonoBehaviour
    {
        Experience experience;

        private void Awake()
        {
            experience = GameObject.FindWithTag("Player").GetComponent<Experience>();
        }

        private void Update()
        {
            var life = String.Format("{0:0}", experience.GetPoints());
            Debug.Log("Experience: " + life);
            //GetComponent<Text>().text = life;
        }
    }
}