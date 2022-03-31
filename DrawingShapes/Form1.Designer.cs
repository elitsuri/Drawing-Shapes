
namespace DrawingShapes
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
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShapeChoose = new System.Windows.Forms.Label();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(93, 34);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 34);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(174, 34);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 2;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnDiamond
            // 
            this.btnDiamond.Location = new System.Drawing.Point(255, 34);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(75, 23);
            this.btnDiamond.TabIndex = 3;
            this.btnDiamond.Text = "Diamond";
            this.btnDiamond.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your choose:";
            // 
            // lblShapeChoose
            // 
            this.lblShapeChoose.AutoSize = true;
            this.lblShapeChoose.Location = new System.Drawing.Point(540, 39);
            this.lblShapeChoose.Name = "lblShapeChoose";
            this.lblShapeChoose.Size = new System.Drawing.Size(45, 13);
            this.lblShapeChoose.TabIndex = 6;
            this.lblShapeChoose.Text = "Polygon";
            // 
            // btnPolygon
            // 
            this.btnPolygon.Location = new System.Drawing.Point(336, 34);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(75, 23);
            this.btnPolygon.TabIndex = 7;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 394);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(76, 471);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(47, 20);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(126, 475);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Black";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 501);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.lblShapeChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiamond);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnRectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnDiamond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShapeChoose;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
    }
}

