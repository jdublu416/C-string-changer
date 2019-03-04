namespace codingChallenge
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
            this.lblFindPrompt = new System.Windows.Forms.Label();
            this.lblReplacePrompt = new System.Windows.Forms.Label();
            this.btnChangeIt = new System.Windows.Forms.Button();
            this.tbxStrOrig = new System.Windows.Forms.TextBox();
            this.tbxStrFind = new System.Windows.Forms.TextBox();
            this.tbxStrReplace = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStrOrigPrompt = new System.Windows.Forms.Label();
            this.lblnewStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFindPrompt
            // 
            this.lblFindPrompt.AutoSize = true;
            this.lblFindPrompt.Location = new System.Drawing.Point(40, 263);
            this.lblFindPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFindPrompt.Name = "lblFindPrompt";
            this.lblFindPrompt.Size = new System.Drawing.Size(335, 20);
            this.lblFindPrompt.TabIndex = 0;
            this.lblFindPrompt.Text = "Please enter what you would like to change:";
            // 
            // lblReplacePrompt
            // 
            this.lblReplacePrompt.AutoSize = true;
            this.lblReplacePrompt.Location = new System.Drawing.Point(40, 345);
            this.lblReplacePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplacePrompt.Name = "lblReplacePrompt";
            this.lblReplacePrompt.Size = new System.Drawing.Size(345, 20);
            this.lblReplacePrompt.TabIndex = 1;
            this.lblReplacePrompt.Text = "Please enter the replacement word or phrase";
            // 
            // btnChangeIt
            // 
            this.btnChangeIt.BackColor = System.Drawing.Color.LightCyan;
            this.btnChangeIt.Location = new System.Drawing.Point(303, 436);
            this.btnChangeIt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeIt.Name = "btnChangeIt";
            this.btnChangeIt.Size = new System.Drawing.Size(144, 46);
            this.btnChangeIt.TabIndex = 3;
            this.btnChangeIt.Text = "Change it!";
            this.btnChangeIt.UseVisualStyleBackColor = false;
            this.btnChangeIt.Click += new System.EventHandler(this.btnChangeIt_Click);
            // 
            // tbxStrOrig
            // 
            this.tbxStrOrig.Location = new System.Drawing.Point(444, 184);
            this.tbxStrOrig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStrOrig.Name = "tbxStrOrig";
            this.tbxStrOrig.Size = new System.Drawing.Size(244, 27);
            this.tbxStrOrig.TabIndex = 4;
            // 
            // tbxStrFind
            // 
            this.tbxStrFind.Location = new System.Drawing.Point(444, 256);
            this.tbxStrFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStrFind.Name = "tbxStrFind";
            this.tbxStrFind.Size = new System.Drawing.Size(244, 27);
            this.tbxStrFind.TabIndex = 5;
            // 
            // tbxStrReplace
            // 
            this.tbxStrReplace.Location = new System.Drawing.Point(444, 338);
            this.tbxStrReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxStrReplace.Name = "tbxStrReplace";
            this.tbxStrReplace.Size = new System.Drawing.Size(244, 27);
            this.tbxStrReplace.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 102);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.lblTitle.Size = new System.Drawing.Size(233, 41);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Coding Challenge";
            // 
            // lblStrOrigPrompt
            // 
            this.lblStrOrigPrompt.AutoSize = true;
            this.lblStrOrigPrompt.Location = new System.Drawing.Point(40, 184);
            this.lblStrOrigPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrOrigPrompt.Name = "lblStrOrigPrompt";
            this.lblStrOrigPrompt.Size = new System.Drawing.Size(282, 20);
            this.lblStrOrigPrompt.TabIndex = 2;
            this.lblStrOrigPrompt.Text = "Please enter phrase or word to alter:";
            // 
            // lblnewStr
            // 
            this.lblnewStr.AutoSize = true;
            this.lblnewStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewStr.Location = new System.Drawing.Point(240, 536);
            this.lblnewStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewStr.Name = "lblnewStr";
            this.lblnewStr.Size = new System.Drawing.Size(0, 29);
            this.lblnewStr.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(780, 631);
            this.Controls.Add(this.lblnewStr);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxStrReplace);
            this.Controls.Add(this.tbxStrFind);
            this.Controls.Add(this.tbxStrOrig);
            this.Controls.Add(this.btnChangeIt);
            this.Controls.Add(this.lblStrOrigPrompt);
            this.Controls.Add(this.lblReplacePrompt);
            this.Controls.Add(this.lblFindPrompt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(744, 677);
            this.Name = "Form1";
            this.Text = "ChangeIt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindPrompt;
        private System.Windows.Forms.Label lblReplacePrompt;
        private System.Windows.Forms.Button btnChangeIt;
        private System.Windows.Forms.TextBox tbxStrOrig;
        private System.Windows.Forms.TextBox tbxStrFind;
        private System.Windows.Forms.TextBox tbxStrReplace;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStrOrigPrompt;
        private System.Windows.Forms.Label lblnewStr;
    }
}

