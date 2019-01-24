namespace ScorePredictor
{
    partial class ScorePredictor
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.comboA = new System.Windows.Forms.ComboBox();
            this.comboB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrediction = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelHelper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalMatchups = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxIter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(111, 29);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(100, 109);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 1;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // comboA
            // 
            this.comboA.FormattingEnabled = true;
            this.comboA.Location = new System.Drawing.Point(12, 82);
            this.comboA.Name = "comboA";
            this.comboA.Size = new System.Drawing.Size(121, 21);
            this.comboA.TabIndex = 2;
            // 
            // comboB
            // 
            this.comboB.FormattingEnabled = true;
            this.comboB.Location = new System.Drawing.Point(142, 82);
            this.comboB.Name = "comboB";
            this.comboB.Size = new System.Drawing.Size(121, 21);
            this.comboB.TabIndex = 3;
            this.comboB.SelectedIndexChanged += new System.EventHandler(this.comboB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Team B";
            // 
            // labelPrediction
            // 
            this.labelPrediction.AutoSize = true;
            this.labelPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrediction.Location = new System.Drawing.Point(74, 178);
            this.labelPrediction.Name = "labelPrediction";
            this.labelPrediction.Size = new System.Drawing.Size(135, 31);
            this.labelPrediction.TabIndex = 8;
            this.labelPrediction.Text = "Prediction";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(136, 206);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(125, 31);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Load File";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(202, 219);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // labelHelper
            // 
            this.labelHelper.AutoSize = true;
            this.labelHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelper.Location = new System.Drawing.Point(12, 147);
            this.labelHelper.Name = "labelHelper";
            this.labelHelper.Size = new System.Drawing.Size(83, 31);
            this.labelHelper.TabIndex = 12;
            this.labelHelper.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status:";
            // 
            // labelTotalMatchups
            // 
            this.labelTotalMatchups.AutoSize = true;
            this.labelTotalMatchups.Location = new System.Drawing.Point(369, 318);
            this.labelTotalMatchups.Name = "labelTotalMatchups";
            this.labelTotalMatchups.Size = new System.Drawing.Size(81, 13);
            this.labelTotalMatchups.TabIndex = 14;
            this.labelTotalMatchups.Text = "Total Matchups";
            this.labelTotalMatchups.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(423, 277);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(41, 13);
            this.labelA.TabIndex = 15;
            this.labelA.Text = "countA";
            this.labelA.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(559, 276);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(41, 13);
            this.labelB.TabIndex = 16;
            this.labelB.Text = "countB";
            this.labelB.Visible = false;
            // 
            // textBoxIter
            // 
            this.textBoxIter.Location = new System.Drawing.Point(425, 353);
            this.textBoxIter.Name = "textBoxIter";
            this.textBoxIter.Size = new System.Drawing.Size(100, 20);
            this.textBoxIter.TabIndex = 18;
            this.textBoxIter.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Iterations";
            // 
            // ScorePredictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIter);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelTotalMatchups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHelper);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPrediction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboB);
            this.Controls.Add(this.comboA);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnLoadFile);
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "ScorePredictor";
            this.Text = "ScorePredictor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.ComboBox comboA;
        private System.Windows.Forms.ComboBox comboB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrediction;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelHelper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalMatchups;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxIter;
        private System.Windows.Forms.Label label4;
    }
}

