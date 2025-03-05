using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class PlayerAnimations : MonoBehaviour
    {
     
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { 
          
        }

        public void AnimationState(AnimState state)
        {
            var s = state.GetHashCode();
      
           GetComponentInChildren<Animator>().SetInteger("transition",s);
        }
    }

}