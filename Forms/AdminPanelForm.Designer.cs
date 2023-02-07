
namespace Banking.UI
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.Exit = new System.Windows.Forms.Button();
            this.PanelAdmin = new System.Windows.Forms.TabControl();
            this.Role = new System.Windows.Forms.TabPage();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.RoleList = new System.Windows.Forms.DataGridView();
            this.PanelAdmin.SuspendLayout();
            this.Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleList)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(480, 216);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 39);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Вернуться обратно";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.Role);
            this.PanelAdmin.Location = new System.Drawing.Point(12, 12);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.SelectedIndex = 0;
            this.PanelAdmin.Size = new System.Drawing.Size(610, 287);
            this.PanelAdmin.TabIndex = 1;
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Role.Controls.Add(this.Delete);
            this.Role.Controls.Add(this.Save);
            this.Role.Controls.Add(this.RoleList);
            this.Role.Controls.Add(this.Exit);
            this.Role.Location = new System.Drawing.Point(4, 22);
            this.Role.Name = "Role";
            this.Role.Padding = new System.Windows.Forms.Padding(3);
            this.Role.Size = new System.Drawing.Size(602, 261);
            this.Role.TabIndex = 0;
            this.Role.Text = "Смена ролей";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(480, 171);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 39);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(480, 123);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 42);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RoleList
            // 
            this.RoleList.AllowUserToAddRows = false;
            this.RoleList.AllowUserToDeleteRows = false;
            this.RoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleList.Location = new System.Drawing.Point(6, 6);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(468, 249);
            this.RoleList.TabIndex = 1;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.PanelAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.PanelAdmin.ResumeLayout(false);
            this.Role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TabControl PanelAdmin;
        private System.Windows.Forms.TabPage Role;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView RoleList;
    }
}