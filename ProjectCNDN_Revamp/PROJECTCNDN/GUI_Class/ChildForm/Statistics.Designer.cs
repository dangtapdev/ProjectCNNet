namespace GUI_Class.ChildForm
{
    partial class Statistics
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
            dgv_Trans = new DataGridView();
            label1 = new Label();
            dgv_Cars = new DataGridView();
            Col_CarID = new DataGridViewTextBoxColumn();
            Col_NameModel = new DataGridViewTextBoxColumn();
            Col_ManID = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txt_MaGD = new TextBox();
            label4 = new Label();
            txt_MaXe = new TextBox();
            label3 = new Label();
            btn_TimKiemGD = new Button();
            btn_TimKiemXe = new Button();
            panel1 = new Panel();
            txt_SoKH = new TextBox();
            label5 = new Label();
            txt_SLXe = new TextBox();
            txt_SoLuongGD = new TextBox();
            txt_TongGiaTriGD = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_Tong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Trans
            // 
            dgv_Trans.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Trans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trans.Columns.AddRange(new DataGridViewColumn[] { Col_CusID, Col_Fullname, Col_Tong });
            dgv_Trans.Location = new Point(81, 97);
            dgv_Trans.Margin = new Padding(3, 4, 3, 4);
            dgv_Trans.Name = "dgv_Trans";
            dgv_Trans.RowHeadersWidth = 51;
            dgv_Trans.RowTemplate.Height = 25;
            dgv_Trans.Size = new Size(454, 379);
            dgv_Trans.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(169, 44);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 39;
            label1.Text = "Giao dịch đã thực hiện";
            // 
            // dgv_Cars
            // 
            dgv_Cars.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cars.Columns.AddRange(new DataGridViewColumn[] { Col_CarID, Col_NameModel, Col_ManID });
            dgv_Cars.Location = new Point(639, 97);
            dgv_Cars.Margin = new Padding(3, 4, 3, 4);
            dgv_Cars.Name = "dgv_Cars";
            dgv_Cars.RowHeadersWidth = 51;
            dgv_Cars.RowTemplate.Height = 25;
            dgv_Cars.Size = new Size(483, 379);
            dgv_Cars.TabIndex = 40;
            // 
            // Col_CarID
            // 
            Col_CarID.DataPropertyName = "MaXe";
            Col_CarID.HeaderText = "Mã xe";
            Col_CarID.MinimumWidth = 6;
            Col_CarID.Name = "Col_CarID";
            Col_CarID.Width = 110;
            // 
            // Col_NameModel
            // 
            Col_NameModel.DataPropertyName = "TenXe";
            Col_NameModel.HeaderText = "Tên xe";
            Col_NameModel.MinimumWidth = 6;
            Col_NameModel.Name = "Col_NameModel";
            Col_NameModel.Width = 150;
            // 
            // Col_ManID
            // 
            Col_ManID.DataPropertyName = "MaNSX";
            Col_ManID.HeaderText = "Mã nhà SX";
            Col_ManID.MinimumWidth = 6;
            Col_ManID.Name = "Col_ManID";
            Col_ManID.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(794, 44);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 41;
            label2.Text = "Mẫu xe đã nhập";
            // 
            // txt_MaGD
            // 
            txt_MaGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaGD.Location = new Point(200, 491);
            txt_MaGD.Margin = new Padding(3, 4, 3, 4);
            txt_MaGD.Name = "txt_MaGD";
            txt_MaGD.Size = new Size(171, 29);
            txt_MaGD.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(86, 495);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 42;
            label4.Text = "Mã giao dịch : ";
            // 
            // txt_MaXe
            // 
            txt_MaXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaXe.Location = new Point(733, 491);
            txt_MaXe.Margin = new Padding(3, 4, 3, 4);
            txt_MaXe.Name = "txt_MaXe";
            txt_MaXe.Size = new Size(202, 29);
            txt_MaXe.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(667, 495);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 44;
            label3.Text = "Mã xe :";
            // 
            // btn_TimKiemGD
            // 
            btn_TimKiemGD.Location = new Point(382, 484);
            btn_TimKiemGD.Margin = new Padding(3, 4, 3, 4);
            btn_TimKiemGD.Name = "btn_TimKiemGD";
            btn_TimKiemGD.Size = new Size(119, 47);
            btn_TimKiemGD.TabIndex = 46;
            btn_TimKiemGD.Text = "Tìm kiếm";
            btn_TimKiemGD.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiemXe
            // 
            btn_TimKiemXe.Location = new Point(953, 484);
            btn_TimKiemXe.Margin = new Padding(3, 4, 3, 4);
            btn_TimKiemXe.Name = "btn_TimKiemXe";
            btn_TimKiemXe.Size = new Size(119, 47);
            btn_TimKiemXe.TabIndex = 47;
            btn_TimKiemXe.Text = "Tìm kiếm";
            btn_TimKiemXe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_SoKH);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_SLXe);
            panel1.Controls.Add(txt_SoLuongGD);
            panel1.Controls.Add(txt_TongGiaTriGD);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(81, 549);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 134);
            panel1.TabIndex = 48;
            // 
            // txt_SoKH
            // 
            txt_SoKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoKH.Location = new Point(712, 15);
            txt_SoKH.Margin = new Padding(3, 4, 3, 4);
            txt_SoKH.Name = "txt_SoKH";
            txt_SoKH.Size = new Size(282, 29);
            txt_SoKH.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(561, 23);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 18;
            label5.Text = "Số lượng  KH :";
            // 
            // txt_SLXe
            // 
            txt_SLXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SLXe.Location = new Point(712, 68);
            txt_SLXe.Margin = new Padding(3, 4, 3, 4);
            txt_SLXe.Name = "txt_SLXe";
            txt_SLXe.Size = new Size(282, 29);
            txt_SLXe.TabIndex = 17;
            // 
            // txt_SoLuongGD
            // 
            txt_SoLuongGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoLuongGD.Location = new Point(170, 15);
            txt_SoLuongGD.Margin = new Padding(3, 4, 3, 4);
            txt_SoLuongGD.Name = "txt_SoLuongGD";
            txt_SoLuongGD.Size = new Size(282, 29);
            txt_SoLuongGD.TabIndex = 14;
            // 
            // txt_TongGiaTriGD
            // 
            txt_TongGiaTriGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TongGiaTriGD.Location = new Point(170, 64);
            txt_TongGiaTriGD.Margin = new Padding(3, 4, 3, 4);
            txt_TongGiaTriGD.Name = "txt_TongGiaTriGD";
            txt_TongGiaTriGD.Size = new Size(282, 29);
            txt_TongGiaTriGD.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 68);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 8;
            label8.Text = "Tổng giá trị GD :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(561, 79);
            label9.Name = "label9";
            label9.Size = new Size(148, 23);
            label9.TabIndex = 7;
            label9.Text = "Số lượng mẫu xe :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 192);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 19);
            label10.Name = "label10";
            label10.Size = new Size(168, 23);
            label10.TabIndex = 6;
            label10.Text = "Số GD đã thực hiện :";
            // 
            // Col_CusID
            // 
            Col_CusID.DataPropertyName = "MaGD";
            Col_CusID.HeaderText = "Mã GD";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.DataPropertyName = "MaKH";
            Col_Fullname.HeaderText = "Mã KH ";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 110;
            // 
            // Col_Tong
            // 
            Col_Tong.DataPropertyName = "Price";
            Col_Tong.HeaderText = "Giá trị";
            Col_Tong.MinimumWidth = 6;
            Col_Tong.Name = "Col_Tong";
            Col_Tong.Width = 125;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 748);
            Controls.Add(panel1);
            Controls.Add(btn_TimKiemXe);
            Controls.Add(btn_TimKiemGD);
            Controls.Add(txt_MaXe);
            Controls.Add(label3);
            Controls.Add(txt_MaGD);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dgv_Cars);
            Controls.Add(label1);
            Controls.Add(dgv_Trans);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Statistics";
            Text = "Statistics";
            Load += Statistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Trans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cars).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Trans;
        private Label label1;
        private DataGridView dgv_Cars;
        private Label label2;
        private TextBox txt_MaGD;
        private Label label4;
        private TextBox txt_MaXe;
        private Label label3;
        private Button btn_TimKiemGD;
        private Button btn_TimKiemXe;
        private Panel panel1;
        private TextBox txt_SLXe;
        private TextBox txt_SoLuongGD;
        private TextBox txt_TongGiaTriGD;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_SoKH;
        private Label label5;
        private DataGridViewTextBoxColumn Col_CarID;
        private DataGridViewTextBoxColumn Col_NameModel;
        private DataGridViewTextBoxColumn Col_ManID;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_Tong;
    }
}