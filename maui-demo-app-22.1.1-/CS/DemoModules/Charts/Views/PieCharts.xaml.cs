﻿using DemoCenter.Maui.Charts.ViewModels;
using DevExpress.Maui.Controls;
using Microsoft.Maui.Controls;

namespace DemoCenter.Maui.Views {
    public partial class PieCharts : ContentPage {
        public PieCharts() {
            InitializeComponent();
            BindingContext = new PieChartsViewModel();
            SizeChanged += (s, e) => UpdateOrientation(Width, Height);
            UpdateOrientation(Width, Height);
        }

        void UpdateOrientation(double width, double height) {
            bool isVertical = width <= height;
            Position position = isVertical ? Position.Top : Position.Left;
            dxTabView.HeaderPanelPosition = position;
            ((ChartsPageViewModelBase)BindingContext).SetVerticalState(isVertical);
        }
    }
}
