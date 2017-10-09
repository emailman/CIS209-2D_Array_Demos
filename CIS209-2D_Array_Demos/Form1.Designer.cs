namespace CIS209_2D_Array_Demos
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
            this.tbx1J = new System.Windows.Forms.TextBox();
            this.tbx2M = new System.Windows.Forms.TextBox();
            this.tbx2F = new System.Windows.Forms.TextBox();
            this.tbx2J = new System.Windows.Forms.TextBox();
            this.tbx1M = new System.Windows.Forms.TextBox();
            this.tbx1F = new System.Windows.Forms.TextBox();
            this.btnCalcTotals = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx1J
            // 
            this.tbx1J.Location = new System.Drawing.Point(77, 52);
            this.tbx1J.Name = "tbx1J";
            this.tbx1J.Size = new System.Drawing.Size(74, 20);
            this.tbx1J.TabIndex = 0;
            // 
            // tbx2M
            // 
            this.tbx2M.Location = new System.Drawing.Point(237, 78);
            this.tbx2M.Name = "tbx2M";
            this.tbx2M.Size = new System.Drawing.Size(74, 20);
            this.tbx2M.TabIndex = 1;
            // 
            // tbx2F
            // 
            this.tbx2F.Location = new System.Drawing.Point(157, 78);
            this.tbx2F.Name = "tbx2F";
            this.tbx2F.Size = new System.Drawing.Size(74, 20);
            this.tbx2F.TabIndex = 2;
            // 
            // tbx2J
            // 
            this.tbx2J.Location = new System.Drawing.Point(77, 78);
            this.tbx2J.Name = "tbx2J";
            this.tbx2J.Size = new System.Drawing.Size(74, 20);
            this.tbx2J.TabIndex = 3;
            // 
            // tbx1M
            // 
            this.tbx1M.Location = new System.Drawing.Point(237, 52);
            this.tbx1M.Name = "tbx1M";
            this.tbx1M.Size = new System.Drawing.Size(74, 20);
            this.tbx1M.TabIndex = 4;
            // 
            // tbx1F
            // 
            this.tbx1F.Location = new System.Drawing.Point(157, 52);
            this.tbx1F.Name = "tbx1F";
            this.tbx1F.Size = new System.Drawing.Size(74, 20);
            this.tbx1F.TabIndex = 5;
            // 
            // btnCalcTotals
            // 
            this.btnCalcTotals.Location = new System.Drawing.Point(77, 165);
            this.btnCalcTotals.Name = "btnCalcTotals";
            this.btnCalcTotals.Size = new System.Drawing.Size(75, 23);
            this.btnCalcTotals.TabIndex = 6;
            this.btnCalcTotals.Text = "Calc Totals";
            this.btnCalcTotals.UseVisualStyleBackColor = true;
            this.btnCalcTotals.Click += new System.EventHandler(this.btnCalcTotals_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(236, 165);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 273);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCalcTotals);
            this.Controls.Add(this.tbx1F);
            this.Controls.Add(this.tbx1M);
            this.Controls.Add(this.tbx2J);
            this.Controls.Add(this.tbx2F);
            this.Controls.Add(this.tbx2M);
            this.Controls.Add(this.tbx1J);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx1J;
        private System.Windows.Forms.TextBox tbx2M;
        private System.Windows.Forms.TextBox tbx2F;
        private System.Windows.Forms.TextBox tbx2J;
        private System.Windows.Forms.TextBox tbx1M;
        private System.Windows.Forms.TextBox tbx1F;
        private System.Windows.Forms.Button btnCalcTotals;
        private System.Windows.Forms.Button btnQuit;
    }
}

