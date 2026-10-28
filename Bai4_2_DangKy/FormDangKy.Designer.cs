using System.Drawing;
using System.Windows.Forms;

namespace Bai4_2_DangKy
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblFullName = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblCourse = new Label();
            lblInterests = new Label();
            txtFullName = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            chkReading = new CheckBox();
            chkMusic = new CheckBox();
            chkSport = new CheckBox();
            btnRegister = new Button();
            dgvRegistrations = new DataGridView();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ và tên:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(20, 62);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 97);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(90, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(20, 132);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(70, 20);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(20, 167);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(70, 20);
            lblCourse.TabIndex = 9;
            lblCourse.Text = "Khóa học:";
            // 
            // lblInterests
            // 
            lblInterests.AutoSize = true;
            lblInterests.Location = new Point(20, 205);
            lblInterests.Name = "lblInterests";
            lblInterests.Size = new Size(70, 20);
            lblInterests.TabIndex = 11;
            lblInterests.Text = "Sở thích:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(130, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 27);
            txtFullName.TabIndex = 1;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(130, 60);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(55, 24);
            rdoMale.TabIndex = 3;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(200, 60);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(46, 24);
            rdoFemale.TabIndex = 4;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(130, 94);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(150, 27);
            mtxtPhone.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(130, 129);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(150, 27);
            dtpBirthDate.TabIndex = 8;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(130, 164);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(250, 28);
            cboCourse.TabIndex = 10;
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Location = new Point(130, 203);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(87, 24);
            chkReading.TabIndex = 12;
            chkReading.Text = "Đọc sách";
            chkReading.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            chkMusic.AutoSize = true;
            chkMusic.Location = new Point(220, 203);
            chkMusic.Name = "chkMusic";
            chkMusic.Size = new Size(85, 24);
            chkMusic.TabIndex = 13;
            chkMusic.Text = "Âm nhạc";
            chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkSport
            // 
            chkSport.AutoSize = true;
            chkSport.Location = new Point(310, 203);
            chkSport.Name = "chkSport";
            chkSport.Size = new Size(88, 24);
            chkSport.TabIndex = 14;
            chkSport.Text = "Thể thao";
            chkSport.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(130, 240);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 34);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // dgvRegistrations
            // 
            dgvRegistrations.AllowUserToAddRows = false;
            dgvRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRegistrations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrations.Location = new Point(20, 295);
            dgvRegistrations.Name = "dgvRegistrations";
            dgvRegistrations.ReadOnly = true;
            dgvRegistrations.RowHeadersWidth = 51;
            dgvRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistrations.Size = new Size(600, 245);
            dgvRegistrations.TabIndex = 16;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 560);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblPhone);
            Controls.Add(mtxtPhone);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblCourse);
            Controls.Add(cboCourse);
            Controls.Add(lblInterests);
            Controls.Add(chkReading);
            Controls.Add(chkMusic);
            Controls.Add(chkSport);
            Controls.Add(btnRegister);
            Controls.Add(dgvRegistrations);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký khóa học";
            Load += FormDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblGender;
        private Label lblPhone;
        private Label lblBirthDate;
        private Label lblCourse;
        private Label lblInterests;
        private TextBox txtFullName;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private CheckBox chkReading;
        private CheckBox chkMusic;
        private CheckBox chkSport;
        private Button btnRegister;
        private DataGridView dgvRegistrations;
        private ErrorProvider errorProvider;
    }
}
