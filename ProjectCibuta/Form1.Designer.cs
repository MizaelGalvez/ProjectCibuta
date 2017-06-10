namespace ProjectCibuta
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Selector1 = new System.Windows.Forms.ComboBox();
            this.Vincular1 = new System.Windows.Forms.Button();
            this.desvincular1 = new System.Windows.Forms.Button();
            this.DetecciondeMovimiento = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Completa1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.layoutnavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.layouttodascamaras = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.Completa3 = new System.Windows.Forms.Button();
            this.Vinculae3 = new System.Windows.Forms.Button();
            this.Desvincular3 = new System.Windows.Forms.Button();
            this.Selector3 = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Completa2 = new System.Windows.Forms.Button();
            this.Vincular2 = new System.Windows.Forms.Button();
            this.Desvincular2 = new System.Windows.Forms.Button();
            this.Selector2 = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Completa4 = new System.Windows.Forms.Button();
            this.Vincular4 = new System.Windows.Forms.Button();
            this.Desvincular4 = new System.Windows.Forms.Button();
            this.Selector4 = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.VideosGuardados = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.layoutnavegacion.SuspendLayout();
            this.layouttodascamaras.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Selector1
            // 
            this.Selector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector1.FormattingEnabled = true;
            this.Selector1.Location = new System.Drawing.Point(74, 3);
            this.Selector1.Name = "Selector1";
            this.Selector1.Size = new System.Drawing.Size(207, 24);
            this.Selector1.TabIndex = 1;
            // 
            // Vincular1
            // 
            this.Vincular1.BackColor = System.Drawing.Color.LimeGreen;
            this.Vincular1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vincular1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vincular1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Vincular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vincular1.ForeColor = System.Drawing.Color.DimGray;
            this.Vincular1.Location = new System.Drawing.Point(322, 3);
            this.Vincular1.Name = "Vincular1";
            this.Vincular1.Size = new System.Drawing.Size(65, 24);
            this.Vincular1.TabIndex = 2;
            this.Vincular1.UseVisualStyleBackColor = false;
            this.Vincular1.Click += new System.EventHandler(this.Vincular1_Click);
            // 
            // desvincular1
            // 
            this.desvincular1.BackColor = System.Drawing.Color.Black;
            this.desvincular1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.desvincular1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desvincular1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.desvincular1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.desvincular1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.desvincular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desvincular1.ForeColor = System.Drawing.Color.DarkGray;
            this.desvincular1.Location = new System.Drawing.Point(287, 3);
            this.desvincular1.Name = "desvincular1";
            this.desvincular1.Size = new System.Drawing.Size(29, 24);
            this.desvincular1.TabIndex = 3;
            this.desvincular1.UseVisualStyleBackColor = false;
            this.desvincular1.Click += new System.EventHandler(this.Desvincular1_Click);
            // 
            // DetecciondeMovimiento
            // 
            this.DetecciondeMovimiento.Enabled = true;
            this.DetecciondeMovimiento.Interval = 10;
            this.DetecciondeMovimiento.Tick += new System.EventHandler(this.DeteccionMovimiento);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.57914F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.42086F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 292);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 2);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.Completa1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Vincular1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.desvincular1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Selector1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 30);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // Completa1
            // 
            this.Completa1.BackColor = System.Drawing.Color.Gainsboro;
            this.Completa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Completa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Completa1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Completa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completa1.Location = new System.Drawing.Point(393, 3);
            this.Completa1.Name = "Completa1";
            this.Completa1.Size = new System.Drawing.Size(29, 24);
            this.Completa1.TabIndex = 4;
            this.Completa1.UseVisualStyleBackColor = false;
            this.Completa1.Click += new System.EventHandler(this.Completa1_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(425, 242);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // layoutnavegacion
            // 
            this.layoutnavegacion.ColumnCount = 3;
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutnavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.layoutnavegacion.Controls.Add(this.layouttodascamaras, 1, 0);
            this.layoutnavegacion.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.layoutnavegacion.Controls.Add(this.pictureBox5, 2, 0);
            this.layoutnavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutnavegacion.Location = new System.Drawing.Point(0, 0);
            this.layoutnavegacion.Name = "layoutnavegacion";
            this.layoutnavegacion.RowCount = 1;
            this.layoutnavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutnavegacion.Size = new System.Drawing.Size(1117, 615);
            this.layoutnavegacion.TabIndex = 13;
            // 
            // layouttodascamaras
            // 
            this.layouttodascamaras.ColumnCount = 2;
            this.layouttodascamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layouttodascamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.layouttodascamaras.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.layouttodascamaras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layouttodascamaras.Location = new System.Drawing.Point(226, 3);
            this.layouttodascamaras.Name = "layouttodascamaras";
            this.layouttodascamaras.RowCount = 2;
            this.layouttodascamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layouttodascamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layouttodascamaras.Size = new System.Drawing.Size(887, 609);
            this.layouttodascamaras.TabIndex = 13;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 307);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(437, 299);
            this.tableLayoutPanel11.TabIndex = 17;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.videoSourcePlayer4, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.57914F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.42086F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(431, 293);
            this.tableLayoutPanel12.TabIndex = 12;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(425, 2);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 5;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.Controls.Add(this.Completa3, 4, 0);
            this.tableLayoutPanel13.Controls.Add(this.Vinculae3, 3, 0);
            this.tableLayoutPanel13.Controls.Add(this.Desvincular3, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.Selector3, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 260);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(425, 30);
            this.tableLayoutPanel13.TabIndex = 11;
            // 
            // Completa3
            // 
            this.Completa3.BackColor = System.Drawing.Color.Gainsboro;
            this.Completa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Completa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Completa3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Completa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completa3.Location = new System.Drawing.Point(393, 3);
            this.Completa3.Name = "Completa3";
            this.Completa3.Size = new System.Drawing.Size(29, 24);
            this.Completa3.TabIndex = 4;
            this.Completa3.UseVisualStyleBackColor = false;
            this.Completa3.Click += new System.EventHandler(this.Completa3_Click);
            // 
            // Vinculae3
            // 
            this.Vinculae3.BackColor = System.Drawing.Color.LimeGreen;
            this.Vinculae3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vinculae3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vinculae3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Vinculae3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vinculae3.ForeColor = System.Drawing.Color.DimGray;
            this.Vinculae3.Location = new System.Drawing.Point(322, 3);
            this.Vinculae3.Name = "Vinculae3";
            this.Vinculae3.Size = new System.Drawing.Size(65, 24);
            this.Vinculae3.TabIndex = 2;
            this.Vinculae3.UseVisualStyleBackColor = false;
            this.Vinculae3.Click += new System.EventHandler(this.Vinculae3_Click);
            // 
            // Desvincular3
            // 
            this.Desvincular3.BackColor = System.Drawing.Color.Black;
            this.Desvincular3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desvincular3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desvincular3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Desvincular3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Desvincular3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Desvincular3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desvincular3.ForeColor = System.Drawing.Color.DarkGray;
            this.Desvincular3.Location = new System.Drawing.Point(287, 3);
            this.Desvincular3.Name = "Desvincular3";
            this.Desvincular3.Size = new System.Drawing.Size(29, 24);
            this.Desvincular3.TabIndex = 3;
            this.Desvincular3.UseVisualStyleBackColor = false;
            this.Desvincular3.Click += new System.EventHandler(this.Desvincular3_Click);
            // 
            // Selector3
            // 
            this.Selector3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector3.FormattingEnabled = true;
            this.Selector3.Location = new System.Drawing.Point(74, 3);
            this.Selector3.Name = "Selector3";
            this.Selector3.Size = new System.Drawing.Size(207, 24);
            this.Selector3.TabIndex = 1;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer4.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.Size = new System.Drawing.Size(425, 243);
            this.videoSourcePlayer4.TabIndex = 0;
            this.videoSourcePlayer4.Text = "videoSourcePlayer4";
            this.videoSourcePlayer4.VideoSource = null;
            this.videoSourcePlayer4.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer4_NewFrame_1);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(437, 298);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(446, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(438, 298);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.videoSourcePlayer2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.57914F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.42086F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(432, 292);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 2);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel7.Controls.Add(this.Completa2, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.Vincular2, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.Desvincular2, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.Selector2, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(426, 30);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // Completa2
            // 
            this.Completa2.BackColor = System.Drawing.Color.Gainsboro;
            this.Completa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Completa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Completa2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Completa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completa2.Location = new System.Drawing.Point(393, 3);
            this.Completa2.Name = "Completa2";
            this.Completa2.Size = new System.Drawing.Size(30, 24);
            this.Completa2.TabIndex = 4;
            this.Completa2.UseVisualStyleBackColor = false;
            this.Completa2.Click += new System.EventHandler(this.Completa2_Click);
            // 
            // Vincular2
            // 
            this.Vincular2.BackColor = System.Drawing.Color.LimeGreen;
            this.Vincular2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vincular2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vincular2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Vincular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vincular2.ForeColor = System.Drawing.Color.DimGray;
            this.Vincular2.Location = new System.Drawing.Point(322, 3);
            this.Vincular2.Name = "Vincular2";
            this.Vincular2.Size = new System.Drawing.Size(65, 24);
            this.Vincular2.TabIndex = 2;
            this.Vincular2.UseVisualStyleBackColor = false;
            this.Vincular2.Click += new System.EventHandler(this.Vincular2_Click);
            // 
            // Desvincular2
            // 
            this.Desvincular2.BackColor = System.Drawing.Color.Black;
            this.Desvincular2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desvincular2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desvincular2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Desvincular2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Desvincular2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Desvincular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desvincular2.ForeColor = System.Drawing.Color.DarkGray;
            this.Desvincular2.Location = new System.Drawing.Point(287, 3);
            this.Desvincular2.Name = "Desvincular2";
            this.Desvincular2.Size = new System.Drawing.Size(29, 24);
            this.Desvincular2.TabIndex = 3;
            this.Desvincular2.UseVisualStyleBackColor = false;
            this.Desvincular2.Click += new System.EventHandler(this.Desvincular2_Click);
            // 
            // Selector2
            // 
            this.Selector2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector2.FormattingEnabled = true;
            this.Selector2.Location = new System.Drawing.Point(74, 3);
            this.Selector2.Name = "Selector2";
            this.Selector2.Size = new System.Drawing.Size(207, 24);
            this.Selector2.TabIndex = 1;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(426, 242);
            this.videoSourcePlayer2.TabIndex = 0;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer2_NewFrame_1);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(446, 307);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(438, 299);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.videoSourcePlayer3, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.58F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.42F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(432, 293);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(426, 2);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel10.Controls.Add(this.Completa4, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.Vincular4, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.Desvincular4, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.Selector4, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 260);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(426, 30);
            this.tableLayoutPanel10.TabIndex = 11;
            // 
            // Completa4
            // 
            this.Completa4.BackColor = System.Drawing.Color.Gainsboro;
            this.Completa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Completa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Completa4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Completa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completa4.Location = new System.Drawing.Point(393, 3);
            this.Completa4.Name = "Completa4";
            this.Completa4.Size = new System.Drawing.Size(30, 24);
            this.Completa4.TabIndex = 4;
            this.Completa4.UseVisualStyleBackColor = false;
            this.Completa4.Click += new System.EventHandler(this.Completa4_Click);
            // 
            // Vincular4
            // 
            this.Vincular4.BackColor = System.Drawing.Color.LimeGreen;
            this.Vincular4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vincular4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vincular4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Vincular4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vincular4.ForeColor = System.Drawing.Color.DimGray;
            this.Vincular4.Location = new System.Drawing.Point(322, 3);
            this.Vincular4.Name = "Vincular4";
            this.Vincular4.Size = new System.Drawing.Size(65, 24);
            this.Vincular4.TabIndex = 2;
            this.Vincular4.UseVisualStyleBackColor = false;
            this.Vincular4.Click += new System.EventHandler(this.Vincular4_Click);
            // 
            // Desvincular4
            // 
            this.Desvincular4.BackColor = System.Drawing.Color.Black;
            this.Desvincular4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desvincular4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desvincular4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Desvincular4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Desvincular4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Desvincular4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desvincular4.ForeColor = System.Drawing.Color.DarkGray;
            this.Desvincular4.Location = new System.Drawing.Point(287, 3);
            this.Desvincular4.Name = "Desvincular4";
            this.Desvincular4.Size = new System.Drawing.Size(29, 24);
            this.Desvincular4.TabIndex = 3;
            this.Desvincular4.UseVisualStyleBackColor = false;
            this.Desvincular4.Click += new System.EventHandler(this.Desvincular4_Click);
            // 
            // Selector4
            // 
            this.Selector4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selector4.FormattingEnabled = true;
            this.Selector4.Location = new System.Drawing.Point(74, 3);
            this.Selector4.Name = "Selector4";
            this.Selector4.Size = new System.Drawing.Size(207, 24);
            this.Selector4.TabIndex = 1;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.videoSourcePlayer3.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(426, 243);
            this.videoSourcePlayer3.TabIndex = 0;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer3_NewFrame_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.VideosGuardados, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Home, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.05085F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(217, 609);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // VideosGuardados
            // 
            this.VideosGuardados.BackColor = System.Drawing.Color.Tomato;
            this.VideosGuardados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideosGuardados.Location = new System.Drawing.Point(3, 408);
            this.VideosGuardados.Name = "VideosGuardados";
            this.VideosGuardados.Size = new System.Drawing.Size(211, 47);
            this.VideosGuardados.TabIndex = 0;
            this.VideosGuardados.Text = "Videos Guardados";
            this.VideosGuardados.UseVisualStyleBackColor = false;
            this.VideosGuardados.Click += new System.EventHandler(this.VideosGuardados_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Tomato;
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(3, 248);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(211, 44);
            this.Home.TabIndex = 1;
            this.Home.Text = "Camaras";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(1119, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 609);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1117, 615);
            this.Controls.Add(this.layoutnavegacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.layoutnavegacion.ResumeLayout(false);
            this.layouttodascamaras.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox Selector1;
        private System.Windows.Forms.Button Vincular1;
        private System.Windows.Forms.Button desvincular1;
        private System.Windows.Forms.Timer DetecciondeMovimiento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel layoutnavegacion;
        private System.Windows.Forms.TableLayoutPanel layouttodascamaras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Completa1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button Completa3;
        private System.Windows.Forms.Button Vinculae3;
        private System.Windows.Forms.Button Desvincular3;
        private System.Windows.Forms.ComboBox Selector3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button Completa2;
        private System.Windows.Forms.Button Vincular2;
        private System.Windows.Forms.Button Desvincular2;
        private System.Windows.Forms.ComboBox Selector2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button Completa4;
        private System.Windows.Forms.Button Vincular4;
        private System.Windows.Forms.Button Desvincular4;
        private System.Windows.Forms.ComboBox Selector4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button VideosGuardados;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

