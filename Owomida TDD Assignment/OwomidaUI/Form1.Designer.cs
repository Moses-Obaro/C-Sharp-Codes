namespace OwomidaForms
{
    partial class Owomida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owomida));
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.vehicleType = new System.Windows.Forms.ComboBox();
            this.isNURTW_member = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tollPaid = new System.Windows.Forms.TextBox();
            this.calcToll = new System.Windows.Forms.Button();
            this.vehicleToll = new System.Windows.Forms.TextBox();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.numTrip = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(71, 144);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(59, 25);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "label1";
            // 
            // vehicleType
            // 
            this.vehicleType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vehicleType.FormattingEnabled = true;
            this.vehicleType.Location = new System.Drawing.Point(115, 3);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(194, 33);
            this.vehicleType.TabIndex = 0;
            this.vehicleType.Text = "Select vehicle type";
            this.vehicleType.SelectedIndexChanged += new System.EventHandler(this.vehicleType_SelectedIndexChanged);
            // 
            // isNURTW_member
            // 
            this.isNURTW_member.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isNURTW_member.FormattingEnabled = true;
            this.isNURTW_member.Location = new System.Drawing.Point(115, 72);
            this.isNURTW_member.Name = "isNURTW_member";
            this.isNURTW_member.Size = new System.Drawing.Size(194, 33);
            this.isNURTW_member.TabIndex = 1;
            this.isNURTW_member.Text = "NURTW member";
            this.isNURTW_member.SelectedIndexChanged += new System.EventHandler(this.isNURTW_member_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "NURTW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(397, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toll Expected:";
            // 
            // tollPaid
            // 
            this.tollPaid.Location = new System.Drawing.Point(534, 310);
            this.tollPaid.Name = "tollPaid";
            this.tollPaid.Size = new System.Drawing.Size(138, 31);
            this.tollPaid.TabIndex = 6;
            // 
            // calcToll
            // 
            this.calcToll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcToll.Location = new System.Drawing.Point(27, 294);
            this.calcToll.Name = "calcToll";
            this.calcToll.Size = new System.Drawing.Size(194, 44);
            this.calcToll.TabIndex = 7;
            this.calcToll.Text = "Calculate Toll";
            this.calcToll.UseVisualStyleBackColor = true;
            this.calcToll.Click += new System.EventHandler(this.calcToll_Click);
            // 
            // vehicleToll
            // 
            this.vehicleToll.Location = new System.Drawing.Point(356, 2);
            this.vehicleToll.Name = "vehicleToll";
            this.vehicleToll.Size = new System.Drawing.Size(150, 31);
            this.vehicleToll.TabIndex = 8;
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(356, 71);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(150, 31);
            this.discountBox.TabIndex = 9;
            // 
            // numTrip
            // 
            this.numTrip.Location = new System.Drawing.Point(716, 2);
            this.numTrip.Name = "numTrip";
            this.numTrip.Size = new System.Drawing.Size(58, 31);
            this.numTrip.TabIndex = 10;
            this.numTrip.TextChanged += new System.EventHandler(this.numTrip_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(556, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Number of trips:";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 344);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numTrip);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.vehicleToll);
            this.Controls.Add(this.calcToll);
            this.Controls.Add(this.tollPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isNURTW_member);
            this.Controls.Add(this.vehicleType);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "OWOMIDA TDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblHelloWorld;
        private ComboBox vehicleType;
        private ComboBox isNURTW_member;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tollPaid;
        private Button calcToll;
        private TextBox vehicleToll;
        private TextBox discountBox;
        private TextBox numTrip;
        private TextBox textBox2;
    }
}