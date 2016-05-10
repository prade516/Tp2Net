﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Personas
    {
         private int _Id_Persona;
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Email;
        private string _Telefono;
        private DateTime _Fecha_Nac;
        private int _Legajo;
        private int _Tipo_Persona;
        private int _Id_Plan;

 #region Las propiedades de las personas
        public int Id_Persona
        {
            get { return _Id_Persona; }
            set { _Id_Persona = value; }
        }
       public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public DateTime Fecha_Nac
        {
            get { return _Fecha_Nac; }
            set { _Fecha_Nac = value; }
        }
        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
         public int Tipo_Persona
        {
            get { return _Tipo_Persona; }
            set { _Tipo_Persona = value; }
        }
        public int Id_Plan
        {
            get { return _Id_Plan; }
            set { _Id_Plan = value; }
        }
#endregion
        #region Los constructores
        public Personas()
        {

        }
        public Personas(int id_persona,string nombre,string apellido,string direccion,string email,string telefono,DateTime fecha_nac,int legajo,int tipo_persona,int id_plan)
        {
            this.Id_Persona = id_persona;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Email = email;
            this.Telefono = telefono;
            this.Fecha_Nac = fecha_nac;
            this.Legajo = legajo;
            this.Tipo_Persona = tipo_persona;
            this.Id_Plan = id_plan;
        }
        #endregion
    }
}
