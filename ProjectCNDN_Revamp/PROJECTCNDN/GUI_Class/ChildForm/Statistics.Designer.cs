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
            Col_CusID = new DataGridViewTextBoxColumn();
            Col_Fullname = new DataGridViewTextBoxColumn();
            Col_Tong = new DataGridViewTextBoxColumn();
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
            dgv_Trans.Location = new Point(71, 73);
            dgv_Trans.Name = "dgv_Trans";
            dgv_Trans.RowHeadersWidth = 51;
            dgv_Trans.RowTemplate.Height = 25;
            dgv_Trans.Size = new Size(397, 284);
            dgv_Trans.TabIndex = 36;
            // 
            // Col_CusID
            // 
            Col_CusID.HeaderText = "Mã GD";
            Col_CusID.MinimumWidth = 6;
            Col_CusID.Name = "Col_CusID";
            Col_CusID.Width = 110;
            // 
            // Col_Fullname
            // 
            Col_Fullname.HeaderText = "Mã KH ";
            Col_Fullname.MinimumWidth = 6;
            Col_Fullname.Name = "Col_Fullname";
            Col_Fullname.Width = 110;
            // 
            // Col_Tong
            // 
            Col_Tong.HeaderText = "Giá trị";
            Col_Tong.MinimumWidth = 6;
            Col_Tong.Name = "Col_Tong";
            Col_Tong.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 33);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 39;
            label1.Text = "Giao dịch đã thực hiện";
            // 
            // dgv_Cars
            // 
            dgv_Cars.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cars.Columns.AddRange(new DataGridViewColumn[] { Col_CarID, Col_NameModel, Col_ManID });
            dgv_Cars.Location = new Point(559, 73);
            dgv_Cars.Name = "dgv_Cars";
            dgv_Cars.RowHeadersWidth = 51;
            dgv_Cars.RowTemplate.Height = 25;
            dgv_Cars.Size = new Size(423, 284);
            dgv_Cars.TabIndex = 40;
            // 
            // Col_CarID
            // 
            Col_CarID.HeaderText = "Mã xe";
            Col_CarID.MinimumWidth = 6;
            Col_CarID.Name = "Col_CarID";
            Col_CarID.Width = 110;
            // 
            // Col_NameModel
            // 
            Col_NameModel.HeaderText = "Tên xe";
            Col_NameModel.MinimumWidth = 6;
            Col_NameModel.Name = "Col_NameModel";
            Col_NameModel.Width = 150;
            // 
            // Col_ManID
            // 
            Col_ManID.HeaderText = "Mã nhà SX";
            Col_ManID.MinimumWidth = 6;
            Col_ManID.Name = "Col_ManID";
            Col_ManID.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(695, 33);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 41;
            label2.Text = "Mẫu xe đã nhập";
            // 
            // txt_MaGD
            // 
            txt_MaGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaGD.Location = new Point(175, 368);
            txt_MaGD.Name = "txt_MaGD";
            txt_MaGD.Size = new Size(150, 25);
            txt_MaGD.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 371);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 42;
            label4.Text = "Mã giao dịch : ";
            // 
            // txt_MaXe
            // 
            txt_MaXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaXe.Location = new Point(641, 368);
            txt_MaXe.Name = "txt_MaXe";
            txt_MaXe.Size = new Size(177, 25);
            txt_MaXe.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(584, 371);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 44;
            label3.Text = "Mã xe :";
            // 
            // btn_TimKiemGD
            // 
            btn_TimKiemGD.Location = new Point(334, 363);
            btn_TimKiemGD.Name = "btn_TimKiemGD";
            btn_TimKiemGD.Size = new Size(104, 35);
            btn_TimKiemGD.TabIndex = 46;
            btn_TimKiemGD.Text = "Tìm kiếm";
            btn_TimKiemGD.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiemXe
            // 
            btn_TimKiemXe.Location = new Point(834, 363);
            btn_TimKiemXe.Name = "btn_TimKiemXe";
            btn_TimKiemXe.Size = new Size(104, 35);
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
            panel1.Location = new Point(71, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 101);
            panel1.TabIndex = 48;
            // 
            // txt_SoKH
            // 
            txt_SoKH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoKH.Location = new Point(623, 11);
            txt_SoKH.Name = "txt_SoKH";
            txt_SoKH.Size = new Size(247, 25);
            txt_SoKH.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(491, 17);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 18;
            label5.Text = "Số lượng  KH :";
            // 
            // txt_SLXe
            // 
            txt_SLXe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SLXe.Location = new Point(623, 51);
            txt_SLXe.Name = "txt_SLXe";
            txt_SLXe.Size = new Size(247, 25);
            txt_SLXe.TabIndex = 17;
            // 
            // txt_SoLuongGD
            // 
            txt_SoLuongGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoLuongGD.Location = new Point(149, 11);
            txt_SoLuongGD.Name = "txt_SoLuongGD";
            txt_SoLuongGD.Size = new Size(247, 25);
            txt_SoLuongGD.TabIndex = 14;
            // 
            // txt_TongGiaTriGD
            // 
            txt_TongGiaTriGD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TongGiaTriGD.Location = new Point(149, 48);
            txt_TongGiaTriGD.Name = "txt_TongGiaTriGD";
            txt_TongGiaTriGD.Size = new Size(247, 25);
            txt_TongGiaTriGD.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 255, 192);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(17, 51);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 8;
            label8.Text = "Tổng giá trị GD :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(491, 59);
            label9.Name = "label9";
            label9.Size = new Size(114, 17);
            label9.TabIndex = 7;
            label9.Text = "Số lượng mẫu xe :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 192);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 14);
            label10.Name = "label10";
            label10.Size = new Size(128, 17);
            label10.TabIndex = 6;
            label10.Text = "Số GD đã thực hiện :";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
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
            Name = "Statistics";
            Text = "Statistics";
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
        private DataGridViewTextBoxColumn Col_CarID;
        private DataGridViewTextBoxColumn Col_NameModel;
        private DataGridViewTextBoxColumn Col_ManID;
        private Label label2;
        private DataGridViewTextBoxColumn Col_CusID;
        private DataGridViewTextBoxColumn Col_Fullname;
        private DataGridViewTextBoxColumn Col_Tong;
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
    }
}