namespace Assignment_2_n01531431
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Queue = new System.Windows.Forms.Label();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnenq = new System.Windows.Forms.Button();
            this.btnDeq = new System.Windows.Forms.Button();
            this.btnQDisplay = new System.Windows.Forms.Button();
            this.btnQPeek = new System.Windows.Forms.Button();
            this.lblll = new System.Windows.Forms.Label();
            this.btnAddLastLL = new System.Windows.Forms.Button();
            this.btnAddFirstLL = new System.Windows.Forms.Button();
            this.btnDisplayLL = new System.Windows.Forms.Button();
            this.btnRemoveLL = new System.Windows.Forms.Button();
            this.btnFindLL = new System.Windows.Forms.Button();
            this.btnRemoveFirstLL = new System.Windows.Forms.Button();
            this.btnRemoveLastLL = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(87, 76);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(125, 27);
            this.txtCourseName.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(325, 76);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 27);
            this.txtScore.TabIndex = 1;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 20;
            this.lbxOutput.Location = new System.Drawing.Point(563, 76);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(213, 344);
            this.lbxOutput.TabIndex = 2;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(134, 151);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(94, 29);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(273, 151);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(416, 151);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(94, 29);
            this.btnPeek.TabIndex = 6;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "For Stack";
            // 
            // Queue
            // 
            this.Queue.AutoSize = true;
            this.Queue.Location = new System.Drawing.Point(12, 201);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(77, 20);
            this.Queue.TabIndex = 8;
            this.Queue.Text = "For Queue";
            // 
            // btnpush
            // 
            this.btnpush.Location = new System.Drawing.Point(12, 151);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(94, 29);
            this.btnpush.TabIndex = 3;
            this.btnpush.Text = "Push";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // btnenq
            // 
            this.btnenq.Location = new System.Drawing.Point(12, 240);
            this.btnenq.Name = "btnenq";
            this.btnenq.Size = new System.Drawing.Size(94, 29);
            this.btnenq.TabIndex = 9;
            this.btnenq.Text = "Enqueue";
            this.btnenq.UseVisualStyleBackColor = true;
            this.btnenq.Click += new System.EventHandler(this.btnenq_Click);
            // 
            // btnDeq
            // 
            this.btnDeq.Location = new System.Drawing.Point(134, 240);
            this.btnDeq.Name = "btnDeq";
            this.btnDeq.Size = new System.Drawing.Size(94, 29);
            this.btnDeq.TabIndex = 10;
            this.btnDeq.Text = "Dequeue";
            this.btnDeq.UseVisualStyleBackColor = true;
            this.btnDeq.Click += new System.EventHandler(this.btnDeq_Click);
            // 
            // btnQDisplay
            // 
            this.btnQDisplay.Location = new System.Drawing.Point(273, 240);
            this.btnQDisplay.Name = "btnQDisplay";
            this.btnQDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnQDisplay.TabIndex = 11;
            this.btnQDisplay.Text = "Display";
            this.btnQDisplay.UseVisualStyleBackColor = true;
            this.btnQDisplay.Click += new System.EventHandler(this.btnQDisplay_Click);
            // 
            // btnQPeek
            // 
            this.btnQPeek.Location = new System.Drawing.Point(416, 240);
            this.btnQPeek.Name = "btnQPeek";
            this.btnQPeek.Size = new System.Drawing.Size(94, 29);
            this.btnQPeek.TabIndex = 12;
            this.btnQPeek.Text = "Peek";
            this.btnQPeek.UseVisualStyleBackColor = true;
            this.btnQPeek.Click += new System.EventHandler(this.btnQPeek_Click);
            // 
            // lblll
            // 
            this.lblll.AutoSize = true;
            this.lblll.Location = new System.Drawing.Point(12, 293);
            this.lblll.Name = "lblll";
            this.lblll.Size = new System.Drawing.Size(78, 20);
            this.lblll.TabIndex = 13;
            this.lblll.Text = "Linked List";
            // 
            // btnAddLastLL
            // 
            this.btnAddLastLL.Location = new System.Drawing.Point(12, 326);
            this.btnAddLastLL.Name = "btnAddLastLL";
            this.btnAddLastLL.Size = new System.Drawing.Size(94, 29);
            this.btnAddLastLL.TabIndex = 14;
            this.btnAddLastLL.Text = "Add Last";
            this.btnAddLastLL.UseVisualStyleBackColor = true;
            this.btnAddLastLL.Click += new System.EventHandler(this.btnAddLastLL_Click);
            // 
            // btnAddFirstLL
            // 
            this.btnAddFirstLL.Location = new System.Drawing.Point(134, 326);
            this.btnAddFirstLL.Name = "btnAddFirstLL";
            this.btnAddFirstLL.Size = new System.Drawing.Size(94, 29);
            this.btnAddFirstLL.TabIndex = 15;
            this.btnAddFirstLL.Text = "Add First";
            this.btnAddFirstLL.UseVisualStyleBackColor = true;
            this.btnAddFirstLL.Click += new System.EventHandler(this.btnAddFirstLL_Click);
            // 
            // btnDisplayLL
            // 
            this.btnDisplayLL.Location = new System.Drawing.Point(273, 326);
            this.btnDisplayLL.Name = "btnDisplayLL";
            this.btnDisplayLL.Size = new System.Drawing.Size(94, 29);
            this.btnDisplayLL.TabIndex = 16;
            this.btnDisplayLL.Text = "Display";
            this.btnDisplayLL.UseVisualStyleBackColor = true;
            this.btnDisplayLL.Click += new System.EventHandler(this.btnDisplayLL_Click);
            // 
            // btnRemoveLL
            // 
            this.btnRemoveLL.Location = new System.Drawing.Point(416, 326);
            this.btnRemoveLL.Name = "btnRemoveLL";
            this.btnRemoveLL.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveLL.TabIndex = 17;
            this.btnRemoveLL.Text = "Remove";
            this.btnRemoveLL.UseVisualStyleBackColor = true;
            this.btnRemoveLL.Click += new System.EventHandler(this.btnRemoveLL_Click);
            // 
            // btnFindLL
            // 
            this.btnFindLL.Location = new System.Drawing.Point(72, 380);
            this.btnFindLL.Name = "btnFindLL";
            this.btnFindLL.Size = new System.Drawing.Size(94, 29);
            this.btnFindLL.TabIndex = 18;
            this.btnFindLL.Text = "Find";
            this.btnFindLL.UseVisualStyleBackColor = true;
            this.btnFindLL.Click += new System.EventHandler(this.btnFindLL_Click);
            // 
            // btnRemoveFirstLL
            // 
            this.btnRemoveFirstLL.Location = new System.Drawing.Point(194, 380);
            this.btnRemoveFirstLL.Name = "btnRemoveFirstLL";
            this.btnRemoveFirstLL.Size = new System.Drawing.Size(103, 29);
            this.btnRemoveFirstLL.TabIndex = 19;
            this.btnRemoveFirstLL.Text = "Remove First";
            this.btnRemoveFirstLL.UseVisualStyleBackColor = true;
            this.btnRemoveFirstLL.Click += new System.EventHandler(this.btnRemoveFirstLL_Click);
            // 
            // btnRemoveLastLL
            // 
            this.btnRemoveLastLL.Location = new System.Drawing.Point(341, 380);
            this.btnRemoveLastLL.Name = "btnRemoveLastLL";
            this.btnRemoveLastLL.Size = new System.Drawing.Size(109, 29);
            this.btnRemoveLastLL.TabIndex = 20;
            this.btnRemoveLastLL.Text = "Remove Last";
            this.btnRemoveLastLL.UseVisualStyleBackColor = true;
            this.btnRemoveLastLL.Click += new System.EventHandler(this.btnRemoveLastLL_Click);
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(103, 38);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(98, 20);
            this.CourseName.TabIndex = 21;
            this.CourseName.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.btnRemoveLastLL);
            this.Controls.Add(this.btnRemoveFirstLL);
            this.Controls.Add(this.btnFindLL);
            this.Controls.Add(this.btnRemoveLL);
            this.Controls.Add(this.btnDisplayLL);
            this.Controls.Add(this.btnAddFirstLL);
            this.Controls.Add(this.btnAddLastLL);
            this.Controls.Add(this.lblll);
            this.Controls.Add(this.btnQPeek);
            this.Controls.Add(this.btnQDisplay);
            this.Controls.Add(this.btnDeq);
            this.Controls.Add(this.btnenq);
            this.Controls.Add(this.Queue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtCourseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCourseName;
        private TextBox txtScore;
        private ListBox lbxOutput;
        private Button btnPop;
        private Button btnDisplay;
        private Button btnPeek;
        private Label label1;
        private Label Queue;
        private Button btnpush;
        private Button btnenq;
        private Button btnDeq;
        private Button btnQDisplay;
        private Button btnQPeek;
        private Label lblll;
        private Button btnAddLastLL;
        private Button btnAddFirstLL;
        private Button btnDisplayLL;
        private Button btnRemoveLL;
        private Button btnFindLL;
        private Button btnRemoveFirstLL;
        private Button btnRemoveLastLL;
        private Label CourseName;
        private Label label2;
    }
}