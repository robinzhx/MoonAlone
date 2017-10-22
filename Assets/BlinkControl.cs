using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PostProcess
{
    public class BlinkControl : MonoBehaviour
    {

        private BlinkEffect blink;
        private int time;

        // Use this for initialization
        void Start()
        {
            blink = GetComponent<BlinkEffect>();
            time = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (time < 240) time++;

            if (time == 240) {
                blink.Blink();
                time++;
            }
        }
    }
}
