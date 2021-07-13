
namespace MyLauncher
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
            this.bExecuteInstallation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExecuteUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bSelectPathToDestination = new System.Windows.Forms.Button();
            this.bSelectPathToOriginal = new System.Windows.Forms.Button();
            this.tbDestinationPath = new System.Windows.Forms.TextBox();
            this.tbOriginalPath = new System.Windows.Forms.TextBox();
            this.rtbContextInfo = new System.Windows.Forms.RichTextBox();
            this.pbContextProgress = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bExecuteInstallation
            // 
            this.bExecuteInstallation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bExecuteInstallation.Location = new System.Drawing.Point(3, 3);
            this.bExecuteInstallation.Name = "bExecuteInstallation";
            this.bExecuteInstallation.Size = new System.Drawing.Size(275, 86);
            this.bExecuteInstallation.TabIndex = 0;
            this.bExecuteInstallation.Text = "Выполнить установку";
            this.bExecuteInstallation.UseVisualStyleBackColor = true;
            this.bExecuteInstallation.Click += new System.EventHandler(this.bExecuteInstallation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bExecuteUpdate);
            this.panel1.Controls.Add(this.bExecuteInstallation);
            this.panel1.Location = new System.Drawing.Point(240, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 92);
            this.panel1.TabIndex = 1;
            // 
            // bExecuteUpdate
            // 
            this.bExecuteUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bExecuteUpdate.Location = new System.Drawing.Point(320, 3);
            this.bExecuteUpdate.Name = "bExecuteUpdate";
            this.bExecuteUpdate.Size = new System.Drawing.Size(249, 86);
            this.bExecuteUpdate.TabIndex = 1;
            this.bExecuteUpdate.Text = "Выполнить обновление";
            this.bExecuteUpdate.UseVisualStyleBackColor = true;
            this.bExecuteUpdate.Click += new System.EventHandler(this.bExecuteUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bSelectPathToDestination);
            this.panel2.Controls.Add(this.bSelectPathToOriginal);
            this.panel2.Controls.Add(this.tbDestinationPath);
            this.panel2.Controls.Add(this.tbOriginalPath);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 98);
            this.panel2.TabIndex = 2;
            // 
            // bSelectPathToDestination
            // 
            this.bSelectPathToDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelectPathToDestination.Location = new System.Drawing.Point(822, 51);
            this.bSelectPathToDestination.Name = "bSelectPathToDestination";
            this.bSelectPathToDestination.Size = new System.Drawing.Size(233, 35);
            this.bSelectPathToDestination.TabIndex = 3;
            this.bSelectPathToDestination.Text = "выбрать место назначения";
            this.bSelectPathToDestination.UseVisualStyleBackColor = true;
            this.bSelectPathToDestination.Click += new System.EventHandler(this.bSelectPathToDestination_Click);
            // 
            // bSelectPathToOriginal
            // 
            this.bSelectPathToOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelectPathToOriginal.Location = new System.Drawing.Point(822, 10);
            this.bSelectPathToOriginal.Name = "bSelectPathToOriginal";
            this.bSelectPathToOriginal.Size = new System.Drawing.Size(233, 35);
            this.bSelectPathToOriginal.TabIndex = 2;
            this.bSelectPathToOriginal.Text = "выбрать источник";
            this.bSelectPathToOriginal.UseVisualStyleBackColor = true;
            this.bSelectPathToOriginal.Click += new System.EventHandler(this.bSelectPathToOriginal_Click);
            // 
            // tbDestinationPath
            // 
            this.tbDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestinationPath.Location = new System.Drawing.Point(3, 57);
            this.tbDestinationPath.Name = "tbDestinationPath";
            this.tbDestinationPath.Size = new System.Drawing.Size(813, 22);
            this.tbDestinationPath.TabIndex = 1;
            this.tbDestinationPath.Text = "E:\\Inctitute\\3 курс 2 семестр\\учебная практика\\launcherProgram\\testFolder";
            // 
            // tbOriginalPath
            // 
            this.tbOriginalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginalPath.Location = new System.Drawing.Point(3, 16);
            this.tbOriginalPath.Name = "tbOriginalPath";
            this.tbOriginalPath.Size = new System.Drawing.Size(813, 22);
            this.tbOriginalPath.TabIndex = 0;
            this.tbOriginalPath.Text = "C:\\Users\\ant_a\\OneDrive\\MY_NOTES\\_My_project_DnD_application\\program\\DnD_project\\" +
    "DnD_project\\bin\\Debug\\net5.0-windows\\DnD_project.exe";
            // 
            // rtbContextInfo
            // 
            this.rtbContextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContextInfo.Location = new System.Drawing.Point(12, 258);
            this.rtbContextInfo.Name = "rtbContextInfo";
            this.rtbContextInfo.Size = new System.Drawing.Size(1058, 332);
            this.rtbContextInfo.TabIndex = 3;
            this.rtbContextInfo.Text = "";
            // 
            // pbContextProgress
            // 
            this.pbContextProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbContextProgress.Location = new System.Drawing.Point(12, 214);
            this.pbContextProgress.Name = "pbContextProgress";
            this.pbContextProgress.Size = new System.Drawing.Size(1058, 29);
            this.pbContextProgress.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 593);
            this.Controls.Add(this.pbContextProgress);
            this.Controls.Add(this.rtbContextInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1100, 640);
            this.Name = "Form1";
            this.Text = "Установщик";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExecuteInstallation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bExecuteUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bSelectPathToOriginal;
        private System.Windows.Forms.TextBox tbDestinationPath;
        private System.Windows.Forms.TextBox tbOriginalPath;
        private System.Windows.Forms.Button bSelectPathToDestination;
        private System.Windows.Forms.RichTextBox rtbContextInfo;
        private System.Windows.Forms.ProgressBar pbContextProgress;
    }
}

