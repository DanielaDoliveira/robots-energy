using System;

namespace blocks
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Unlock : MonoBehaviour
    {
        // Blocos a serem ativados
        //Blocos a serem desativados

        [SerializeField] private GameObject blocksToEnable;
        [SerializeField] private GameObject blocksToDisable;
        private bool _isSwitchEnabled;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        SwitchCondition();
        }

        void EnableBlocks(GameObject block)
        {
            block.SetActive(true);
        }

        void DisableBlocks(GameObject block)
        {
            block.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _isSwitchEnabled = !_isSwitchEnabled;
            }
        }

        private void SwitchCondition()
        {
            if (_isSwitchEnabled)
            {
              
                    DisableBlocks(blocksToDisable);
                    if(blocksToEnable!=null)
                        EnableBlocks(blocksToEnable);
                
            }
            else
            {
             
                    DisableBlocks(blocksToEnable);
                    if(blocksToEnable!=null)
                        EnableBlocks(blocksToDisable);
                
            }
        }
    }

}

