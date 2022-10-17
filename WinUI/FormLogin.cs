namespace WinUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PromocionClienteForm promocionClienteForm = new PromocionClienteForm();
            promocionClienteForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TratamientoClienteForm tratamientoClienteForm = new TratamientoClienteForm();
            tratamientoClienteForm.ShowDialog();
        }
    }
}