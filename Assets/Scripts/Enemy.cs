using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {
        public GameObject sun;

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;
        private Animator animator;
        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            sun = GameObject.Find("Directional Light");
        }

        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
            hitPoints--;
            if (hitPoints == 0)
            {
                StartCoroutine(LightEnable());
                Die();
            }

        }

        private void Die()
        {

            LightEnable();
            Destroy(this.gameObject);

        }

        IEnumerator LightEnable()
        {
            Debug.Log("Rayo");
            sun.transform.rotation = Quaternion.Euler(90, 0, 0);
            yield return new WaitForSeconds(3);
            sun.transform.rotation = Quaternion.Euler(180, 0, 0);
            
        }

    }
}