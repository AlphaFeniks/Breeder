﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Breeder_OnMVC.Models
{
    public class Breeder
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Автор")]
        public string Author { get; set; }

        [DisplayName("Родительские сорта")]
        public string ParentVarieties { get; set; }

        [DisplayName("Урожайность")]
        public string Productivity { get; set; }

        [DisplayName("Характеристика")]
        public string Characteristic { get; set; }

        [DisplayName("Морозостойкость")]
        public string FrostResistance { get; set; }

        [DisplayName("Стойкость к вредителям")]
        public string DiseaseResistance { get; set; }

        [DisplayName("Фонды")]
        public string Funds { get; set; }
        
    }
}
