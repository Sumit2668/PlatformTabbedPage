﻿using System;
using Xamarin.Forms;

namespace Messier16.Forms.Controls
{
    [Flags]
    public enum BarBackgroundApplyTo
    {
        None = 0x01,
        Android = 0x10,
        iOS = 0x100
    }

    public class PlatformTabbedPage : TabbedPage
    {
        public static readonly BindableProperty SelectedColorProperty =
            BindableProperty.Create(nameof(SelectedColor), typeof(Color), typeof(PlatformTabbedPage), default(Color));

        public Color SelectedColor
        {
            get => (Color)GetValue(SelectedColorProperty);
            set => SetValue(SelectedColorProperty, value);
        }

        public static readonly BindableProperty BarBackgroundApplyToProperty =
            BindableProperty.Create(nameof(BarBackgroundApplyTo), typeof(BarBackgroundApplyTo), typeof(PlatformTabbedPage), BarBackgroundApplyTo.Android);

        public BarBackgroundApplyTo BarBackgroundApplyTo
        {
            get => (BarBackgroundApplyTo)GetValue(BarBackgroundApplyToProperty);
            set => SetValue(BarBackgroundApplyToProperty, value);
        }

        public new static readonly BindableProperty BarBackgroundColorProperty =
            BindableProperty.Create(nameof(BarBackgroundColor), typeof(Color), typeof(PlatformTabbedPage), default(Color));

        public new Color BarBackgroundColor
        {
            get => (Color)GetValue(BarBackgroundColorProperty);
            set => SetValue(BarBackgroundColorProperty, value);
        }


    }
}
