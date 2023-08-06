namespace InteractiveScottPlot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            ClickableScatterPlotButton = new Button();
            label6 = new Label();
            SelectionPolygonButton = new Button();
            label7 = new Label();
            InteractiveRegionButton = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(90, 42);
            label1.Name = "label1";
            label1.Size = new Size(278, 38);
            label1.TabIndex = 0;
            label1.Text = "InteractiveScottPlot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 114);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 134);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "ScottPlot version:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(217, 114);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(222, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/gabrielgcma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 134);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 4;
            label4.Text = "4.1.65";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 177);
            label5.Name = "label5";
            label5.Size = new Size(416, 123);
            label5.TabIndex = 5;
            label5.Text = "This demo app showcases some functionalities to make your WinForms plots more interactive using ScottPlot.\r\n\r\nNew features are planned to be added with time.\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClickableScatterPlotButton
            // 
            ClickableScatterPlotButton.Location = new Point(17, 325);
            ClickableScatterPlotButton.Name = "ClickableScatterPlotButton";
            ClickableScatterPlotButton.Size = new Size(94, 95);
            ClickableScatterPlotButton.TabIndex = 6;
            ClickableScatterPlotButton.Text = "Clickable ScatterPlot";
            ClickableScatterPlotButton.UseVisualStyleBackColor = true;
            ClickableScatterPlotButton.Click += ClickableScatterPlotButton_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(117, 325);
            label6.Name = "label6";
            label6.Size = new Size(325, 95);
            label6.TabIndex = 7;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectionPolygonButton
            // 
            SelectionPolygonButton.Location = new Point(17, 447);
            SelectionPolygonButton.Name = "SelectionPolygonButton";
            SelectionPolygonButton.Size = new Size(94, 73);
            SelectionPolygonButton.TabIndex = 8;
            SelectionPolygonButton.Text = "Selection Polygon";
            SelectionPolygonButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(117, 447);
            label7.Name = "label7";
            label7.Size = new Size(325, 73);
            label7.TabIndex = 9;
            label7.Text = "Sometimes you want the user to have fine-grained control over a dataset. This feature allows the user to create a polygon from which points will be filtered out.";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InteractiveRegionButton
            // 
            InteractiveRegionButton.Location = new Point(17, 546);
            InteractiveRegionButton.Name = "InteractiveRegionButton";
            InteractiveRegionButton.Size = new Size(94, 73);
            InteractiveRegionButton.TabIndex = 10;
            InteractiveRegionButton.Text = "Interactive region";
            InteractiveRegionButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(117, 546);
            label8.Name = "label8";
            label8.Size = new Size(325, 73);
            label8.TabIndex = 11;
            label8.Text = "An interactive rectangular region from which points can also be filtered out.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 650);
            Controls.Add(label8);
            Controls.Add(InteractiveRegionButton);
            Controls.Add(label7);
            Controls.Add(SelectionPolygonButton);
            Controls.Add(label6);
            Controls.Add(ClickableScatterPlotButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label5;
        private Button ClickableScatterPlotButton;
        private Label label6;
        private Button SelectionPolygonButton;
        private Label label7;
        private Button InteractiveRegionButton;
        private Label label8;
    }
}