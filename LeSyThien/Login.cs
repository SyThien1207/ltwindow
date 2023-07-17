using Window;

namespace LeSyThien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            {
                if (tbName.Text == "Sythien" && tbPass.Text == "123")
                {
                    FormMenu Menu = new FormMenu();
                    Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại", "thông báo");
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}