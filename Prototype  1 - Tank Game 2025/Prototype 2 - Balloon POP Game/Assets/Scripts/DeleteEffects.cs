using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEffects : MonoBehaviour
{
    public int timer;

    
    void Start()
    {
        Destroy(gameObject, timer);
    }

}