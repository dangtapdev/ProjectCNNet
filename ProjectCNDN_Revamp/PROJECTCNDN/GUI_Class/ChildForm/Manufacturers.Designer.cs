namespace GUI_Class.ChildForm
{
    partial class Manufacturers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgv_NSX = new DataGridView();
            panel1 = new Panel();
            txt_DiaChi = new TextBox();
            txt_MaNSX = new TextBox();
            txt_TenNSX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            txt_KetQuaNSX = new TextBox();
            btnXoaNSX = new Button();
            btn_XoaNSX = new Button();
            btn_ThemNSX = new Button();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_SDT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_NSX).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 29);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 24;
            label1.Text = "Thông tin nhà sản xuất";
            // 
            // dgv_NSX
            // 
            dgv_NSX.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_NSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NSX.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_SDT });
            dgv_NSX.Location = new Point(85, 83);
            dgv_NSX.Margin = new Padding(3, 4, 3, 4);
            dgv_NSX.Name = "dgv_NSX";
            dgv_NSX.RowHeadersWidth = 51;
            dgv_NSX.RowTemplate.Height = 25;
            dgv_NSX.Size = new Size(577, 399);
            dgv_NSX.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(txt_MaNSX);
            panel1.Controls.Add(txt_TenNSX);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(85, 512);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 197);
            panel1.TabIndex = 27;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(155, 132);
            txt_DiaChi.Margin = new Padding(3, 4, 3, 4);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(282, 29);
            txt_DiaChi.TabIndex = 17;
            // 
            // txt_MaNSX
            // 
            txt_MaNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaNSX.Location = new Point(155, 24);
            txt_MaNSX.Margin = new Padding(3, 4, 3, 4);
            txt_MaNSX.Name = "txt_MaNSX";
            txt_MaNSX.Size = new Size(282, 29);
            txt_MaNSX.TabIndex = 14;
            // 
            // txt_TenNSX
            // 
            txt_TenNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenNSX.Location = new Point(155, 80);
            txt_TenNSX.Margin = new Padding(3, 4, 3, 4);
            txt_TenNSX.Name = "txt_TenNSX";
            txt_TenNSX.Size = new Size(282, 29);
            txt_TenNSX.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 79);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 8;
            label4.Text = "Tên NSX :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 136);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 23);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 6;
            label2.Text = "Mã NSX :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(691, 36);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 31;
            label8.Text = "Kết quả :";
            // 
            // txt_KetQuaNSX
            // 
            txt_KetQuaNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_KetQuaNSX.Location = new Point(691, 84);
            txt_KetQuaNSX.Margin = new Padding(3, 4, 3, 4);
            txt_KetQuaNSX.Multiline = true;
            txt_KetQuaNSX.Name = "txt_KetQuaNSX";
            txt_KetQuaNSX.Size = new Size(342, 161);
            txt_KetQuaNSX.TabIndex = 32;
            // 
            // btnXoaNSX
            // 
            btnXoaNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaNSX.Location = new Point(691, 415);
            btnXoaNSX.Margin = new Padding(3, 4, 3, 4);
            btnXoaNSX.Name = "btnXoaNSX";
            btnXoaNSX.Size = new Size(343, 67);
            btnXoaNSX.TabIndex = 29;
            btnXoaNSX.Text = "Xóa thông tin NSX";
            btnXoaNSX.UseVisualStyleBackColor = true;
            // 
            // btn_XoaNSX
            // 
            btn_XoaNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaNSX.Location = new Point(691, 340);
            btn_XoaNSX.Margin = new Padding(3, 4, 3, 4);
            btn_XoaNSX.Name = "btn_XoaNSX";
            btn_XoaNSX.Size = new Size(343, 67);
            btn_XoaNSX.TabIndex = 30;
            btn_XoaNSX.Text = "Sửa thông tin NSX";
            btn_XoaNSX.UseVisualStyleBackColor = true;
            // 
            // btn_ThemNSX
            // 
            btn_ThemNSX.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNSX.Location = new Point(691, 265);
            btn_ThemNSX.Margin = new Padding(3, 4, 3, 4);
            btn_ThemNSX.Name = "btn_ThemNSX";
            btn_ThemNSX.Size = new Size(343, 67);
            btn_ThemNSX.TabIndex = 28;
            btn_ThemNSX.Text = "Thêm thông tin NSX";
            btn_ThemNSX.UseVisualStyleBackColor = true;
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "Man_ID";
            Col_CusID.HeaderText = "Mã NSX";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "Man_Name";
            Col_Fullname.HeaderText = "Tên NSX";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 200;
            // 
            // Col_SDT
            // 
            Col_SDT.DataPropertyName = "Man_Location";
            Col_SDT.HeaderText = "Địa chỉ";
            Col_SDT.MinimumWidth = 6;
            Col_SDT.Name = "Col_SDT";
            Col_SDT.Width = 200;
            // 
            // Manufacturers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 748);
            Controls.Add(label8);
            Controls.Add(txt_KetQuaNSX);
            Controls.Add(btnXoaNSX);
            Controls.Add(btn_XoaNSX);
            Controls.Add(btn_ThemNSX);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_NSX);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manufacturers";
            Text = "Manufacturers";
            Load += Manufacturers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_NSX).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_NSX;
        private Panel panel1;
        private TextBox txt_DiaChi;
        private TextBox txt_MaNSX;
        private TextBox txt_TenNSX;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private TextBox txt_KetQuaNSX;
        private Button btnXoaNSX;
        private Button btn_XoaNSX;
        private Button btn_ThemNSX;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_SDT;
    }
}