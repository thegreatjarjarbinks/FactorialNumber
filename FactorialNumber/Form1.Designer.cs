namespace FactorialNumber
{
    partial class frmFactorialNumber
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtFactorialNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstListBox = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(13, 28);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(256, 16);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Enter the # you want to take the factorial of:";
            // 
            // txtFactorialNumber
            // 
            this.txtFactorialNumber.Location = new System.Drawing.Point(289, 28);
            this.txtFactorialNumber.Name = "txtFactorialNumber";
            this.txtFactorialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFactorialNumber.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(13, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstListBox
            // 
            this.lstListBox.FormattingEnabled = true;
            this.lstListBox.Location = new System.Drawing.Point(269, 165);
            this.lstListBox.Name = "lstListBox";
            this.lstListBox.Size = new System.Drawing.Size(120, 95);
            this.lstListBox.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(16, 79);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(16, 13);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "...";
            // 
            // frmFactorialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstListBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFactorialNumber);
            this.Controls.Add(this.lblInput);
            this.Name = "frmFactorialNumber";
            this.Text = "Factorial Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtFactorialNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstListBox;
        private System.Windows.Forms.Label lblAnswer;
    }
}

