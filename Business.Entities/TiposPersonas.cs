using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TiposPersonas
    {
         private int _Id_tipo_persona;
        private string _TipoPersona;
        private string _Txtbuscado;

        public string Txtbuscado
        {
            get { return _Txtbuscado; }
            set { _Txtbuscado = value; }
        }

        public int Id_tipo_persona
        {
            get { return _Id_tipo_persona; }
            set { _Id_tipo_persona = value; }
        }
        public string TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
        public TiposPersonas()
        { }
        public TiposPersonas(int id_tipo_persona,string tipoPersona, string txtbuscado)
        {
            this.Id_tipo_persona = id_tipo_persona;
            this.TipoPersona = tipoPersona;
            this.Txtbuscado = txtbuscado;
        }
    }
}
