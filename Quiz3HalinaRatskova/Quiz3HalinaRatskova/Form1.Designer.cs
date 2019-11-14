namespace Quiz3HalinaRatskova
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
            this.car = new System.Windows.Forms.RadioButton();
            this.owner = new System.Windows.Forms.RadioButton();
            this.grBoxCar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.grBoxOwner = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.ph = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grBoxCar.SuspendLayout();
            this.grBoxOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Location = new System.Drawing.Point(70, 47);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(41, 17);
            this.car.TabIndex = 0;
            this.car.TabStop = true;
            this.car.Text = "Car";
            this.car.UseVisualStyleBackColor = true;
            this.car.CheckedChanged += new System.EventHandler(this.car_CheckedChanged);
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Location = new System.Drawing.Point(462, 47);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(56, 17);
            this.owner.TabIndex = 1;
            this.owner.TabStop = true;
            this.owner.Text = "Owner";
            this.owner.UseVisualStyleBackColor = true;
            this.owner.CheckedChanged += new System.EventHandler(this.owner_CheckedChanged);
            // 
            // grBoxCar
            // 
            this.grBoxCar.Controls.Add(this.label3);
            this.grBoxCar.Controls.Add(this.label2);
            this.grBoxCar.Controls.Add(this.label1);
            this.grBoxCar.Controls.Add(this.cbYear);
            this.grBoxCar.Controls.Add(this.cbModel);
            this.grBoxCar.Controls.Add(this.cbMark);
            this.grBoxCar.Location = new System.Drawing.Point(70, 112);
            this.grBoxCar.Name = "grBoxCar";
            this.grBoxCar.Size = new System.Drawing.Size(219, 184);
            this.grBoxCar.TabIndex = 2;
            this.grBoxCar.TabStop = false;
            this.grBoxCar.Text = "Car Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mark";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(67, 117);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 2;
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(67, 73);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 1;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbMark
            // 
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Location = new System.Drawing.Point(67, 21);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(121, 21);
            this.cbMark.TabIndex = 0;
            this.cbMark.SelectedIndexChanged += new System.EventHandler(this.cbMark_SelectedIndexChanged);
            // 
            // grBoxOwner
            // 
            this.grBoxOwner.Controls.Add(this.ph);
            this.grBoxOwner.Controls.Add(this.lname);
            this.grBoxOwner.Controls.Add(this.fname);
            this.grBoxOwner.Controls.Add(this.label6);
            this.grBoxOwner.Controls.Add(this.label5);
            this.grBoxOwner.Controls.Add(this.label4);
            this.grBoxOwner.Location = new System.Drawing.Point(462, 112);
            this.grBoxOwner.Name = "grBoxOwner";
            this.grBoxOwner.Size = new System.Drawing.Size(211, 184);
            this.grBoxOwner.TabIndex = 3;
            this.grBoxOwner.TabStop = false;
            this.grBoxOwner.Text = "Owner Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(186, 368);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(609, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(97, 21);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 6;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(97, 65);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 7;
            // 
            // ph
            // 
            this.ph.Location = new System.Drawing.Point(97, 118);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(100, 20);
            this.ph.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grBoxOwner);
            this.Controls.Add(this.grBoxCar);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.car);
            this.Name = "Form1";
            this.Text = "Carwash System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxCar.ResumeLayout(false);
            this.grBoxCar.PerformLayout();
            this.grBoxOwner.ResumeLayout(false);
            this.grBoxOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton car;
        private System.Windows.Forms.RadioButton owner;
        private System.Windows.Forms.GroupBox grBoxCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.GroupBox grBoxOwner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox ph;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

