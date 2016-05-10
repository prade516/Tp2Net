using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Planes
    {
        private int _Id_Plan;
       private int _Id_Especialidad;
       private string _Desc_Plan;
       
       public int Id_Plan
       {
           get { return _Id_Plan; }
           set { _Id_Plan = value; }
       }
       public int Id_Especialidad
       {
           get { return _Id_Especialidad; }
           set { _Id_Especialidad = value; }
       }
       public string Desc_Plan
       {
           get { return _Desc_Plan; }
           set { _Desc_Plan = value; }
       }
       public Planes() 
       {
       }
       public Planes(int id_plan,int id_especialidad,string desc_plan)
       {
           this.Id_Plan = id_plan;
           this.Id_Especialidad = id_especialidad;
           this.Desc_Plan = desc_plan;
       }
    }
}
