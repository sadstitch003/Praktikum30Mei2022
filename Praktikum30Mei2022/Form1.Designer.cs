namespace Praktikum30Mei2022
{
    partial class FormTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            this.LblManager = new System.Windows.Forms.Label();
            this.LblStadium = new System.Windows.Forms.Label();
            this.LblTopScorer = new System.Windows.Forms.Label();
            this.LblWorstDiscipline = new System.Windows.Forms.Label();
            this.DgvMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name :";
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(19, 19);
            this.BtnFirst.Margin = new System.Windows.Forms.Padding(10);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(73, 51);
            this.BtnFirst.TabIndex = 1;
            this.BtnFirst.Text = "<<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(112, 19);
            this.BtnPrev.Margin = new System.Windows.Forms.Padding(10);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(73, 51);
            this.BtnPrev.TabIndex = 2;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(205, 19);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(10);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(73, 51);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(298, 19);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(10);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(73, 51);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stadium :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top Scorer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Worst Discipline :";
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Location = new System.Drawing.Point(168, 94);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(11, 16);
            this.LblTeam.TabIndex = 9;
            this.LblTeam.Text = "-";
            // 
            // LblManager
            // 
            this.LblManager.AutoSize = true;
            this.LblManager.Location = new System.Drawing.Point(168, 124);
            this.LblManager.Name = "LblManager";
            this.LblManager.Size = new System.Drawing.Size(11, 16);
            this.LblManager.TabIndex = 10;
            this.LblManager.Text = "-";
            // 
            // LblStadium
            // 
            this.LblStadium.AutoSize = true;
            this.LblStadium.Location = new System.Drawing.Point(168, 157);
            this.LblStadium.Name = "LblStadium";
            this.LblStadium.Size = new System.Drawing.Size(11, 16);
            this.LblStadium.TabIndex = 11;
            this.LblStadium.Text = "-";
            // 
            // LblTopScorer
            // 
            this.LblTopScorer.AutoSize = true;
            this.LblTopScorer.Location = new System.Drawing.Point(168, 190);
            this.LblTopScorer.Name = "LblTopScorer";
            this.LblTopScorer.Size = new System.Drawing.Size(11, 16);
            this.LblTopScorer.TabIndex = 12;
            this.LblTopScorer.Text = "-";
            // 
            // LblWorstDiscipline
            // 
            this.LblWorstDiscipline.AutoSize = true;
            this.LblWorstDiscipline.Location = new System.Drawing.Point(168, 222);
            this.LblWorstDiscipline.Name = "LblWorstDiscipline";
            this.LblWorstDiscipline.Size = new System.Drawing.Size(11, 16);
            this.LblWorstDiscipline.TabIndex = 13;
            this.LblWorstDiscipline.Text = "-";
            // 
            // DgvMatch
            // 
            this.DgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMatch.Location = new System.Drawing.Point(19, 260);
            this.DgvMatch.Name = "DgvMatch";
            this.DgvMatch.RowHeadersWidth = 51;
            this.DgvMatch.RowTemplate.Height = 24;
            this.DgvMatch.Size = new System.Drawing.Size(577, 192);
            this.DgvMatch.TabIndex = 14;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 464);
            this.Controls.Add(this.DgvMatch);
            this.Controls.Add(this.LblWorstDiscipline);
            this.Controls.Add(this.LblTopScorer);
            this.Controls.Add(this.LblStadium);
            this.Controls.Add(this.LblManager);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.label1);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTeam;
        private System.Windows.Forms.Label LblManager;
        private System.Windows.Forms.Label LblStadium;
        private System.Windows.Forms.Label LblTopScorer;
        private System.Windows.Forms.Label LblWorstDiscipline;
        private System.Windows.Forms.DataGridView DgvMatch;
    }
}

