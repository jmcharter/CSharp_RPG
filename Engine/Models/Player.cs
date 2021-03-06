﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int _getExperiencePoints;

        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints 
        { 
            get { return _getExperiencePoints; }
            set { 
                _getExperiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            } 
        }
        public int Level { get; set; }
        public int Gold { get; set; }
    
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
