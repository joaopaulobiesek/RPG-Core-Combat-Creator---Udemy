using System;
using UnityEngine;
using UnityEngine.UI;

namespace SRC.Stats
{
    public class LevelDisplay : MonoBehaviour
    {
        BaseStats baseStats;

        private void Awake()
        {
            baseStats = GameObject.FindWithTag("Player").GetComponent<BaseStats>();
        }

        private void Update()
        {
            var life = String.Format("{0:0}", baseStats.GetLevel());
            Debug.Log("Level: " + life);
            //GetComponent<Text>().text = life;
        }
    }
}