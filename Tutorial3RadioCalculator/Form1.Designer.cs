namespace Tutorial3RadioCalculator
{
    partial class frmMain
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
            btnCalculate = new Button();
            rdoAdd = new RadioButton();
            rdoSub = new RadioButton();
            rdoMul = new RadioButton();
            rdoDiv = new RadioButton();
            txtFirstOperand = new TextBox();
            txtSecondOperand = new TextBox();
            txtAns = new TextBox();
            lblFirstOperand = new Label();
            lblSecondOperand = new Label();
            lblAnswer = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(124, 136);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(167, 30);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Font = new Font("Segoe UI", 12F);
            rdoAdd.Location = new Point(272, 14);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(87, 25);
            rdoAdd.TabIndex = 1;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Addition";
            rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            rdoSub.AutoSize = true;
            rdoSub.Font = new Font("Segoe UI", 12F);
            rdoSub.Location = new Point(272, 39);
            rdoSub.Name = "rdoSub";
            rdoSub.Size = new Size(108, 25);
            rdoSub.TabIndex = 2;
            rdoSub.TabStop = true;
            rdoSub.Text = "Subtraction";
            rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMul
            // 
            rdoMul.AutoSize = true;
            rdoMul.Font = new Font("Segoe UI", 12F);
            rdoMul.Location = new Point(272, 64);
            rdoMul.Name = "rdoMul";
            rdoMul.Size = new Size(123, 25);
            rdoMul.TabIndex = 3;
            rdoMul.TabStop = true;
            rdoMul.Text = "Multiplication";
            rdoMul.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            rdoDiv.AutoSize = true;
            rdoDiv.Font = new Font("Segoe UI", 12F);
            rdoDiv.Location = new Point(272, 89);
            rdoDiv.Name = "rdoDiv";
            rdoDiv.Size = new Size(84, 25);
            rdoDiv.TabIndex = 4;
            rdoDiv.TabStop = true;
            rdoDiv.Text = "Division";
            rdoDiv.UseVisualStyleBackColor = true;
            // 
            // txtFirstOperand
            // 
            txtFirstOperand.Font = new Font("Segoe UI", 12F);
            txtFirstOperand.Location = new Point(148, 10);
            txtFirstOperand.Name = "txtFirstOperand";
            txtFirstOperand.Size = new Size(107, 29);
            txtFirstOperand.TabIndex = 5;
            // 
            // txtSecondOperand
            // 
            txtSecondOperand.Font = new Font("Segoe UI", 12F);
            txtSecondOperand.Location = new Point(148, 49);
            txtSecondOperand.Name = "txtSecondOperand";
            txtSecondOperand.Size = new Size(107, 29);
            txtSecondOperand.TabIndex = 6;
            // 
            // txtAns
            // 
            txtAns.Font = new Font("Segoe UI", 12F);
            txtAns.Location = new Point(148, 88);
            txtAns.Name = "txtAns";
            txtAns.Size = new Size(107, 29);
            txtAns.TabIndex = 7;
            // 
            // lblFirstOperand
            // 
            lblFirstOperand.Font = new Font("Segoe UI", 12F);
            lblFirstOperand.Location = new Point(12, 8);
            lblFirstOperand.Name = "lblFirstOperand";
            lblFirstOperand.Size = new Size(130, 30);
            lblFirstOperand.TabIndex = 8;
            lblFirstOperand.Text = "First Operand";
            lblFirstOperand.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSecondOperand
            // 
            lblSecondOperand.Font = new Font("Segoe UI", 12F);
            lblSecondOperand.Location = new Point(12, 47);
            lblSecondOperand.Name = "lblSecondOperand";
            lblSecondOperand.Size = new Size(130, 30);
            lblSecondOperand.TabIndex = 9;
            lblSecondOperand.Text = "Second Operand";
            lblSecondOperand.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAnswer
            // 
            lblAnswer.Font = new Font("Segoe UI", 12F);
            lblAnswer.Location = new Point(12, 89);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(130, 30);
            lblAnswer.TabIndex = 10;
            lblAnswer.Text = "Answer";
            lblAnswer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 187);
            Controls.Add(lblAnswer);
            Controls.Add(lblSecondOperand);
            Controls.Add(lblFirstOperand);
            Controls.Add(txtAns);
            Controls.Add(txtSecondOperand);
            Controls.Add(txtFirstOperand);
            Controls.Add(rdoDiv);
            Controls.Add(rdoMul);
            Controls.Add(rdoSub);
            Controls.Add(rdoAdd);
            Controls.Add(btnCalculate);
            Name = "frmMain";
            Text = "Radio Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private RadioButton rdoAdd;
        private RadioButton rdoSub;
        private RadioButton rdoMul;
        private RadioButton rdoDiv;
        private TextBox txtFirstOperand;
        private TextBox txtSecondOperand;
        private TextBox txtAns;
        private Label lblFirstOperand;
        private Label lblSecondOperand;
        private Label lblAnswer;
    }
}
