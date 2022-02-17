using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Moving
{
     [Header("Gravity Settings")]
    [SerializeField] private float gravityForce;
    [SerializeField] private float currentAttractionCharacter;
    protected sealed override void Awake()
    {
        base.Awake();

    }

    protected sealed override void FixedUpdate()
    {
        base.FixedUpdate();

    }

    
}
