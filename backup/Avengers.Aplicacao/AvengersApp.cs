using System;
using System.Collections.Generic;
using System.Text;
using Avengers.Entidade;
using Avengers.Repositorio;

namespace Avengers.Aplicacao
{
    public class AvengersApp
    {
        private AvengersRepositorio oavengersrepositorio = new AvengersRepositorio();

        public AvengersApp()
        {

        }

        public bool Insert(Heroes ohero)
        {
            return oavengersrepositorio.Insert(ohero);
        }


    }
}
