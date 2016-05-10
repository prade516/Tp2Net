﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidades
    {
       private int _Idespecialidad;
        private string _DescEspecialidad;
        private string txtbuscado;

        public int Idespecialidad
        {
            get { return _Idespecialidad; }
            set { _Idespecialidad = value; }
        }
      public string DescEspecialidad
        {
            get { return _DescEspecialidad; }
            set { _DescEspecialidad = value; }
        }
   public string Txtbuscado
      {
          get { return txtbuscado; }
          set { txtbuscado = value; }
      }
      public Especialidades() 
      {
      }
      public Especialidades(int id_especialidad, string desc_especialidad,string txtbuscado)
      {
          this.Idespecialidad = id_especialidad;
          this.DescEspecialidad = desc_especialidad;
          this.Txtbuscado = txtbuscado;
      }
    }
}
