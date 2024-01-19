namespace GUI_Class.ChildForm
{
    partial class Car_models
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
            dgv_Cars = new DataGridView();
            btn_ThemXe = new Button();
            btn_XoaXe = new Button();
            label1 = new Label();
            btn_SuaXe = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_NamSX = new TextBox();
            txt_TenXe = new TextBox();
            txt_MaXe = new TextBox();
            txt_GiaTien = new TextBox();
            txt_MauSon = new TextBox();
            panel1 = new Panel();
            txt_MaNSX = new TextBox();
            txt_KQ = new TextBox();
            label8 = new Label();
            Col_CarID = new DataGridViewTextBoxColumn();
            Col_NameModel = new DataGridViewTextBoxColumn();
            Col_ManID = new DataGridViewTextBoxColumn();
            Col_year = new DataGridViewTextBoxColumn();
            Col_Color = new DataGridViewTextBoxColumn();
            Col_Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Cars
            // 
            dgv_Cars.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cars.Columns.AddRange(new DataGridViewColumn[] { Col_CarID, Col_NameModel, Col_ManID, Col_year, Col_Color, Col_Price });
            dgv_Cars.Location = new Point(24, 65);
            dgv_Cars.Margin = new Padding(3, 4, 3, 4);
            dgv_Cars.Name = "dgv_Cars";
            dgv_Cars.RowHeadersWidth = 51;
            dgv_Cars.RowTemplate.Height = 25;
            dgv_Cars.Size = new Size(823, 399);
            dgv_Cars.TabIndex = 0;
            // 
            // btn_ThemXe
            // 
            btn_ThemXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemXe.Location = new Point(871, 249);
            btn_ThemXe.Margin = new Padding(3, 4, 3, 4);
            btn_ThemXe.Name = "btn_ThemXe";
            btn_ThemXe.Size = new Size(343, 67);
            btn_ThemXe.TabIndex = 1;
            btn_ThemXe.Text = "Thêm thông tin xe";
            btn_ThemXe.UseVisualStyleBackColor = true;
            // 
            // btn_XoaXe
            // 
            btn_XoaXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaXe.Location = new Point(871, 399);
            btn_XoaXe.Margin = new Padding(3, 4, 3, 4);
            btn_XoaXe.Name = "btn_XoaXe";
            btn_XoaXe.Size = new Size(343, 67);
            btn_XoaXe.TabIndex = 2;
            btn_XoaXe.Text = "Xóa thông tin xe";
            btn_XoaXe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 4;
            label1.Text = "Thông tin chi tiết mẫu xe";
            // 
            // btn_SuaXe
            // 
            btn_SuaXe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaXe.Location = new Point(871, 324);
            btn_SuaXe.Margin = new Padding(3, 4, 3, 4);
            btn_SuaXe.Name = "btn_SuaXe";
            btn_SuaXe.Size = new Size(343, 67);
            btn_SuaXe.TabIndex = 5;
            btn_SuaXe.Text = "Sửa thông tin xe";
            btn_SuaXe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 6;
            label2.Text = "Mã xe :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 136);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 7;
            label3.Text = "Mã NSX :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 79);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 8;
            label4.Text = "Tên xe :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(445, 24);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 9;
            label5.Text = "Năm SX :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(445, 80);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 10;
            label6.Text = "Màu sơn :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(445, 137);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 11;
            label7.Text = "Giá tiền :";
            // 
            // txt_NamSX
            // 
            txt_NamSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NamSX.Location = new Point(522, 23);
            txt_NamSX.Margin = new Padding(3, 4, 3, 4);
            txt_NamSX.Name = "txt_NamSX";
            txt_NamSX.Size = new Size(282, 29);
            txt_NamSX.TabIndex = 12;
            // 
            // txt_TenXe
            // 
            txt_TenXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenXe.Location = new Point(91, 80);
            txt_TenXe.Margin = new Padding(3, 4, 3, 4);
            txt_TenXe.Name = "txt_TenXe";
            txt_TenXe.Size = new Size(282, 29);
            txt_TenXe.TabIndex = 13;
            // 
            // txt_MaXe
            // 
            txt_MaXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaXe.Location = new Point(91, 24);
            txt_MaXe.Margin = new Padding(3, 4, 3, 4);
            txt_MaXe.Name = "txt_MaXe";
            txt_MaXe.Size = new Size(282, 29);
            txt_MaXe.TabIndex = 14;
            // 
            // txt_GiaTien
            // 
            txt_GiaTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_GiaTien.Location = new Point(522, 136);
            txt_GiaTien.Margin = new Padding(3, 4, 3, 4);
            txt_GiaTien.Name = "txt_GiaTien";
            txt_GiaTien.Size = new Size(282, 29);
            txt_GiaTien.TabIndex = 15;
            // 
            // txt_MauSon
            // 
            txt_MauSon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MauSon.Location = new Point(522, 80);
            txt_MauSon.Margin = new Padding(3, 4, 3, 4);
            txt_MauSon.Name = "txt_MauSon";
            txt_MauSon.Size = new Size(282, 29);
            txt_MauSon.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_MaNSX);
            panel1.Controls.Add(txt_MauSon);
            panel1.Controls.Add(txt_GiaTien);
            panel1.Controls.Add(txt_MaXe);
            panel1.Controls.Add(txt_TenXe);
            panel1.Controls.Add(txt_NamSX);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 503);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 197);
            panel1.TabIndex = 18;
            // 
            // txt_MaNSX
            // 
            txt_MaNSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaNSX.Location = new Point(91, 132);
            txt_MaNSX.Margin = new Padding(3, 4, 3, 4);
            txt_MaNSX.Name = "txt_MaNSX";
            txt_MaNSX.Size = new Size(282, 29);
            txt_MaNSX.TabIndex = 17;
            // 
            // txt_KQ
            // 
            txt_KQ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_KQ.Location = new Point(871, 67);
            txt_KQ.Margin = new Padding(3, 4, 3, 4);
            txt_KQ.Multiline = true;
            txt_KQ.Name = "txt_KQ";
            txt_KQ.Size = new Size(342, 161);
            txt_KQ.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(871, 19);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 18;
            label8.Text = "Kết quả :";
            // 
            // Col_CarID
            // 
            Col_CarID.DataPropertyName = "Car_ID";
            Col_CarID.HeaderText = "Mã xe";
            Col_CarID.MinimumWidth = 6;
            Col_CarID.Name = "Col_CarID";
            Col_CarID.Width = 110;
            // 
            // Col_NameModel
            // 
            Col_NameModel.DataPropertyName = "Model_Name";
            Col_NameModel.HeaderText = "Tên xe";
            Col_NameModel.MinimumWidth = 6;
            Col_NameModel.Name = "Col_NameModel";
            Col_NameModel.Width = 150;
            // 
            // Col_ManID
            // 
            Col_ManID.DataPropertyName = "Man_ID";
            Col_ManID.HeaderText = "Mã nhà SX";
            Col_ManID.MinimumWidth = 6;
            Col_ManID.Name = "Col_ManID";
            Col_ManID.Width = 110;
            // 
            // Col_year
            // 
            Col_year.DataPropertyName = "Model_Year";
            Col_year.HeaderText = "Năm SX";
            Col_year.MinimumWidth = 6;
            Col_year.Name = "Col_year";
            Col_year.Width = 125;
            // 
            // Col_Color
            // 
            Col_Color.DataPropertyName = "PaintColor";
            Col_Color.HeaderText = "Màu sơn";
            Col_Color.MinimumWidth = 6;
            Col_Color.Name = "Col_Color";
            Col_Color.Width = 125;
            // 
            // Col_Price
            // 
            Col_Price.DataPropertyName = "Price";
            Col_Price.HeaderText = "Giá tiền";
            Col_Price.MinimumWidth = 6;
            Col_Price.Name = "Col_Price";
            Col_Price.Width = 104;
            // 
            // Car_models
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 748);
            Controls.Add(label8);
            Controls.Add(txt_KQ);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgv_Cars);
            Controls.Add(btn_XoaXe);
            Controls.Add(btn_SuaXe);
            Controls.Add(btn_ThemXe);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Car_models";
            Text = "Car_models";
            Load += Car_models_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Cars;
        private Button btn_ThemXe;
        private Button btn_XoaXe;
        private Label label1;
        private Button btn_SuaXe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_NamSX;
        private TextBox txt_TenXe;
        private TextBox txt_MaXe;
        private TextBox txt_GiaTien;
        private TextBox txt_MauSon;
        private Panel panel1;
        private TextBox txt_KQ;
        private TextBox txt_MaNSX;
        private Label label8;
        private DataGridViewTextBoxColumn Col_CarID;
        private DataGridViewTextBoxColumn Col_NameModel;
        private DataGridViewTextBoxColumn Col_ManID;
        private DataGridViewTextBoxColumn Col_year;
        private DataGridViewTextBoxColumn Col_Color;
        private DataGridViewTextBoxColumn Col_Price;
    }
}