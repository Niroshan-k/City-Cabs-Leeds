namespace CityCabsLeeds
{
    partial class Addvehicle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addvehicle));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.carid = new System.Windows.Forms.Label();
            this.carmodel = new System.Windows.Forms.Label();
            this.carmake = new System.Windows.Forms.Label();
            this.carplateno = new System.Windows.Forms.Label();
            this.textBox1car = new System.Windows.Forms.TextBox();
            this.textBox4car = new System.Windows.Forms.TextBox();
            this.textBox3car = new System.Windows.Forms.TextBox();
            this.textBox2car = new System.Windows.Forms.TextBox();
            this.cartype = new System.Windows.Forms.Label();
            this.comboBoxcar = new System.Windows.Forms.ComboBox();
            this.caradd = new System.Windows.Forms.Button();
            this.carremove = new System.Windows.Forms.Button();
            this.carclear = new System.Windows.Forms.Button();
            this.clearvan = new System.Windows.Forms.Button();
            this.removevan = new System.Windows.Forms.Button();
            this.addvan = new System.Windows.Forms.Button();
            this.textBox2van = new System.Windows.Forms.TextBox();
            this.textBox3van = new System.Windows.Forms.TextBox();
            this.textBox4van = new System.Windows.Forms.TextBox();
            this.textBox1van = new System.Windows.Forms.TextBox();
            this.vanplateno = new System.Windows.Forms.Label();
            this.vanmake = new System.Windows.Forms.Label();
            this.vanmodel = new System.Windows.Forms.Label();
            this.vanid = new System.Windows.Forms.Label();
            this.clearsuv = new System.Windows.Forms.Button();
            this.removesuv = new System.Windows.Forms.Button();
            this.addsuv = new System.Windows.Forms.Button();
            this.textBox2suv = new System.Windows.Forms.TextBox();
            this.textBox3suv = new System.Windows.Forms.TextBox();
            this.textBox4suv = new System.Windows.Forms.TextBox();
            this.textBox1suv = new System.Windows.Forms.TextBox();
            this.suvplateno = new System.Windows.Forms.Label();
            this.suvmake = new System.Windows.Forms.Label();
            this.suvmodel = new System.Windows.Forms.Label();
            this.suvid = new System.Windows.Forms.Label();
            this.caridgen = new System.Windows.Forms.Button();
            this.vanidgen = new System.Windows.Forms.Button();
            this.suvidgen = new System.Windows.Forms.Button();
            this.dataGridViewcar = new System.Windows.Forms.DataGridView();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.dataGridViewvan = new System.Windows.Forms.DataGridView();
            this.dataGridViewsuv = new System.Windows.Forms.DataGridView();
            this.navbar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsuv)).BeginInit();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "CAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "VAN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "SUV";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // carid
            // 
            this.carid.AutoSize = true;
            this.carid.BackColor = System.Drawing.Color.Black;
            this.carid.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carid.ForeColor = System.Drawing.Color.White;
            this.carid.Location = new System.Drawing.Point(271, 44);
            this.carid.Name = "carid";
            this.carid.Size = new System.Drawing.Size(70, 22);
            this.carid.TabIndex = 7;
            this.carid.Text = "CAR ID";
            // 
            // carmodel
            // 
            this.carmodel.AutoSize = true;
            this.carmodel.BackColor = System.Drawing.Color.Black;
            this.carmodel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carmodel.ForeColor = System.Drawing.Color.White;
            this.carmodel.Location = new System.Drawing.Point(255, 77);
            this.carmodel.Name = "carmodel";
            this.carmodel.Size = new System.Drawing.Size(98, 22);
            this.carmodel.TabIndex = 8;
            this.carmodel.Text = "Car Model";
            // 
            // carmake
            // 
            this.carmake.AutoSize = true;
            this.carmake.BackColor = System.Drawing.Color.Black;
            this.carmake.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carmake.ForeColor = System.Drawing.Color.White;
            this.carmake.Location = new System.Drawing.Point(259, 111);
            this.carmake.Name = "carmake";
            this.carmake.Size = new System.Drawing.Size(91, 22);
            this.carmake.TabIndex = 9;
            this.carmake.Text = "Car Make";
            // 
            // carplateno
            // 
            this.carplateno.AutoSize = true;
            this.carplateno.BackColor = System.Drawing.Color.Black;
            this.carplateno.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carplateno.ForeColor = System.Drawing.Color.White;
            this.carplateno.Location = new System.Drawing.Point(263, 146);
            this.carplateno.Name = "carplateno";
            this.carplateno.Size = new System.Drawing.Size(85, 22);
            this.carplateno.TabIndex = 10;
            this.carplateno.Text = "Plate NO";
            // 
            // textBox1car
            // 
            this.textBox1car.BackColor = System.Drawing.Color.Black;
            this.textBox1car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1car.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1car.ForeColor = System.Drawing.Color.White;
            this.textBox1car.Location = new System.Drawing.Point(378, 40);
            this.textBox1car.Name = "textBox1car";
            this.textBox1car.Size = new System.Drawing.Size(266, 19);
            this.textBox1car.TabIndex = 11;
            // 
            // textBox4car
            // 
            this.textBox4car.BackColor = System.Drawing.Color.Black;
            this.textBox4car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4car.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4car.ForeColor = System.Drawing.Color.White;
            this.textBox4car.Location = new System.Drawing.Point(378, 142);
            this.textBox4car.Name = "textBox4car";
            this.textBox4car.Size = new System.Drawing.Size(266, 19);
            this.textBox4car.TabIndex = 12;
            // 
            // textBox3car
            // 
            this.textBox3car.BackColor = System.Drawing.Color.Black;
            this.textBox3car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3car.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3car.ForeColor = System.Drawing.Color.White;
            this.textBox3car.Location = new System.Drawing.Point(378, 107);
            this.textBox3car.Name = "textBox3car";
            this.textBox3car.Size = new System.Drawing.Size(266, 19);
            this.textBox3car.TabIndex = 13;
            // 
            // textBox2car
            // 
            this.textBox2car.BackColor = System.Drawing.Color.Black;
            this.textBox2car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2car.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2car.ForeColor = System.Drawing.Color.White;
            this.textBox2car.Location = new System.Drawing.Point(378, 73);
            this.textBox2car.Name = "textBox2car";
            this.textBox2car.Size = new System.Drawing.Size(266, 19);
            this.textBox2car.TabIndex = 14;
            // 
            // cartype
            // 
            this.cartype.AutoSize = true;
            this.cartype.BackColor = System.Drawing.Color.Black;
            this.cartype.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartype.ForeColor = System.Drawing.Color.White;
            this.cartype.Location = new System.Drawing.Point(288, 184);
            this.cartype.Name = "cartype";
            this.cartype.Size = new System.Drawing.Size(53, 22);
            this.cartype.TabIndex = 15;
            this.cartype.Text = "Type";
            // 
            // comboBoxcar
            // 
            this.comboBoxcar.BackColor = System.Drawing.Color.Gold;
            this.comboBoxcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcar.FormattingEnabled = true;
            this.comboBoxcar.Items.AddRange(new object[] {
            "HYBRID",
            "DIESEL",
            "ELECTRIC"});
            this.comboBoxcar.Location = new System.Drawing.Point(378, 184);
            this.comboBoxcar.Name = "comboBoxcar";
            this.comboBoxcar.Size = new System.Drawing.Size(266, 21);
            this.comboBoxcar.TabIndex = 16;
            // 
            // caradd
            // 
            this.caradd.BackColor = System.Drawing.Color.Gold;
            this.caradd.FlatAppearance.BorderSize = 0;
            this.caradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caradd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caradd.Location = new System.Drawing.Point(378, 212);
            this.caradd.Name = "caradd";
            this.caradd.Size = new System.Drawing.Size(86, 30);
            this.caradd.TabIndex = 17;
            this.caradd.Text = "Add";
            this.caradd.UseVisualStyleBackColor = false;
            this.caradd.Click += new System.EventHandler(this.caradd_Click);
            // 
            // carremove
            // 
            this.carremove.BackColor = System.Drawing.Color.Red;
            this.carremove.FlatAppearance.BorderSize = 0;
            this.carremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carremove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carremove.Location = new System.Drawing.Point(470, 212);
            this.carremove.Name = "carremove";
            this.carremove.Size = new System.Drawing.Size(82, 30);
            this.carremove.TabIndex = 18;
            this.carremove.Text = "Remove";
            this.carremove.UseVisualStyleBackColor = false;
            this.carremove.Click += new System.EventHandler(this.carremove_Click);
            // 
            // carclear
            // 
            this.carclear.BackColor = System.Drawing.Color.Gold;
            this.carclear.FlatAppearance.BorderSize = 0;
            this.carclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carclear.Location = new System.Drawing.Point(558, 212);
            this.carclear.Name = "carclear";
            this.carclear.Size = new System.Drawing.Size(86, 30);
            this.carclear.TabIndex = 19;
            this.carclear.Text = "Clear";
            this.carclear.UseVisualStyleBackColor = false;
            this.carclear.Click += new System.EventHandler(this.carclear_Click);
            // 
            // clearvan
            // 
            this.clearvan.BackColor = System.Drawing.Color.Gold;
            this.clearvan.FlatAppearance.BorderSize = 0;
            this.clearvan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearvan.Location = new System.Drawing.Point(558, 212);
            this.clearvan.Name = "clearvan";
            this.clearvan.Size = new System.Drawing.Size(86, 30);
            this.clearvan.TabIndex = 32;
            this.clearvan.Text = "Clear";
            this.clearvan.UseVisualStyleBackColor = false;
            this.clearvan.Click += new System.EventHandler(this.clearvan_Click);
            // 
            // removevan
            // 
            this.removevan.BackColor = System.Drawing.Color.Red;
            this.removevan.FlatAppearance.BorderSize = 0;
            this.removevan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removevan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removevan.Location = new System.Drawing.Point(470, 212);
            this.removevan.Name = "removevan";
            this.removevan.Size = new System.Drawing.Size(82, 30);
            this.removevan.TabIndex = 31;
            this.removevan.Text = "Remove";
            this.removevan.UseVisualStyleBackColor = false;
            this.removevan.Click += new System.EventHandler(this.removevan_Click);
            // 
            // addvan
            // 
            this.addvan.BackColor = System.Drawing.Color.Gold;
            this.addvan.FlatAppearance.BorderSize = 0;
            this.addvan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addvan.Location = new System.Drawing.Point(378, 212);
            this.addvan.Name = "addvan";
            this.addvan.Size = new System.Drawing.Size(86, 30);
            this.addvan.TabIndex = 30;
            this.addvan.Text = "Add";
            this.addvan.UseVisualStyleBackColor = false;
            this.addvan.Click += new System.EventHandler(this.addvan_Click);
            // 
            // textBox2van
            // 
            this.textBox2van.BackColor = System.Drawing.Color.Black;
            this.textBox2van.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2van.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2van.ForeColor = System.Drawing.Color.White;
            this.textBox2van.Location = new System.Drawing.Point(378, 73);
            this.textBox2van.Name = "textBox2van";
            this.textBox2van.Size = new System.Drawing.Size(266, 19);
            this.textBox2van.TabIndex = 27;
            // 
            // textBox3van
            // 
            this.textBox3van.BackColor = System.Drawing.Color.Black;
            this.textBox3van.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3van.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3van.ForeColor = System.Drawing.Color.White;
            this.textBox3van.Location = new System.Drawing.Point(378, 107);
            this.textBox3van.Name = "textBox3van";
            this.textBox3van.Size = new System.Drawing.Size(266, 19);
            this.textBox3van.TabIndex = 26;
            // 
            // textBox4van
            // 
            this.textBox4van.BackColor = System.Drawing.Color.Black;
            this.textBox4van.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4van.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4van.ForeColor = System.Drawing.Color.White;
            this.textBox4van.Location = new System.Drawing.Point(378, 142);
            this.textBox4van.Name = "textBox4van";
            this.textBox4van.Size = new System.Drawing.Size(266, 19);
            this.textBox4van.TabIndex = 25;
            // 
            // textBox1van
            // 
            this.textBox1van.BackColor = System.Drawing.Color.Black;
            this.textBox1van.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1van.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1van.ForeColor = System.Drawing.Color.White;
            this.textBox1van.Location = new System.Drawing.Point(378, 40);
            this.textBox1van.Name = "textBox1van";
            this.textBox1van.Size = new System.Drawing.Size(266, 19);
            this.textBox1van.TabIndex = 24;
            // 
            // vanplateno
            // 
            this.vanplateno.AutoSize = true;
            this.vanplateno.BackColor = System.Drawing.Color.Black;
            this.vanplateno.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanplateno.ForeColor = System.Drawing.Color.White;
            this.vanplateno.Location = new System.Drawing.Point(263, 146);
            this.vanplateno.Name = "vanplateno";
            this.vanplateno.Size = new System.Drawing.Size(85, 22);
            this.vanplateno.TabIndex = 23;
            this.vanplateno.Text = "Plate NO";
            // 
            // vanmake
            // 
            this.vanmake.AutoSize = true;
            this.vanmake.BackColor = System.Drawing.Color.Black;
            this.vanmake.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanmake.ForeColor = System.Drawing.Color.White;
            this.vanmake.Location = new System.Drawing.Point(257, 111);
            this.vanmake.Name = "vanmake";
            this.vanmake.Size = new System.Drawing.Size(93, 22);
            this.vanmake.TabIndex = 22;
            this.vanmake.Text = "Van Make";
            // 
            // vanmodel
            // 
            this.vanmodel.AutoSize = true;
            this.vanmodel.BackColor = System.Drawing.Color.Black;
            this.vanmodel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanmodel.ForeColor = System.Drawing.Color.White;
            this.vanmodel.Location = new System.Drawing.Point(248, 77);
            this.vanmodel.Name = "vanmodel";
            this.vanmodel.Size = new System.Drawing.Size(100, 22);
            this.vanmodel.TabIndex = 21;
            this.vanmodel.Text = "Van Model";
            // 
            // vanid
            // 
            this.vanid.AutoSize = true;
            this.vanid.BackColor = System.Drawing.Color.Black;
            this.vanid.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanid.ForeColor = System.Drawing.Color.White;
            this.vanid.Location = new System.Drawing.Point(272, 44);
            this.vanid.Name = "vanid";
            this.vanid.Size = new System.Drawing.Size(69, 22);
            this.vanid.TabIndex = 20;
            this.vanid.Text = "VAN ID";
            // 
            // clearsuv
            // 
            this.clearsuv.BackColor = System.Drawing.Color.Gold;
            this.clearsuv.FlatAppearance.BorderSize = 0;
            this.clearsuv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearsuv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearsuv.Location = new System.Drawing.Point(558, 212);
            this.clearsuv.Name = "clearsuv";
            this.clearsuv.Size = new System.Drawing.Size(86, 30);
            this.clearsuv.TabIndex = 43;
            this.clearsuv.Text = "Clear";
            this.clearsuv.UseVisualStyleBackColor = false;
            this.clearsuv.Click += new System.EventHandler(this.clearsuv_Click);
            // 
            // removesuv
            // 
            this.removesuv.BackColor = System.Drawing.Color.Red;
            this.removesuv.FlatAppearance.BorderSize = 0;
            this.removesuv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removesuv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removesuv.Location = new System.Drawing.Point(470, 212);
            this.removesuv.Name = "removesuv";
            this.removesuv.Size = new System.Drawing.Size(82, 30);
            this.removesuv.TabIndex = 42;
            this.removesuv.Text = "Remove";
            this.removesuv.UseVisualStyleBackColor = false;
            this.removesuv.Click += new System.EventHandler(this.removesuv_Click);
            // 
            // addsuv
            // 
            this.addsuv.BackColor = System.Drawing.Color.Gold;
            this.addsuv.FlatAppearance.BorderSize = 0;
            this.addsuv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addsuv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsuv.Location = new System.Drawing.Point(378, 212);
            this.addsuv.Name = "addsuv";
            this.addsuv.Size = new System.Drawing.Size(86, 30);
            this.addsuv.TabIndex = 41;
            this.addsuv.Text = "Add";
            this.addsuv.UseVisualStyleBackColor = false;
            this.addsuv.Click += new System.EventHandler(this.addsuv_Click);
            // 
            // textBox2suv
            // 
            this.textBox2suv.BackColor = System.Drawing.Color.Black;
            this.textBox2suv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2suv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2suv.ForeColor = System.Drawing.Color.White;
            this.textBox2suv.Location = new System.Drawing.Point(378, 73);
            this.textBox2suv.Name = "textBox2suv";
            this.textBox2suv.Size = new System.Drawing.Size(266, 19);
            this.textBox2suv.TabIndex = 40;
            // 
            // textBox3suv
            // 
            this.textBox3suv.BackColor = System.Drawing.Color.Black;
            this.textBox3suv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3suv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3suv.ForeColor = System.Drawing.Color.White;
            this.textBox3suv.Location = new System.Drawing.Point(378, 107);
            this.textBox3suv.Name = "textBox3suv";
            this.textBox3suv.Size = new System.Drawing.Size(266, 19);
            this.textBox3suv.TabIndex = 39;
            // 
            // textBox4suv
            // 
            this.textBox4suv.BackColor = System.Drawing.Color.Black;
            this.textBox4suv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4suv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4suv.ForeColor = System.Drawing.Color.White;
            this.textBox4suv.Location = new System.Drawing.Point(378, 142);
            this.textBox4suv.Name = "textBox4suv";
            this.textBox4suv.Size = new System.Drawing.Size(266, 19);
            this.textBox4suv.TabIndex = 38;
            // 
            // textBox1suv
            // 
            this.textBox1suv.BackColor = System.Drawing.Color.Black;
            this.textBox1suv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1suv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1suv.ForeColor = System.Drawing.Color.White;
            this.textBox1suv.Location = new System.Drawing.Point(378, 40);
            this.textBox1suv.Name = "textBox1suv";
            this.textBox1suv.Size = new System.Drawing.Size(266, 19);
            this.textBox1suv.TabIndex = 37;
            // 
            // suvplateno
            // 
            this.suvplateno.AutoSize = true;
            this.suvplateno.BackColor = System.Drawing.Color.Black;
            this.suvplateno.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvplateno.ForeColor = System.Drawing.Color.White;
            this.suvplateno.Location = new System.Drawing.Point(263, 146);
            this.suvplateno.Name = "suvplateno";
            this.suvplateno.Size = new System.Drawing.Size(85, 22);
            this.suvplateno.TabIndex = 36;
            this.suvplateno.Text = "Plate NO";
            // 
            // suvmake
            // 
            this.suvmake.AutoSize = true;
            this.suvmake.BackColor = System.Drawing.Color.Black;
            this.suvmake.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvmake.ForeColor = System.Drawing.Color.White;
            this.suvmake.Location = new System.Drawing.Point(257, 111);
            this.suvmake.Name = "suvmake";
            this.suvmake.Size = new System.Drawing.Size(91, 22);
            this.suvmake.TabIndex = 35;
            this.suvmake.Text = "Suv Make";
            // 
            // suvmodel
            // 
            this.suvmodel.AutoSize = true;
            this.suvmodel.BackColor = System.Drawing.Color.Black;
            this.suvmodel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvmodel.ForeColor = System.Drawing.Color.White;
            this.suvmodel.Location = new System.Drawing.Point(250, 77);
            this.suvmodel.Name = "suvmodel";
            this.suvmodel.Size = new System.Drawing.Size(98, 22);
            this.suvmodel.TabIndex = 34;
            this.suvmodel.Text = "Suv Model";
            // 
            // suvid
            // 
            this.suvid.AutoSize = true;
            this.suvid.BackColor = System.Drawing.Color.Black;
            this.suvid.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvid.ForeColor = System.Drawing.Color.White;
            this.suvid.Location = new System.Drawing.Point(272, 44);
            this.suvid.Name = "suvid";
            this.suvid.Size = new System.Drawing.Size(69, 22);
            this.suvid.TabIndex = 33;
            this.suvid.Text = "SUV ID";
            this.suvid.Click += new System.EventHandler(this.suvid_Click);
            // 
            // caridgen
            // 
            this.caridgen.BackColor = System.Drawing.Color.Khaki;
            this.caridgen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.caridgen.FlatAppearance.BorderSize = 0;
            this.caridgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caridgen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caridgen.Location = new System.Drawing.Point(650, 40);
            this.caridgen.Name = "caridgen";
            this.caridgen.Size = new System.Drawing.Size(75, 26);
            this.caridgen.TabIndex = 46;
            this.caridgen.Text = "genarate";
            this.caridgen.UseVisualStyleBackColor = false;
            this.caridgen.Click += new System.EventHandler(this.button4_Click);
            // 
            // vanidgen
            // 
            this.vanidgen.BackColor = System.Drawing.Color.Khaki;
            this.vanidgen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.vanidgen.FlatAppearance.BorderSize = 0;
            this.vanidgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vanidgen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanidgen.Location = new System.Drawing.Point(650, 41);
            this.vanidgen.Name = "vanidgen";
            this.vanidgen.Size = new System.Drawing.Size(75, 26);
            this.vanidgen.TabIndex = 47;
            this.vanidgen.Text = "genarate";
            this.vanidgen.UseVisualStyleBackColor = false;
            this.vanidgen.Click += new System.EventHandler(this.vanidgen_Click);
            // 
            // suvidgen
            // 
            this.suvidgen.BackColor = System.Drawing.Color.Khaki;
            this.suvidgen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.suvidgen.FlatAppearance.BorderSize = 0;
            this.suvidgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suvidgen.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvidgen.Location = new System.Drawing.Point(650, 40);
            this.suvidgen.Name = "suvidgen";
            this.suvidgen.Size = new System.Drawing.Size(75, 26);
            this.suvidgen.TabIndex = 48;
            this.suvidgen.Text = "genarate";
            this.suvidgen.UseVisualStyleBackColor = false;
            this.suvidgen.Click += new System.EventHandler(this.suvidgen_Click);
            // 
            // dataGridViewcar
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LemonChiffon;
            this.dataGridViewcar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewcar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcar.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewcar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewcar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewcar.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewcar.Location = new System.Drawing.Point(244, 293);
            this.dataGridViewcar.Name = "dataGridViewcar";
            this.dataGridViewcar.Size = new System.Drawing.Size(544, 212);
            this.dataGridViewcar.TabIndex = 49;
            this.dataGridViewcar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewvan
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LemonChiffon;
            this.dataGridViewvan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewvan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewvan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewvan.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewvan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewvan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewvan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewvan.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewvan.Location = new System.Drawing.Point(244, 293);
            this.dataGridViewvan.Name = "dataGridViewvan";
            this.dataGridViewvan.Size = new System.Drawing.Size(544, 212);
            this.dataGridViewvan.TabIndex = 50;
            // 
            // dataGridViewsuv
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LemonChiffon;
            this.dataGridViewsuv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewsuv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewsuv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsuv.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewsuv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewsuv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewsuv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewsuv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewsuv.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewsuv.Location = new System.Drawing.Point(244, 293);
            this.dataGridViewsuv.Name = "dataGridViewsuv";
            this.dataGridViewsuv.Size = new System.Drawing.Size(544, 212);
            this.dataGridViewsuv.TabIndex = 51;
            this.dataGridViewsuv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsuv_CellContentClick);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.Gold;
            this.navbar.Controls.Add(this.pictureBox2);
            this.navbar.Controls.Add(this.button3);
            this.navbar.Controls.Add(this.button2);
            this.navbar.Controls.Add(this.button1);
            this.navbar.Location = new System.Drawing.Point(-2, -1);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(214, 522);
            this.navbar.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(756, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(731, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(781, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(378, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(378, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 2);
            this.panel2.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(378, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 2);
            this.panel3.TabIndex = 58;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(378, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 2);
            this.panel4.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Avalability";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(378, 258);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 60;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(443, 258);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 61;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "no";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(517, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "Use ID";
            // 
            // Addvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dataGridViewsuv);
            this.Controls.Add(this.dataGridViewvan);
            this.Controls.Add(this.dataGridViewcar);
            this.Controls.Add(this.suvidgen);
            this.Controls.Add(this.vanidgen);
            this.Controls.Add(this.caridgen);
            this.Controls.Add(this.clearsuv);
            this.Controls.Add(this.removesuv);
            this.Controls.Add(this.addsuv);
            this.Controls.Add(this.textBox2suv);
            this.Controls.Add(this.textBox3suv);
            this.Controls.Add(this.textBox4suv);
            this.Controls.Add(this.textBox1suv);
            this.Controls.Add(this.suvplateno);
            this.Controls.Add(this.suvmake);
            this.Controls.Add(this.suvmodel);
            this.Controls.Add(this.suvid);
            this.Controls.Add(this.clearvan);
            this.Controls.Add(this.removevan);
            this.Controls.Add(this.addvan);
            this.Controls.Add(this.textBox2van);
            this.Controls.Add(this.textBox3van);
            this.Controls.Add(this.textBox4van);
            this.Controls.Add(this.textBox1van);
            this.Controls.Add(this.vanplateno);
            this.Controls.Add(this.vanmake);
            this.Controls.Add(this.vanmodel);
            this.Controls.Add(this.vanid);
            this.Controls.Add(this.carclear);
            this.Controls.Add(this.carremove);
            this.Controls.Add(this.caradd);
            this.Controls.Add(this.comboBoxcar);
            this.Controls.Add(this.cartype);
            this.Controls.Add(this.textBox2car);
            this.Controls.Add(this.textBox3car);
            this.Controls.Add(this.textBox4car);
            this.Controls.Add(this.textBox1car);
            this.Controls.Add(this.carplateno);
            this.Controls.Add(this.carmake);
            this.Controls.Add(this.carmodel);
            this.Controls.Add(this.carid);
            this.Controls.Add(this.navbar);
            this.Name = "Addvehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicle";
            this.Load += new System.EventHandler(this.Addvehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsuv)).EndInit();
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label carid;
        private System.Windows.Forms.Label carmodel;
        private System.Windows.Forms.Label carmake;
        private System.Windows.Forms.Label carplateno;
        private System.Windows.Forms.TextBox textBox1car;
        private System.Windows.Forms.TextBox textBox4car;
        private System.Windows.Forms.TextBox textBox3car;
        private System.Windows.Forms.TextBox textBox2car;
        private System.Windows.Forms.Label cartype;
        private System.Windows.Forms.ComboBox comboBoxcar;
        private System.Windows.Forms.Button caradd;
        private System.Windows.Forms.Button carremove;
        private System.Windows.Forms.Button carclear;
        private System.Windows.Forms.Button clearvan;
        private System.Windows.Forms.Button removevan;
        private System.Windows.Forms.Button addvan;
        private System.Windows.Forms.TextBox textBox2van;
        private System.Windows.Forms.TextBox textBox3van;
        private System.Windows.Forms.TextBox textBox4van;
        private System.Windows.Forms.TextBox textBox1van;
        private System.Windows.Forms.Label vanplateno;
        private System.Windows.Forms.Label vanmake;
        private System.Windows.Forms.Label vanmodel;
        private System.Windows.Forms.Label vanid;
        private System.Windows.Forms.Button clearsuv;
        private System.Windows.Forms.Button removesuv;
        private System.Windows.Forms.Button addsuv;
        private System.Windows.Forms.TextBox textBox2suv;
        private System.Windows.Forms.TextBox textBox3suv;
        private System.Windows.Forms.TextBox textBox4suv;
        private System.Windows.Forms.TextBox textBox1suv;
        private System.Windows.Forms.Label suvplateno;
        private System.Windows.Forms.Label suvmake;
        private System.Windows.Forms.Label suvmodel;
        private System.Windows.Forms.Label suvid;
        private System.Windows.Forms.Button caridgen;
        private System.Windows.Forms.Button vanidgen;
        private System.Windows.Forms.Button suvidgen;
        private System.Windows.Forms.DataGridView dataGridViewcar;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewvan;
        private System.Windows.Forms.DataGridView dataGridViewsuv;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}