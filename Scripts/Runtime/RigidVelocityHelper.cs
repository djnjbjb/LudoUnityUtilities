using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LudoUtilities
{
    public class RigidVelocityHelper : MonoBehaviour
    {

        public Vector2 velocity;
        public bool startWithVelocity;
        public Vector2 persistentVelocity;
        public bool enablePersistent;
        public float angularVelocity;
        public bool startWithAngular;
        Rigidbody2D rigid;


        void Awake()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            if (startWithVelocity) rigid.velocity = velocity;
            if (startWithAngular) rigid.angularVelocity = angularVelocity;
        }

        private void FixedUpdate()
        {
            if (enablePersistent) rigid.velocity = persistentVelocity;
        }

        public void ApplyVelocity()
        {
            rigid.velocity = velocity;
        }

        public void ApplyAngularVelocity()
        {
            rigid.angularVelocity = angularVelocity;
        }
    }
}

