﻿using MiPruebaForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MiPruebaForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}