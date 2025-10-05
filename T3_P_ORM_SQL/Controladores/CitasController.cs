using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_P_ORM_SQL.Modelos;
using T3_P_ORM_SQL.Vistas.Citas_Crud;

namespace T3_P_ORM_SQL.Controladores
{
    internal class CitasController<Tform> where Tform : Form
    {
        private readonly Tform _form;
        private readonly BindingSource vercitasBindinSource;
        private readonly Contextobd contextobd;

        public CitasController(Tform tform ,Contextobd contextobd) 
        {
            this.contextobd = contextobd;
            this._form = tform; 
            this.vercitasBindinSource = new BindingSource();
        }

        public BindingSource OnVerCitas() 
        {
            var Citas = contextobd.Citas.ToList();
            vercitasBindinSource.DataSource = Citas;
            return vercitasBindinSource;
        }
    }
}
