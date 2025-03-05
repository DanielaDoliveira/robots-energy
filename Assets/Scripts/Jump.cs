using System;
using UnityEngine;

namespace Scripts
{
    public class Jump: MonoBehaviour
    {
        public Transform point;
        public float radius = 0.22f;
      [SerializeField]  private LayerMask _layer;
       [SerializeField] private float jumpForce;


       public void Execute()
       {
           if (Input.GetButtonDown("Jump"))
           {
               Debug.Log(PlayerController.IsJumping);
               Jumping();
           }
         
       }

       public void Update()
       {
           OnHit();
       }

       public void Jumping()
       {
           if (!PlayerController.IsJumping)
           {
               PlayerController.instance.animations.AnimationState(AnimState.jump);
               PlayerController.rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
               PlayerController.IsJumping = true;
               PlayerController.DoubleJumping = true;
           }
           else if (PlayerController.DoubleJumping)
           {
               PlayerController.instance.animations.AnimationState(AnimState.jump);
               PlayerController.rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
               PlayerController.DoubleJumping = false;
           }
          
       }

       private void OnHit()
       {
           Collider2D hit = Physics2D.OverlapCircle(point.position, radius,_layer);
           if (hit != null)
           {
               Debug.Log(hit.name);
               PlayerController.IsJumping = false;
           }
           else
           {
               PlayerController.IsJumping = true;
           }
       }

       private void OnDrawGizmos()
       {
           Gizmos.DrawWireSphere(point.position,radius);
           Gizmos.color = Color.blue;
       }
    }
}