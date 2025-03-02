﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;

namespace GoodTimeStudio.MyPhone.RootPages
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<NavigationMenu> navigationMenus;

        [ObservableProperty]
        private ObservableCollection<NavigationMenu> navigationFooterMenus;

        public MainPageViewModel()
        {
            navigationMenus = new ObservableCollection<NavigationMenu>()
            {
                new NavigationMenu(name:"Call", glyphIcon: "\uE717"),
                new NavigationMenu(name:"Message", glyphIcon: "\uE8BD"),
                new NavigationMenu(name: "Contacts", glyphIcon: "\uE77B"),
                new NavigationMenu(name:"Debug", glyphIcon: "\uEBE8"),
            };

            navigationFooterMenus = new ObservableCollection<NavigationMenu>()
            {
                new NavigationMenu(name: "Settings", glyphIcon: "\uE713")
            };
        }
    }

    public class NavigationMenu
    {
        public string Name { get; set; }

        public string GlyphIcon { get; set; }

        public NavigationMenu(string name, string glyphIcon)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            GlyphIcon = glyphIcon ?? throw new ArgumentNullException(nameof(glyphIcon));
        }
    }
}
