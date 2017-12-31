// Decompiled with JetBrains decompiler
// Type: Cleaner.Form1
// Assembly: WindowsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0F7914-DDF1-44F8-B72B-F2E7307DD8C7
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Miner Cleaner.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Cleaner
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    public Form1()
    {
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Button1 = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.SuspendLayout();
      this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Button button1_1 = this.Button1;
      Point point1 = new Point(12, 45);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(194, 28);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Очистить";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 9);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(120, 20);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Miner by Dzotra";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(13, 29);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(57, 13);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "CLEANER";
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(76, 29);
      Point point5 = point1;
      label3_1.Location = point5;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(28, 13);
      Size size5 = size1;
      label3_2.Size = size5;
      this.Label3.TabIndex = 3;
      this.Label3.Text = "v1.1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(220, 78);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "MinerCleaner";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension("intelservice")).Length > 0)
        {
          Process.GetProcessesByName("intelservice")[0].Kill();
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) "Процесс майнера не найден!", MsgBoxStyle.Information, (object) "Cleaner");
        }
        if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension("intelmain")).Length > 0)
          Process.GetProcessesByName("intelmain")[0].Kill();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (Directory.Exists("C:\\ProgramData\\Intel(R) Management"))
        {
          Directory.Delete("C:\\ProgramData\\Intel(R) Management", true);
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) "Файлы майнера не найдены!", MsgBoxStyle.Information, (object) "Cleaner");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num1 = (int) Interaction.MsgBox((object) "Очистка завершена!", MsgBoxStyle.OkOnly, (object) "Cleaner");
    }
  }
}
