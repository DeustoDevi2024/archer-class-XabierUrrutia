using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightMovement : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.SetParent(game.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
