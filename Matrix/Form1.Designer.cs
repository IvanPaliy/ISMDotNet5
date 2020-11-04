namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonGenerateMatrix = new System.Windows.Forms.Button();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.labelColCount = new System.Windows.Forms.Label();
            this.numericUpDownRowCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2ColCount = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPosetiveCount = new System.Windows.Forms.Label();
            this.labelSameMaxElement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountStringsWithoutNull = new System.Windows.Forms.Label();
            this.labelCountColumnsWithNull = new System.Windows.Forms.Label();
            this.labelColmnsNoNull = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLongestSeriesElementsString = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProductNonNullStrings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2ColCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewMatrix
            // 
            this.DataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMatrix.Location = new System.Drawing.Point(11, 112);
            this.DataGridViewMatrix.Name = "DataGridViewMatrix";
            this.DataGridViewMatrix.RowHeadersWidth = 51;
            this.DataGridViewMatrix.RowTemplate.Height = 24;
            this.DataGridViewMatrix.Size = new System.Drawing.Size(759, 326);
            this.DataGridViewMatrix.TabIndex = 0;
            // 
            // buttonGenerateMatrix
            // 
            this.buttonGenerateMatrix.Location = new System.Drawing.Point(15, 70);
            this.buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            this.buttonGenerateMatrix.Size = new System.Drawing.Size(104, 36);
            this.buttonGenerateMatrix.TabIndex = 1;
            this.buttonGenerateMatrix.Text = "Generate";
            this.buttonGenerateMatrix.UseVisualStyleBackColor = true;
            this.buttonGenerateMatrix.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRowCount
            // 
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Location = new System.Drawing.Point(12, 13);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(46, 17);
            this.labelRowCount.TabIndex = 2;
            this.labelRowCount.Text = "Rows:";
            // 
            // labelColCount
            // 
            this.labelColCount.AutoSize = true;
            this.labelColCount.Location = new System.Drawing.Point(12, 47);
            this.labelColCount.Name = "labelColCount";
            this.labelColCount.Size = new System.Drawing.Size(66, 17);
            this.labelColCount.TabIndex = 3;
            this.labelColCount.Text = "Columns:";
            // 
            // numericUpDownRowCount
            // 
            this.numericUpDownRowCount.Location = new System.Drawing.Point(95, 8);
            this.numericUpDownRowCount.Name = "numericUpDownRowCount";
            this.numericUpDownRowCount.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownRowCount.TabIndex = 4;
            this.numericUpDownRowCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2ColCount
            // 
            this.numericUpDown2ColCount.Location = new System.Drawing.Point(95, 42);
            this.numericUpDown2ColCount.Name = "numericUpDown2ColCount";
            this.numericUpDown2ColCount.Size = new System.Drawing.Size(156, 22);
            this.numericUpDown2ColCount.TabIndex = 5;
            this.numericUpDown2ColCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(125, 70);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(126, 35);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPosetiveCount
            // 
            this.labelPosetiveCount.AutoSize = true;
            this.labelPosetiveCount.Location = new System.Drawing.Point(365, 8);
            this.labelPosetiveCount.Name = "labelPosetiveCount";
            this.labelPosetiveCount.Size = new System.Drawing.Size(0, 17);
            this.labelPosetiveCount.TabIndex = 8;
            // 
            // labelSameMaxElement
            // 
            this.labelSameMaxElement.AutoSize = true;
            this.labelSameMaxElement.Location = new System.Drawing.Point(389, 30);
            this.labelSameMaxElement.Name = "labelSameMaxElement";
            this.labelSameMaxElement.Size = new System.Drawing.Size(0, 17);
            this.labelSameMaxElement.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Positive Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Same Max Element:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strings Without Null:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCountStringsWithoutNull
            // 
            this.labelCountStringsWithoutNull.AutoSize = true;
            this.labelCountStringsWithoutNull.Location = new System.Drawing.Point(389, 56);
            this.labelCountStringsWithoutNull.Name = "labelCountStringsWithoutNull";
            this.labelCountStringsWithoutNull.Size = new System.Drawing.Size(0, 17);
            this.labelCountStringsWithoutNull.TabIndex = 13;
            // 
            // labelCountColumnsWithNull
            // 
            this.labelCountColumnsWithNull.AutoSize = true;
            this.labelCountColumnsWithNull.Location = new System.Drawing.Point(257, 80);
            this.labelCountColumnsWithNull.Name = "labelCountColumnsWithNull";
            this.labelCountColumnsWithNull.Size = new System.Drawing.Size(126, 17);
            this.labelCountColumnsWithNull.TabIndex = 14;
            this.labelCountColumnsWithNull.Text = "Columns With Null:\r\n";
            // 
            // labelColmnsNoNull
            // 
            this.labelColmnsNoNull.AutoSize = true;
            this.labelColmnsNoNull.Location = new System.Drawing.Point(389, 80);
            this.labelColmnsNoNull.Name = "labelColmnsNoNull";
            this.labelColmnsNoNull.Size = new System.Drawing.Size(0, 17);
            this.labelColmnsNoNull.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Longest Series in Row:";
            // 
            // labelLongestSeriesElementsString
            // 
            this.labelLongestSeriesElementsString.AutoSize = true;
            this.labelLongestSeriesElementsString.Location = new System.Drawing.Point(590, 10);
            this.labelLongestSeriesElementsString.Name = "labelLongestSeriesElementsString";
            this.labelLongestSeriesElementsString.Size = new System.Drawing.Size(0, 17);
            this.labelLongestSeriesElementsString.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Product Non Negative Rows:";
            // 
            // labelProductNonNullStrings
            // 
            this.labelProductNonNullStrings.AutoSize = true;
            this.labelProductNonNullStrings.Location = new System.Drawing.Point(627, 30);
            this.labelProductNonNullStrings.Name = "labelProductNonNullStrings";
            this.labelProductNonNullStrings.Size = new System.Drawing.Size(0, 17);
            this.labelProductNonNullStrings.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.labelProductNonNullStrings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLongestSeriesElementsString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelColmnsNoNull);
            this.Controls.Add(this.labelCountColumnsWithNull);
            this.Controls.Add(this.labelCountStringsWithoutNull);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSameMaxElement);
            this.Controls.Add(this.labelPosetiveCount);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDown2ColCount);
            this.Controls.Add(this.numericUpDownRowCount);
            this.Controls.Add(this.labelColCount);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.buttonGenerateMatrix);
            this.Controls.Add(this.DataGridViewMatrix);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matrix Things";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2ColCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewMatrix;
        private System.Windows.Forms.Button buttonGenerateMatrix;
        private System.Windows.Forms.Label labelRowCount;
        private System.Windows.Forms.Label labelColCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRowCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2ColCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPosetiveCount;
        private System.Windows.Forms.Label labelSameMaxElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountStringsWithoutNull;
        private System.Windows.Forms.Label labelCountColumnsWithNull;
        private System.Windows.Forms.Label labelColmnsNoNull;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLongestSeriesElementsString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProductNonNullStrings;
    }
}

