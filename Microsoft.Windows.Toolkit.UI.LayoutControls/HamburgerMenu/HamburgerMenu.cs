﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Windows.Toolkit.UI.Controls
{
    [TemplatePart(Name = "hamburgerButton", Type = typeof(Button))]
    [TemplatePart(Name = "mainSplitView", Type = typeof(SplitView))]
    [TemplatePart(Name = "buttonsListView", Type = typeof(ListViewBase))]
    [TemplatePart(Name = "optionsListView", Type = typeof(ListViewBase))]
    public partial class HamburgerMenu : ContentControl
    {
        Button _hamburgerButton;
        SplitView _mainSplitView;
        ListViewBase _buttonsListView;
        ListViewBase _optionsListView;

        /// <summary>
        /// Create a new instance of a HamburgerMenu.
        /// </summary>
        public HamburgerMenu()
        {
            DefaultStyleKey = typeof(HamburgerMenu);
        }

        /// <summary>
        /// Override default OnApplyTemplate to capture children controls
        /// </summary>
        protected override void OnApplyTemplate()
        {
            if (_hamburgerButton != null)
            {
                _hamburgerButton.Click -= HamburgerButton_Click;
            }

            if (_buttonsListView != null)
            {
                _buttonsListView.ItemClick -= ButtonsListView_ItemClick;
            }

            if (_optionsListView != null)
            {
                _optionsListView.ItemClick -= OptionsListView_ItemClick; ;
            }

            _hamburgerButton = (Button)GetTemplateChild("hamburgerButton");
            _mainSplitView = (SplitView)GetTemplateChild("mainSplitView");
            _buttonsListView = (ListViewBase)GetTemplateChild("buttonsListView");
            _optionsListView = (ListViewBase)GetTemplateChild("optionsListView");

            if (_hamburgerButton != null)
            {
                _hamburgerButton.Click += HamburgerButton_Click;
            }

            if (_buttonsListView != null)
            {
                _buttonsListView.ItemClick += ButtonsListView_ItemClick;
            }

            if (_optionsListView != null)
            {
                _optionsListView.ItemClick += OptionsListView_ItemClick; ;
            }

            base.OnApplyTemplate();
        }
    }
}
