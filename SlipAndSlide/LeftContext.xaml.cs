﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SlipAndSlide
{
    public partial class LeftContext : BaseSwipeAction
    {
        public LeftContext()
        {
            InitializeComponent();
            this.ActiveBackgroundColor = Color.Orange;
            this.InactiveBackgroundColor = Color.LightGray;
        }
    }
}
