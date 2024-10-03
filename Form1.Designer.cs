
namespace AragonLocalidades
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
      this.button1 = new System.Windows.Forms.Button();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(296, 143);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(79, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Iniciar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Location = new System.Drawing.Point(296, 61);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(78, 19);
      this.radioButton1.TabIndex = 1;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Comarcas";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(296, 97);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(79, 19);
      this.radioButton2.TabIndex = 2;
      this.radioButton2.Text = "Provincias";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(12, 23);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(267, 182);
      this.treeView1.TabIndex = 3;
      this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 212);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(200, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Información DoubleClick en el Nodo";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 244);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Aragón Municipios y Localidades (Sitio singular)";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Label label1;
  }
}

