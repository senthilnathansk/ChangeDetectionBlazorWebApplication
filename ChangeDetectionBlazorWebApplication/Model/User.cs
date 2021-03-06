﻿using System;
using System.Collections.ObjectModel;

namespace ChangeDetectionBlazorWebApplication.Model
{
    public class User : BaseModel
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }

        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; FirePropertyChanged(); }
        }

        public ObservableCollection<UserGroup> UserGroups { get; } = new ObservableCollection<UserGroup>();

        public override string ToString()
        {
            return Name;
        }
    }
}
