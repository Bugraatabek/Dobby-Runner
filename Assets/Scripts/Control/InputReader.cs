using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Control
{
    public class InputReader : MonoBehaviour
    {
        public static InputReader instance;
        private FixedJoystick _fixedJoystick;
        public event Action<float> input; 

        
        private void Awake() 
        {
            if(instance)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
            }

            _fixedJoystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>();
        }

        void Update()
        {
            if(_fixedJoystick.Horizontal != 0)
            {
                input.Invoke(_fixedJoystick.Horizontal);
            }
        }
    }
}

