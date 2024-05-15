﻿using PillMe.Models;
using System.ComponentModel;

namespace PillMe.ViewModels
{
    public class PillViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        PillsListViewModel plvm;
        public Pill Pill { get; set; }
        public PillViewModel()
        {
            Pill = new Pill();
        }
        public PillsListViewModel PillsListViewModel
        {
            get { return plvm; }
            set
            {
                if (plvm == value) return;
                plvm = value;
                OnPropertyChanged("PillsListViewModel");
            }
        }
        public string Name
        {
            get { return Pill.Name; }
            set
            {
                if (Pill.Name == value) return;
                Pill.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Description
        {
            get { return Pill.Description; }
            set
            {
                if (Pill.Description == value) return;
                Pill.Description = value;
                OnPropertyChanged("Description");
            }
        }
        public int Amount
        {
            get { return Pill.Amount; }
            set
            {
                if (Pill.Amount == value) return;
                Pill.Amount = value;
                OnPropertyChanged("Amount");
            }
        }
        public decimal Price
        {
            get { return Pill.Price; }
            set
            {
                if (Pill.Price == value) return;
                Pill.Price = value;
                OnPropertyChanged("Price");
            }
        }
        public bool IsValid
        {
            get
            {
                return new string[] { Name, Description, Amount.ToString(), Price.ToString() }.Any(x => !string.IsNullOrEmpty(x?.Trim()));
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}