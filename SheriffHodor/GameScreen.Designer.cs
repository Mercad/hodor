﻿namespace CSUSM
{
    namespace CS441
    {
        namespace SheriffHodor
        {
            partial class GameScreen
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
                    if (disposing && (components != null)) {
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
                    this.components = new System.ComponentModel.Container();
                    this.textBox1 = new System.Windows.Forms.TextBox();
                    this.label1 = new System.Windows.Forms.Label();
                    this.Next = new System.Windows.Forms.Button();
                    this.timer1 = new System.Windows.Forms.Timer(this.components);
                    this.textBox2 = new System.Windows.Forms.TextBox();
                    this.label2 = new System.Windows.Forms.Label();
                    this.SuspendLayout();
                    // 
                    // textBox1
                    // 
                    this.textBox1.Location = new System.Drawing.Point(135, 180);
                    this.textBox1.Name = "textBox1";
                    this.textBox1.Size = new System.Drawing.Size(110, 20);
                    this.textBox1.TabIndex = 0;
                    this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Location = new System.Drawing.Point(132, 127);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(93, 13);
                    this.label1.TabIndex = 1;
                    this.label1.Text = "Questions go here";
                    this.label1.Click += new System.EventHandler(this.label1_Click);
                    // 
                    // Next
                    // 
                    this.Next.Location = new System.Drawing.Point(155, 206);
                    this.Next.Name = "Next";
                    this.Next.Size = new System.Drawing.Size(75, 23);
                    this.Next.TabIndex = 2;
                    this.Next.Text = "Next";
                    this.Next.UseVisualStyleBackColor = true;
                    this.Next.Click += new System.EventHandler(this.button1_Click);
                    // 
                    // timer1
                    // 
                    this.timer1.Interval = 1000;
                    this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
                    // 
                    // textBox2
                    // 
                    this.textBox2.Location = new System.Drawing.Point(135, 77);
                    this.textBox2.Name = "textBox2";
                    this.textBox2.ReadOnly = true;
                    this.textBox2.Size = new System.Drawing.Size(110, 20);
                    this.textBox2.TabIndex = 3;
                    this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
                    // 
                    // label2
                    // 
                    this.label2.AutoSize = true;
                    this.label2.Location = new System.Drawing.Point(155, 27);
                    this.label2.Name = "label2";
                    this.label2.Size = new System.Drawing.Size(35, 13);
                    this.label2.TabIndex = 4;
                    this.label2.Text = "label2";
                    this.label2.Click += new System.EventHandler(this.label2_Click);
                    // 
                    // GameScreen
                    // 
                    this.AcceptButton = this.Next;
                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(408, 359);
                    this.Controls.Add(this.label2);
                    this.Controls.Add(this.textBox2);
                    this.Controls.Add(this.Next);
                    this.Controls.Add(this.label1);
                    this.Controls.Add(this.textBox1);
                    this.MaximumSize = new System.Drawing.Size(424, 398);
                    this.MinimumSize = new System.Drawing.Size(424, 398);
                    this.Name = "GameScreen";
                    this.Text = "GameScreen";
                    this.Load += new System.EventHandler(this.GameScreen_Load);
                    this.ResumeLayout(false);
                    this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.TextBox textBox1;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Button Next;
                private System.Windows.Forms.Timer timer1;
                private System.Windows.Forms.TextBox textBox2;
                private System.Windows.Forms.Label label2;
            }
        }
    }
}