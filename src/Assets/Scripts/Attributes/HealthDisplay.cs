using System;
using UnityEngine;
using UnityEngine.UI;

namespace SRC.Attributes
{
    public class HealthDisplay : MonoBehaviour
    {
        Health health;

        private void Awake()
        {
            health = GameObject.FindWithTag("Player").GetComponent<Health>();
        }

        private void Update()
        {
            var life = String.Format("{0:0.0}%", health.GetPercentage());
            Debug.Log("Health: " + life);
            //GetComponent<Text>().text = life;
        }
    }
}