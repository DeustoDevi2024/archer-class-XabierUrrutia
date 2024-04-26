using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {
       public GameObject lightEnvairoment;

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
            hitPoints--;
            if(hitPoints == 0)
            {
                Die();
            }
            
        }

        private void Die()
        {

            lightEnable();
            Destroy(this.gameObject);

        }

        private IEnumerable lightEnable()
        {
            lightEnvairoment.transform.Rotate(new Vector3(90, 0, 0));
            yield return new WaitForSeconds(3f);
            lightEnvairoment.transform.Rotate(new Vector3(-90, 0, 0));

        }
    }

}