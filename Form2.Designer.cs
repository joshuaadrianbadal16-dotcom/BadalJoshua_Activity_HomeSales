namespace BadalJoshua_Activity_HomeSales
{
    partial class Form2
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
            Lbl_Summary = new Label();
            Btn_Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 0;
            label1.Text = "SALES SUMMARY REPORT";
            // 
            // Lbl_Summary
            // 
            Lbl_Summary.AutoSize = true;
            Lbl_Summary.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Summary.ForeColor = Color.Black;
            Lbl_Summary.Location = new Point(24, 73);
            Lbl_Summary.Name = "Lbl_Summary";
            Lbl_Summary.Size = new Size(78, 21);
            Lbl_Summary.TabIndex = 1;
            Lbl_Summary.Text = "Summary";
            // 
            // Btn_Close
            // 
            Btn_Close.BackColor = Color.LightSlateGray;
            Btn_Close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Close.Location = new Point(205, 261);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(103, 39);
            Btn_Close.TabIndex = 2;
            Btn_Close.Text = "Close";
            Btn_Close.UseVisualStyleBackColor = false;
            Btn_Close.Click += Btn_Close_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 315);
            Controls.Add(Btn_Close);
            Controls.Add(Lbl_Summary);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Lbl_Summary;
        private Button Btn_Close;
    }
}