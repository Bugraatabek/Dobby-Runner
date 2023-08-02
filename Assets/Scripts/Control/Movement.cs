using System;
using UnityEngine;

namespace Runner.Control
{
    public class Movement : MonoBehaviour 
    {
        [SerializeField] private float _verticalMoveSpeed;
        [SerializeField] private float _horizontalMoveSpeed;

        public event Action onMoving;

        private void Start() 
        {
            InputReader.instance.input += MoveHorizontal;
        }

        private void MoveHorizontal(float direction)
        {
            transform.Translate(Vector3.right * direction * _horizontalMoveSpeed * Time.deltaTime);
        }

        private void Update() 
        {
            onMoving?.Invoke();
            transform.Translate(Vector3.forward * _verticalMoveSpeed * Time.deltaTime);
        }
    }
}