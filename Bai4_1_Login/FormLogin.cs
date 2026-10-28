namespace Bai4_1_Login;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    // Tick -> hiện mật khẩu (false); bỏ tick -> ẩn (true)
    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void txtUsername_TextChanged(object sender, EventArgs e)
    {
        errorProvider.SetError(txtUsername, "");
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {
        errorProvider.SetError(txtPassword, "");
    }

    private bool ValidateInput()
    {
        bool ok = true;
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống");
            ok = false;
        }
        if (string.IsNullOrEmpty(txtPassword.Text))
        {
            errorProvider.SetError(txtPassword, "Mật khẩu không được để trống");
            ok = false;
        }
        return ok;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;
        try
        {
            if (Db.CheckLogin(txtUsername.Text.Trim(), txtPassword.Text))
            {
                MessageBox.Show($"Đăng nhập thành công! Xin chào {txtUsername.Text.Trim()}.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
