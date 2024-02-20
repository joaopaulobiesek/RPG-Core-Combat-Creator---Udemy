using System;
using SRC.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace SRC.Combat
{
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;

        private void Awake()
        {
            fighter = GameObject.FindWithTag("Player").GetComponent<Fighter>();
        }

        private void Update()
        {
            if (fighter.GetTarget() == null)
            {
                //GetComponent<Text>().text = "N/A";
                return;
            }

            Health health = fighter.GetTarget();
            if (health != null)
            {
                var life = String.Format("Enemy: {0:0.0}%", health.GetPercentage());
                Debug.Log("Enemy: " + life);
                //GetComponent<Text>().text = String.Format("{0:0}/{1:0}", health.GetHealthPoints(), health.GetMaxHealthPoints());
            }
        }
    }
}