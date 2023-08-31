using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*ʹ��ʱ����Ҫ�½�һ��GameObject��Ȼ���������ű�*/
namespace LudoUtilities
{
    public class TimeExtension : MonoBehaviour
    {
        #region Singleton
        public static TimeExtension singleton = null;
        void SetSingleton()
        {
            singleton = this;
        }
        #endregion

        public static int fixedFrameCount {
            get
            {
                if (TimeExtension.singleton == null) return Mathf.RoundToInt(Time.time / Time.fixedDeltaTime);
                else return _fixedFrameCount;
            }
            
        }
        private static int _fixedFrameCount = 1;

        void Awake()
        {
            SetSingleton();
            StartCoroutine(DoLateFixedUpdate());
        }

        void Update()
        {
        
        }

        IEnumerator DoLateFixedUpdate()
        {
            while(true)
            {
                yield return new WaitForFixedUpdate();
                LateFixedUpdate();
            }
            
        }

        void LateFixedUpdate()
        {
            _fixedFrameCount++;
        }

        void Create()
        {

        }
    }
}
