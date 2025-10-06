using T3_P_ORM_SQL.Controladores;
using T3_P_ORM_SQL.Modelos;
using T3_P_ORM_SQL.Vistas.Citas_Crud;
namespace T3_P_ORM_SQL
{
    public partial class Main : Form
    {
        private readonly Contextobd _contextDB;
        public Main()
        {
            InitializeComponent();
        }
        private void CitasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas_Menu view = new Citas_Menu();
            view.Show();
            view.FormClosed += (s, args) => this.Show();

            CitasController<Citas_Menu> citasController = new CitasController<Citas_Menu>(view, _contextDB);
        }
        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
