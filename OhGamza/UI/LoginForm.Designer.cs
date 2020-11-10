namespace OhGamza.UI
{
  partial class 로그인
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
      this.LoginTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LoginTitle
      // 
      this.LoginTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.LoginTitle.AutoSize = true;
      this.LoginTitle.Font = new System.Drawing.Font("HYGothic-Extra", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.LoginTitle.Location = new System.Drawing.Point(162, 30);
      this.LoginTitle.Name = "LoginTitle";
      this.LoginTitle.Size = new System.Drawing.Size(164, 48);
      this.LoginTitle.TabIndex = 0;
      this.LoginTitle.Text = "로그인";
      // 
      // 로그인
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 281);
      this.Controls.Add(this.LoginTitle);
      this.Name = "로그인";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "로그인";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LoginTitle;
  }
}