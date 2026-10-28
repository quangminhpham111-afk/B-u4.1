namespace Bai4_2_DangKy;

public partial class FormDangKy : Form
{
    public FormDangKy()
    {
        InitializeComponent();
    }

    private void FormDangKy_Load(object sender, EventArgs e)
    {
        dtpBirthDate.MaxDate = DateTime.Today;
        LoadCourses();
        LoadGrid();
    }

    private void LoadCourses()
    {
        // Binding data: hiển thị CourseName, giá trị là CourseId
        cboCourse.DataSource = Db.GetCourses();
        cboCourse.DisplayMember = "CourseName";
        cboCourse.ValueMember = "CourseId";
    }

    private void LoadGrid()
    {
        dgvRegistrations.DataSource = Db.GetRegistrations();
    }

    private bool ValidateInput()
    {
        errorProvider.Clear();
        bool ok = true;
        if (string.IsNullOrWhiteSpace(txtFullName.Text))
        {
            errorProvider.SetError(txtFullName, "Vui lòng nhập họ tên");
            ok = false;
        }
        if (!mtxtPhone.MaskCompleted)
        {
            errorProvider.SetError(mtxtPhone, "Vui lòng nhập đủ số điện thoại");
            ok = false;
        }
        if (cboCourse.SelectedValue == null)
        {
            errorProvider.SetError(cboCourse, "Vui lòng chọn khóa học");
            ok = false;
        }
        return ok;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        string gender = rdoMale.Checked ? "Nam" : "Nữ";
        var interests = new List<string>();
        if (chkReading.Checked) interests.Add(chkReading.Text);
        if (chkMusic.Checked) interests.Add(chkMusic.Text);
        if (chkSport.Checked) interests.Add(chkSport.Text);
        string interestText = interests.Count > 0 ? string.Join(", ", interests) : null;

        try
        {
            int id = Db.InsertRegistration(txtFullName.Text.Trim(), gender, mtxtPhone.Text,
                dtpBirthDate.Value, Convert.ToInt32(cboCourse.SelectedValue), interestText);

            MessageBox.Show(
                $"ĐĂNG KÝ THÀNH CÔNG (Mã #{id})\n\n" +
                $"Họ tên: {txtFullName.Text.Trim()}\n" +
                $"Giới tính: {gender}\n" +
                $"SĐT: {mtxtPhone.Text}\n" +
                $"Ngày sinh: {dtpBirthDate.Value:dd/MM/yyyy}\n" +
                $"Khóa học: {cboCourse.Text} (ID = {cboCourse.SelectedValue})\n" +
                $"Sở thích: {interestText ?? "(không có)"}",
                "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadGrid();
            ResetForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ResetForm()
    {
        txtFullName.Clear();
        mtxtPhone.Clear();
        rdoMale.Checked = true;
        chkReading.Checked = chkMusic.Checked = chkSport.Checked = false;
        dtpBirthDate.Value = DateTime.Today;
        cboCourse.SelectedIndex = 0;
        txtFullName.Focus();
    }
}
