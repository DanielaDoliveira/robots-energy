using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public static Rigidbody2D rb2d;
        public static bool IsJumping;
        public static bool DoubleJumping;
        
        [Header("----Player Scripts----")]
        public PlayerMovement move;

        public PlayerAnimations animations;

        public static PlayerController instance;
        public Jump jump;

        private void Awake()
        {
            instance = this;
        }

        void Start()
        {
            rb2d = GetComponentInChildren<Rigidbody2D>();
        }


        void Update()
        {
            move.Execute();
            jump.Execute();
            
        }
    }

}