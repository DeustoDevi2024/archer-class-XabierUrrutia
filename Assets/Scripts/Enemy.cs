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
            
        }

        /*private void Die()
        {
            lightEnvairoment.transform.Rotate(new Vector3(0,180,0));
            yield return new WaitForSeconds(0.3f);
        }*/
    }

}