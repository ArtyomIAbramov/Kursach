using AutoSalon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Models
{
    public class Car : Notify
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string brandNew;
        public string BrandNew
        {
            get { return brandNew; }
            set
            {
                brandNew = value;
                OnPropertyChanged("BrandNew");
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }

        private int cost;
        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged("Cost");
            }
        }

        private int max_speed;
        public int Max_speed
        {
            get { return max_speed; }
            set
            {
                max_speed = value;
                OnPropertyChanged("Max_speed");
            }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }

        private int power;
        public int Power
        {
            get { return power; }
            set
            {
                power = value;
                OnPropertyChanged("Power");
            }
        }

        public Position Position { get; set; }
    }

    public enum Position
    {
        InStock,
        InShop,
        UnAvailable,
        Default
    }
}
