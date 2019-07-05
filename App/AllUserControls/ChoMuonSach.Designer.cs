namespace App.AllUserControls
{
    partial class ChoMuonSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoMuonSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMuon = new System.Windows.Forms.DataGridView();
            this.ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBt = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngaytradate = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Ngaymuondate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Masachtxt = new System.Windows.Forms.TextBox();
            this.Madocgiatxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.theloaicombo = new System.Windows.Forms.ComboBox();
            this.Tensachtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tacgiatxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 625);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 561);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMuon);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1191, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 57;
            this.button1.Text = "Danh sách ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMuon
            // 
            this.dataGridViewMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMuon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ms,
            this.ts,
            this.tl,
            this.tg,
            this.tt});
            this.dataGridViewMuon.Location = new System.Drawing.Point(4, 300);
            this.dataGridViewMuon.Name = "dataGridViewMuon";
            this.dataGridViewMuon.RowTemplate.Height = 24;
            this.dataGridViewMuon.Size = new System.Drawing.Size(1174, 245);
            this.dataGridViewMuon.TabIndex = 56;
            this.dataGridViewMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMuon_CellClick);
            this.dataGridViewMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMuon_CellContentClick);
            this.dataGridViewMuon.SelectionChanged += new System.EventHandler(this.dataGridViewMuon_SelectionChanged);
            this.dataGridViewMuon.Click += new System.EventHandler(this.dataGridViewMuon_Click);
            // 
            // ms
            // 
            this.ms.HeaderText = "Mã Sách";
            this.ms.Name = "ms";
            // 
            // ts
            // 
            this.ts.HeaderText = "Tên Sách";
            this.ts.Name = "ts";
            // 
            // tl
            // 
            this.tl.HeaderText = "Thể Loại";
            this.tl.Name = "tl";
            // 
            // tg
            // 
            this.tg.HeaderText = "Tác Giả";
            this.tg.Name = "tg";
            // 
            // tt
            // 
            this.tt.HeaderText = "Tình Trạng";
            this.tt.Name = "tt";
            // 
            // AddBt
            // 
            this.AddBt.AutoSize = true;
            this.AddBt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.Image = ((System.Drawing.Image)(resources.GetObject("AddBt.Image")));
            this.AddBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBt.Location = new System.Drawing.Point(202, 229);
            this.AddBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(121, 50);
            this.AddBt.TabIndex = 49;
            this.AddBt.Text = "TIm";
            this.AddBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(424, 105);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 50);
            this.EditButton.TabIndex = 50;
            this.EditButton.Text = "Sửa";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.AutoSize = true;
            this.SaveEditButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEditButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveEditButton.Image")));
            this.SaveEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveEditButton.Location = new System.Drawing.Point(424, 32);
            this.SaveEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(121, 50);
            this.SaveEditButton.TabIndex = 55;
            this.SaveEditButton.Text = "Lưu";
            this.SaveEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ngaytradate);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.Ngaymuondate);
            this.groupBox2.Controls.Add(this.SaveEditButton);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Masachtxt);
            this.groupBox2.Controls.Add(this.Madocgiatxt);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(533, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 287);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Mượn Sách";
            // 
            // ngaytradate
            // 
            this.ngaytradate.CustomFormat = "dd/MM/yyyy";
            this.ngaytradate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytradate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytradate.Location = new System.Drawing.Point(137, 226);
            this.ngaytradate.Margin = new System.Windows.Forms.Padding(4);
            this.ngaytradate.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.ngaytradate.MinDate = new System.DateTime(1964, 1, 1, 0, 0, 0, 0);
            this.ngaytradate.Name = "ngaytradate";
            this.ngaytradate.Size = new System.Drawing.Size(195, 30);
            this.ngaytradate.TabIndex = 57;
            this.ngaytradate.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
          
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(424, 184);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 50);
            this.DeleteButton.TabIndex = 51;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // Ngaymuondate
            // 
            this.Ngaymuondate.CustomFormat = "dd/MM/yyyy";
            this.Ngaymuondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngaymuondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngaymuondate.Location = new System.Drawing.Point(137, 172);
            this.Ngaymuondate.Margin = new System.Windows.Forms.Padding(4);
            this.Ngaymuondate.MaxDate = new System.DateTime(2030, 12, 29, 0, 0, 0, 0);
            this.Ngaymuondate.MinDate = new System.DateTime(1964, 1, 1, 0, 0, 0, 0);
            this.Ngaymuondate.Name = "Ngaymuondate";
            this.Ngaymuondate.Size = new System.Drawing.Size(195, 30);
            this.Ngaymuondate.TabIndex = 57;
            this.Ngaymuondate.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.Ngaymuondate.ValueChanged += new System.EventHandler(this.Ngaymuondate_ValueChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(11, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 2);
            this.label8.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(11, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 2);
            this.label11.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(13, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 2);
            this.label12.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(11, 229);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 28);
            this.label19.TabIndex = 53;
            this.label19.Text = "Ngày Trả:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 173);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 28);
            this.label17.TabIndex = 53;
            this.label17.Text = "Ngày Mượn:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 106);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 28);
            this.label14.TabIndex = 53;
            this.label14.Text = "Mã Sách:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 28);
            this.label15.TabIndex = 53;
            this.label15.Text = "Mã Độc Giả:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Masachtxt
            // 
            this.Masachtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masachtxt.Location = new System.Drawing.Point(137, 96);
            this.Masachtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Masachtxt.Multiline = true;
            this.Masachtxt.Name = "Masachtxt";
            this.Masachtxt.Size = new System.Drawing.Size(215, 37);
            this.Masachtxt.TabIndex = 51;
            this.Masachtxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Madocgiatxt
            // 
            this.Madocgiatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Madocgiatxt.Location = new System.Drawing.Point(137, 33);
            this.Madocgiatxt.Margin = new System.Windows.Forms.Padding(4);
            this.Madocgiatxt.Multiline = true;
            this.Madocgiatxt.Name = "Madocgiatxt";
            this.Madocgiatxt.Size = new System.Drawing.Size(215, 37);
            this.Madocgiatxt.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.theloaicombo);
            this.groupBox1.Controls.Add(this.Tensachtxt);
            this.groupBox1.Controls.Add(this.AddBt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tacgiatxt);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 287);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // theloaicombo
            // 
            this.theloaicombo.FormattingEnabled = true;
            this.theloaicombo.Location = new System.Drawing.Point(132, 172);
            this.theloaicombo.Name = "theloaicombo";
            this.theloaicombo.Size = new System.Drawing.Size(179, 31);
            this.theloaicombo.TabIndex = 58;
            // 
            // Tensachtxt
            // 
            this.Tensachtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensachtxt.Location = new System.Drawing.Point(134, 36);
            this.Tensachtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Tensachtxt.Multiline = true;
            this.Tensachtxt.Name = "Tensachtxt";
            this.Tensachtxt.Size = new System.Drawing.Size(179, 37);
            this.Tensachtxt.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(-2, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 2);
            this.label6.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 2);
            this.label4.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 2);
            this.label2.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Thể Loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tác Giả";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên Sách:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tacgiatxt
            // 
            this.tacgiatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacgiatxt.Location = new System.Drawing.Point(134, 96);
            this.tacgiatxt.Margin = new System.Windows.Forms.Padding(4);
            this.tacgiatxt.Multiline = true;
            this.tacgiatxt.Name = "tacgiatxt";
            this.tacgiatxt.Size = new System.Drawing.Size(179, 37);
            this.tacgiatxt.TabIndex = 51;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1191, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 519);
            this.dataGridView1.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(9, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 609);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Location = new System.Drawing.Point(24, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 49);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phiếu Mượn Sách";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 566);
            this.panel4.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(12, 201);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 2);
            this.label18.TabIndex = 56;
            // 
            // ChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChoMuonSach";
            this.Size = new System.Drawing.Size(1229, 628);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker ngaytradate;
        private System.Windows.Forms.DateTimePicker Ngaymuondate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Masachtxt;
        private System.Windows.Forms.TextBox Madocgiatxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tacgiatxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Tensachtxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox theloaicombo;
        private System.Windows.Forms.DataGridView dataGridViewMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ts;
        private System.Windows.Forms.DataGridViewTextBoxColumn tl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.Label label18;
    }
}
