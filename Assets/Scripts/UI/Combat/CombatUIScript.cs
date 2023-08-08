using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aleyna.UI
{
    public class CombatUIScript : MonoBehaviour
    {

        public Image dobbyHealthBar,damageImage;
        float dobbyHealth = 100f;
        float damageValue = 0.1f;
        bool touchedEnemy = false;
        bool touchedSocks = false;
        [SerializeField]
        float amount;
        void Start()
        {
            Debug.Log(dobbyHealthBar.fillAmount);

        }


        void Update()
        {
            dobbyHealthBar.fillAmount = dobbyHealth / 100f;
            
        }

        public void healthStatus(float Amount)
        {
            if (dobbyHealth <= 100)
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
        public void damageStatus()
        {
            if (touchedSocks == true)
            {
                
                damageImage.fillAmount += damageValue;
                if (damageImage.fillAmount >= 1)
                {
                    Debug.Log("Damage");
                }
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("EnemyBullet"))
            {
                touchedEnemy = true;
                Destroy(other.gameObject);
                healthStatus(amount);
            }
            if (other.gameObject.CompareTag("Enemy"))
            {
                touchedEnemy = true;
                healthStatus(amount * 2.5f);
            }
            if (other.gameObject.CompareTag("socks"))
            {
                touchedSocks = true;
                damageStatus();
                other.gameObject.SetActive(false);
            }


        }
    }
}
