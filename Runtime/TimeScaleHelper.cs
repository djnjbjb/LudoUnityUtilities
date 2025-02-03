using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace LudoUtilities
{
    public class TimeScaleHelper : MonoBehaviour
    {
        public float timeScale;
        public bool startWithTimeScale;

        private void Start()
        {
            if (startWithTimeScale) Time.timeScale = timeScale;

        }

        [Button("Apply TimeScale")]
        void ApplyTimeScale()
        {
            Time.timeScale = timeScale;
        }
    }
}

