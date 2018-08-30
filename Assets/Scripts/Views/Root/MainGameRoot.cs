﻿using Contexts;
using strange.extensions.context.impl;
using UnityEngine;

namespace Views.Root
{
    public class MainGameRoot : ContextView
    {
                
        private void Awake()
        {
            context = new MainGameContext(this);
        }
        
        private void Update()
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
        }
    }
}