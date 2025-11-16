using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Models
{
    public class Calculo
    {
        public string ENE { get; set; }
        public string ELEvento { get; set; }
        public int ENP { get; set; }
        public double ECP { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public double ValorTotal{ 
        get{
            double Valor = ENP * ECP;
            return Valor;
        } }
        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

    }
}
