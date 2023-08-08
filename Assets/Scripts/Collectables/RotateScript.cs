using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Aleyna.Collectables
{
    public class RotateScript : MonoBehaviour
    {
        [SerializeField]
        int doTweenCapacityMaxValue;
        GameObject rotatingObject1,rotatingObject2;
        void Start()
        {
            rotatingObject1 = GameObject.FindGameObjectWithTag("coin");
            rotatingObject2 = GameObject.FindGameObjectWithTag("socks");
        }

        
        void Update()
        {
            rotatingObjetcs();
        }
        
        void rotate(int speedValue,int directionReturn,GameObject rotatingObject)
        {
            DOTween.SetTweensCapacity(doTweenCapacityMaxValue, 50);
            rotatingObject.transform.DORotate(new Vector3(0, directionReturn, 0), speedValue, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);
        }
        void rotatingObjetcs()
        {
            if (rotatingObject1.activeSelf==true)
            {
                rotate(3,90,rotatingObject1);
            }
            if (rotatingObject2.activeSelf == true)
            {
                rotate(2, -90,rotatingObject2);
            }

        }
    }
}
