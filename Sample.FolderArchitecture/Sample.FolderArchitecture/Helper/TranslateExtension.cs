﻿using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample.FolderArchitecture.Helper
{
    [ContentProperty("Text")]
    public  class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "MedinaTravelAgency.AppResource";
        public string Text { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;
            ResourceManager resourceManager = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
            return resourceManager.GetString(Text, CultureInfo.CurrentCulture);
        }
    }
}
