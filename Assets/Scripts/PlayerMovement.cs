using System;
using UnityEngine;

namespace Scripts
{
    public class PlayerMovement : MonoBehaviour
    {

        private float horizontal;
       [SerializeField] private float speed;
       public SpriteRenderer player;


      

        public void Execute()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            Debug.Log(horizontal);
            PlayerController.rb2d.velocity = new Vector2(horizontal * speed,  PlayerController.rb2d.velocity.y);
           MovAnim();
           
        }

        public void CancelMovement()
        {
            PlayerController.rb2d.velocity = Vector2.zero;
            PlayerController.instance.animations.AnimationState(AnimState.idle);
        }

        public void MovAnim()
        {
            if (horizontal != 0)
            {
                PlayerController.instance.animations.AnimationState(AnimState.run);
                MovementAnim();
            }
            else
            {
                PlayerController.instance.animations.AnimationState(AnimState.idle);
            }
        }

        public void MovementAnim()
        {
            switch (horizontal)
            {
                case (>=0):
                    if (!PlayerController.IsJumping)
                    {
                        PlayerController.instance.animations.AnimationState(AnimState.run);
                   
                       

                    }
                    
                    player.flipX = false;
                    break;
                case (<= 0):
                {
                    if (!PlayerController.IsJumping)
                    {
                        PlayerController.instance.animations.AnimationState(AnimState.run);
                       
                    }
                   // transform.eulerAngles = new Vector3(0, 180, 0);
                   player.flipX = true;
                    break;
                    
                }
              
               
                }
            }
        
    }
}