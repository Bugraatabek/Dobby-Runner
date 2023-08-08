using UnityEngine;
using UnityEngine.VFX;

namespace Aleyna.VFX
{
    
    public class VFXScript : MonoBehaviour
    {
        public bool IsPlaying = true;
        VisualEffect visualEffect;
        private void Start()
        {
            visualEffect = GetComponent<VisualEffect>();
        }
        void Update()
        {
            if (IsPlaying)
            {
                visualEffect.Play();
            }
            else
            {
                visualEffect.Stop();
            }
        }
    }     
}
