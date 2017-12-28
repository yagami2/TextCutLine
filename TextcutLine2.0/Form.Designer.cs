using System;

namespace TextcutLine2._0
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.browsePathFile = new System.Windows.Forms.Button();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.countRows = new System.Windows.Forms.Button();
            this.cutInPart = new System.Windows.Forms.Button();
            this.cutRange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numStr = new System.Windows.Forms.TextBox();
            this.numStrInPart = new System.Windows.Forms.TextBox();
            this.startStr = new System.Windows.Forms.TextBox();
            this.finishStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFolder = new System.Windows.Forms.TextBox();
            this.browseSaveFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // browsePathFile
            // 
            this.browsePathFile.Location = new System.Drawing.Point(373, 23);
            this.browsePathFile.Name = "browsePathFile";
            this.browsePathFile.Size = new System.Drawing.Size(75, 23);
            this.browsePathFile.TabIndex = 1;
            this.browsePathFile.Text = "...Обзор";
            this.browsePathFile.UseVisualStyleBackColor = true;
            this.browsePathFile.Click += new System.EventHandler(this.browsePathFile_Click);
            // 
            // pathFile
            // 
            this.pathFile.AllowDrop = true;
            this.pathFile.Location = new System.Drawing.Point(127, 26);
            this.pathFile.Name = "pathFile";
            this.pathFile.Size = new System.Drawing.Size(240, 20);
            this.pathFile.TabIndex = 2;
            // 
            // countRows
            // 
            this.countRows.Location = new System.Drawing.Point(16, 127);
            this.countRows.Name = "countRows";
            this.countRows.Size = new System.Drawing.Size(115, 45);
            this.countRows.TabIndex = 3;
            this.countRows.Text = "Посчитать количство строк";
            this.countRows.UseVisualStyleBackColor = true;
            this.countRows.Click += new System.EventHandler(this.countRows_Click);
            // 
            // cutInPart
            // 
            this.cutInPart.Location = new System.Drawing.Point(16, 178);
            this.cutInPart.Name = "cutInPart";
            this.cutInPart.Size = new System.Drawing.Size(115, 45);
            this.cutInPart.TabIndex = 4;
            this.cutInPart.Text = "Порезать на части";
            this.cutInPart.UseVisualStyleBackColor = true;
            this.cutInPart.Click += new System.EventHandler(this.cutInPart_Click);
            // 
            // cutRange
            // 
            this.cutRange.Location = new System.Drawing.Point(16, 229);
            this.cutRange.Name = "cutRange";
            this.cutRange.Size = new System.Drawing.Size(115, 45);
            this.cutRange.TabIndex = 5;
            this.cutRange.Text = "Вырезать диапазон";
            this.cutRange.UseVisualStyleBackColor = true;
            this.cutRange.Click += new System.EventHandler(this.cutRange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите файл:";
            // 
            // numStr
            // 
            this.numStr.Location = new System.Drawing.Point(307, 140);
            this.numStr.Name = "numStr";
            this.numStr.Size = new System.Drawing.Size(141, 20);
            this.numStr.TabIndex = 7;
            // 
            // numStrInPart
            // 
            this.numStrInPart.Location = new System.Drawing.Point(307, 191);
            this.numStrInPart.Name = "numStrInPart";
            this.numStrInPart.Size = new System.Drawing.Size(141, 20);
            this.numStrInPart.TabIndex = 8;
            // 
            // startStr
            // 
            this.startStr.Location = new System.Drawing.Point(307, 229);
            this.startStr.Name = "startStr";
            this.startStr.Size = new System.Drawing.Size(141, 20);
            this.startStr.TabIndex = 9;
            // 
            // finishStr
            // 
            this.finishStr.Location = new System.Drawing.Point(307, 255);
            this.finishStr.Name = "finishStr";
            this.finishStr.Size = new System.Drawing.Size(141, 20);
            this.finishStr.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Куда сохранить:";
            // 
            // saveFolder
            // 
            this.saveFolder.AllowDrop = true;
            this.saveFolder.Location = new System.Drawing.Point(127, 67);
            this.saveFolder.Name = "saveFolder";
            this.saveFolder.Size = new System.Drawing.Size(240, 20);
            this.saveFolder.TabIndex = 12;
            this.saveFolder.Text = "C:\\Users\\klevenskiy\\Documents\\TextCutLine";
            // 
            // browseSaveFolder
            // 
            this.browseSaveFolder.Location = new System.Drawing.Point(373, 64);
            this.browseSaveFolder.Name = "browseSaveFolder";
            this.browseSaveFolder.Size = new System.Drawing.Size(75, 23);
            this.browseSaveFolder.TabIndex = 11;
            this.browseSaveFolder.Text = "...Обзор";
            this.browseSaveFolder.UseVisualStyleBackColor = true;
            this.browseSaveFolder.Click += new System.EventHandler(this.browseSaveFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Всего строк в файле:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сколько строк должно \nбыть в каждой части:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "С какой строки начать:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "На какой строке закончить:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 319);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveFolder);
            this.Controls.Add(this.browseSaveFolder);
            this.Controls.Add(this.finishStr);
            this.Controls.Add(this.startStr);
            this.Controls.Add(this.numStrInPart);
            this.Controls.Add(this.numStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cutRange);
            this.Controls.Add(this.cutInPart);
            this.Controls.Add(this.countRows);
            this.Controls.Add(this.pathFile);
            this.Controls.Add(this.browsePathFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "TextCutLine2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browsePathFile;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.Button countRows;
        private System.Windows.Forms.Button cutInPart;
        private System.Windows.Forms.Button cutRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numStr;
        private System.Windows.Forms.TextBox numStrInPart;
        private System.Windows.Forms.TextBox startStr;
        private System.Windows.Forms.TextBox finishStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveFolder;
        private System.Windows.Forms.Button browseSaveFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

