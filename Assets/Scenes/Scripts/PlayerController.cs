using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wynalda {
    public class PlayerController : MonoBehaviour
    {

        public HudController prefabHUD;
        public float totalXP = 0;
        public float nextLevelXP = 750;

        public float GetPercentXP()
        {
            return totalXP / nextLevelXP;
        }

        void Start()
        {
            HudController obj = Instantiate(prefabHUD);
            obj.player = this;
        }

        // Update is called once per frame
        void Update()
        {
            totalXP += 100 * Time.deltaTime;
        }
    }
}
