﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;
        private string szerkesztett;

        public Bejegyzes(string szerzo, string tartalom, DateTime letrejott)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = letrejott;
            this.szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get=> szerkesztve;}

        public void Like()
        {
            this.likeok++;
        }
        public void szerkesztes(string adat)
        {
            szerkesztett = tartalom;
            this.tartalom = adat;
            szerkesztve = DateTime.Now;
        }
        public override string ToString()
        {
            if (szerkesztett == null)
            {
                return $"{this.szerzo} - Likeok: {this.likeok} - Létrehozás ideje: {this.letrejott} \n {this.tartalom}";
            }
            else
            {
                return $"{this.szerzo} - Likeok: {this.likeok} - Létrehozás ideje: {this.letrejott} \n Szerkesztve: {this.szerkesztve}:{szerkesztett} \n {this.tartalom}";
            }
        }
    }
}
