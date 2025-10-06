using T3_P_ORM_SQL.Controladores;
using T3_P_ORM_SQL.Modelos;
using T3_P_ORM_SQL.Vistas.Citas_Crud;
using T3_P_ORM_SQL.Vistas.Doctores_Crud;
using T3_P_ORM_SQL.Vistas.Pacientes_Crud;

namespace T3_P_ORM_SQL
{
    public partial class Main : Form
    {
        private readonly Contextobd _contextDB;
        internal Main(Contextobd context)
        {
            InitializeComponent();
            // Guardamos el contexto recibido en nuestra variable local
            _contextDB = context;
        }

        private void PacientesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pacientes_Menu view = new Pacientes_Menu();
            view.Show();
            view.FormClosed += (s, args) => this.Show();
        }

        private void CitasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Menu view = new Citas_Menu(_contextDB);
            view.Show();
            view.FormClosed += (s, args) => this.Show();

            CitasController<Citas_Menu> citasController = new CitasController<Citas_Menu>(view, _contextDB);
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dr_Menu view = new Dr_Menu();
            view.Show();
            view.FormClosed += (s, args) => this.Show();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        
    }
}
