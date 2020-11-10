namespace OhGamza.UI
{
  partial class RegisterForm
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
      this.registerLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // registerLabel
      // 
      this.registerLabel.AutoSize = true;
      this.registerLabel.Font = new System.Drawing.Font("HYGothic-Extra", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.registerLabel.Location = new System.Drawing.Point(150, 30);
      this.registerLabel.Name = "registerLabel";
      this.registerLabel.Size = new System.Drawing.Size(212, 48);
      this.registerLabel.TabIndex = 0;
      this.registerLabel.Text = "회원가입";
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 281);
      this.Controls.Add(this.registerLabel);
      this.Name = "RegisterForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "회원가입";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label registerLabel;
  }
}