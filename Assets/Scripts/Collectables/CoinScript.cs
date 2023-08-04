using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Aleyna.Collectables
{
    public class CoinScript : MonoBehaviour
    {
        [SerializeField]
        int doTweenCapacityMaxValue;
        void Start()
        {
        
        }

        
        void Update()
        {
          coinRotate(); 
        }
        
        void coinRotate()
        {
            DOTween.SetTweensCapacity(doTweenCapacityMaxValue, 50);
            gameObject.transform.DORotate(new Vector3(0, 90, 0), 3, RotateMode.LocalAxisAdd).SetLoops(-1,LoopType.Incremental);
        }
    }
}
