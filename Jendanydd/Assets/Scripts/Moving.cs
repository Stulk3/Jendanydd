using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Moving : MonoBehaviour
{
    [Header("Move Settings")]
    public float speed;
    public Vector3 direction;

    
    
    [Header("Character Contoller Settings")]
    [Space(0.5f)]
    [SerializeField] private float characterColliderHeight = 2f;
    [SerializeField] private float characterColliderRadius = 0.5f;
    [SerializeField]private CharacterController controller;
    
    protected virtual void Awake() 
    {
        SetUpCharacterContoller();
    }
    
    protected virtual void FixedUpdate()
    {
        Move(direction,speed);
    }


    public void Move(Vector3 direction, float speed)
    {
        if(direction.magnitude != 0)
        {
            controller.Move(direction * Time.deltaTime * speed);
        }
        
    }
    protected void SetUpCharacterContoller()
    {
        controller = this.GetComponent<CharacterController>();
        controller.height = characterColliderHeight;
        controller.radius = characterColliderRadius;
    }

    protected void GravityHandling()
    {

    }
}
