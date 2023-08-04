using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace combat.ui
{

    public class CombatUIScript : MonoBehaviour
    {
        public Image dobbyHealthBar;
        float dobbyHealth = 100f;
        public GameObject enemyBullet,enemy;
        bool touchedEnemy = false;
        [SerializeField]
        float amount;
        void Start()
        {
            Debug.Log(dobbyHealthBar.fillAmount);

        }


        void Update()
        {
            dobbyHealthBar.fillAmount = dobbyHealth/100f;
           
        }
        
        void healthStatus(float Amount)
        {
            if (dobbyHealth <=100)
            {
                if (touchedEnemy == true)
                {
                    dobbyHealth -= Amount;
                    dobbyHealthBar.fillAmount = dobbyHealth / 100f;
                    Debug.Log(dobbyHealthBar.fillAmount);
                }
            }
            
            if (dobbyHealth <= 0)
            {
                Debug.Log("It is died");
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == enemyBullet)
            {
                touchedEnemy = true;
                Destroy(other.gameObject);
                healthStatus(amount);
            }
            if (other.gameObject == enemy)
            {
                touchedEnemy = true;
                healthStatus(amount*3f);
            }


        }
        
    }
}

