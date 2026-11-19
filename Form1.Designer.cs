namespace BadalJoshua_Activity_HomeSales
{
    partial class Form1
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
            homeSales = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Txt_SalesInitial = new TextBox();
            Txt_SalesAmount = new TextBox();
            Lbl_Display = new TextBox();
            Btn_Submit = new Button();
            Btn_Clear = new Button();
            Btn_Print = new Button();
            homeSales.SuspendLayout();
            SuspendLayout();
            // 
            // homeSales
            // 
            homeSales.BackColor = Color.MistyRose;
            homeSales.Controls.Add(label4);
            homeSales.Controls.Add(label3);
            homeSales.Controls.Add(label2);
            homeSales.Controls.Add(label1);
            homeSales.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeSales.ForeColor = Color.Black;
            homeSales.Location = new Point(12, 12);
            homeSales.Name = "homeSales";
            homeSales.Size = new Size(388, 111);
            homeSales.TabIndex = 0;
            homeSales.TabStop = false;
            homeSales.Text = "HOME SALES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 87);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 3;
            label4.Text = "F - Fatima ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 71);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 2;
            label3.Text = "E - Edward ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 1;
            label2.Text = "D - Danielle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(155, 16);
            label1.TabIndex = 0;
            label1.Text = "SALESPERSON CODES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(205, 19);
            label5.TabIndex = 1;
            label5.Text = "Enter Sales Person Initial:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 211);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 2;
            label6.Text = "Amount of Sale:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 337);
            label7.Name = "label7";
            label7.Size = new Size(166, 19);
            label7.TabIndex = 3;
            label7.Text = "Transaction Display:";
            // 
            // Txt_SalesInitial
            // 
            Txt_SalesInitial.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_SalesInitial.ForeColor = Color.Black;
            Txt_SalesInitial.Location = new Point(27, 180);
            Txt_SalesInitial.Name = "Txt_SalesInitial";
            Txt_SalesInitial.Size = new Size(190, 25);
            Txt_SalesInitial.TabIndex = 4;
            // 
            // Txt_SalesAmount
            // 
            Txt_SalesAmount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt_SalesAmount.ForeColor = Color.Black;
            Txt_SalesAmount.Location = new Point(27, 233);
            Txt_SalesAmount.Name = "Txt_SalesAmount";
            Txt_SalesAmount.Size = new Size(190, 25);
            Txt_SalesAmount.TabIndex = 5;
            // 
            // Lbl_Display
            // 
            Lbl_Display.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Display.ForeColor = Color.Black;
            Lbl_Display.Location = new Point(27, 359);
            Lbl_Display.Multiline = true;
            Lbl_Display.Name = "Lbl_Display";
            Lbl_Display.Size = new Size(341, 70);
            Lbl_Display.TabIndex = 6;
            // 
            // Btn_Submit
            // 
            Btn_Submit.BackColor = Color.SteelBlue;
            Btn_Submit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Submit.ForeColor = SystemColors.ButtonHighlight;
            Btn_Submit.Location = new Point(27, 272);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(98, 49);
            Btn_Submit.TabIndex = 7;
            Btn_Submit.Text = "SUBMIT";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Click += Btn_Submit_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = SystemColors.ButtonShadow;
            Btn_Clear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Btn_Clear.ForeColor = Color.Transparent;
            Btn_Clear.Location = new Point(152, 273);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(98, 48);
            Btn_Clear.TabIndex = 11;
            Btn_Clear.Text = "CLEAR";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Btn_Print
            // 
            Btn_Print.BackColor = Color.MediumSeaGreen;
            Btn_Print.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Print.ForeColor = Color.Transparent;
            Btn_Print.Location = new Point(270, 272);
            Btn_Print.Name = "Btn_Print";
            Btn_Print.Size = new Size(98, 49);
            Btn_Print.TabIndex = 10;
            Btn_Print.Text = "PRINT";
            Btn_Print.UseVisualStyleBackColor = false;
            Btn_Print.Click += Btn_Print_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 441);
            Controls.Add(Btn_Print);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Submit);
            Controls.Add(Lbl_Display);
            Controls.Add(Txt_SalesAmount);
            Controls.Add(Txt_SalesInitial);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(homeSales);
            Name = "Form1";
            Text = "Form1";
            homeSales.ResumeLayout(false);
            homeSales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox homeSales;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Txt_SalesInitial;
        private TextBox Txt_SalesAmount;
        private TextBox Lbl_Display;
        private Button Btn_Submit;
        private Button Btn_Clear;
        private Button Btn_Print;
    }
}