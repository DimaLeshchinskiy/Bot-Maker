using System.Windows.Forms;

namespace BotMaker
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.WelcomePanel_Button_Load = new System.Windows.Forms.Button();
            this.WelcomePanel_Button_Create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ScreenshotPanel = new System.Windows.Forms.Panel();
            this.ScreenshotPanel_Image = new System.Windows.Forms.PictureBox();
            this.ToolsPanel_DropDown_Screenshot = new System.Windows.Forms.ComboBox();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.WelcomePanel_Text = new System.Windows.Forms.Label();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.ToolsPanel_Button_Variable = new System.Windows.Forms.Button();
            this.ToolsPanel_Button_Add = new System.Windows.Forms.Button();
            this.ToolsPanel_Button_Run = new System.Windows.Forms.Button();
            this.ToolsPanel_Button_Screenshot = new System.Windows.Forms.Button();
            this.ToolsPanel_Button_Build = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.PropertySideBar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ProjectSettings_Label_Count = new System.Windows.Forms.Label();
            this.ProjectSettings_TextField_Count = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoPanel_FeedBack_Link = new System.Windows.Forms.LinkLabel();
            this.TimelinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScreenshotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotPanel_Image)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.PropertySideBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomePanel_Button_Load
            // 
            this.WelcomePanel_Button_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.WelcomePanel_Button_Load.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomePanel_Button_Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomePanel_Button_Load.Location = new System.Drawing.Point(73, 275);
            this.WelcomePanel_Button_Load.Margin = new System.Windows.Forms.Padding(2);
            this.WelcomePanel_Button_Load.Name = "WelcomePanel_Button_Load";
            this.WelcomePanel_Button_Load.Size = new System.Drawing.Size(184, 50);
            this.WelcomePanel_Button_Load.TabIndex = 0;
            this.WelcomePanel_Button_Load.Text = "Load Project";
            this.WelcomePanel_Button_Load.UseVisualStyleBackColor = false;
            this.WelcomePanel_Button_Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // WelcomePanel_Button_Create
            // 
            this.WelcomePanel_Button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.WelcomePanel_Button_Create.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.WelcomePanel_Button_Create.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomePanel_Button_Create.ForeColor = System.Drawing.Color.White;
            this.WelcomePanel_Button_Create.Location = new System.Drawing.Point(73, 353);
            this.WelcomePanel_Button_Create.Margin = new System.Windows.Forms.Padding(2);
            this.WelcomePanel_Button_Create.Name = "WelcomePanel_Button_Create";
            this.WelcomePanel_Button_Create.Size = new System.Drawing.Size(184, 50);
            this.WelcomePanel_Button_Create.TabIndex = 1;
            this.WelcomePanel_Button_Create.Text = "Create New";
            this.WelcomePanel_Button_Create.UseVisualStyleBackColor = false;
            this.WelcomePanel_Button_Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ScreenshotPanel
            // 
            this.ScreenshotPanel.Controls.Add(this.ScreenshotPanel_Image);
            this.ScreenshotPanel.Controls.Add(this.ToolsPanel_DropDown_Screenshot);
            this.ScreenshotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenshotPanel.Location = new System.Drawing.Point(3, 3);
            this.ScreenshotPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenshotPanel.Name = "ScreenshotPanel";
            this.ScreenshotPanel.Size = new System.Drawing.Size(866, 512);
            this.ScreenshotPanel.TabIndex = 5;
            this.ScreenshotPanel.Visible = false;
            // 
            // ScreenshotPanel_Image
            // 
            this.ScreenshotPanel_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScreenshotPanel_Image.Location = new System.Drawing.Point(0, 28);
            this.ScreenshotPanel_Image.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenshotPanel_Image.Name = "ScreenshotPanel_Image";
            this.ScreenshotPanel_Image.Size = new System.Drawing.Size(866, 489);
            this.ScreenshotPanel_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenshotPanel_Image.TabIndex = 0;
            this.ScreenshotPanel_Image.TabStop = false;
            this.ScreenshotPanel_Image.WaitOnLoad = true;
            this.ScreenshotPanel_Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenshotPanel_Image_Click);
            // 
            // ToolsPanel_DropDown_Screenshot
            // 
            this.ToolsPanel_DropDown_Screenshot.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel_DropDown_Screenshot.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_DropDown_Screenshot.FormattingEnabled = true;
            this.ToolsPanel_DropDown_Screenshot.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel_DropDown_Screenshot.Margin = new System.Windows.Forms.Padding(2);
            this.ToolsPanel_DropDown_Screenshot.Name = "ToolsPanel_DropDown_Screenshot";
            this.ToolsPanel_DropDown_Screenshot.Size = new System.Drawing.Size(866, 28);
            this.ToolsPanel_DropDown_Screenshot.TabIndex = 3;
            this.ToolsPanel_DropDown_Screenshot.SelectedIndexChanged += new System.EventHandler(this.ToolsPanel_DropDown_Screenshot_SelectedIndexChanged);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.Controls.Add(this.WelcomePanel_Text);
            this.WelcomePanel.Controls.Add(this.WelcomePanel_Button_Load);
            this.WelcomePanel.Controls.Add(this.WelcomePanel_Button_Create);
            this.WelcomePanel.Location = new System.Drawing.Point(261, 73);
            this.WelcomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(329, 449);
            this.WelcomePanel.TabIndex = 6;
            // 
            // WelcomePanel_Text
            // 
            this.WelcomePanel_Text.AutoSize = true;
            this.WelcomePanel_Text.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomePanel_Text.ForeColor = System.Drawing.Color.White;
            this.WelcomePanel_Text.Location = new System.Drawing.Point(73, 200);
            this.WelcomePanel_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomePanel_Text.Name = "WelcomePanel_Text";
            this.WelcomePanel_Text.Size = new System.Drawing.Size(184, 50);
            this.WelcomePanel_Text.TabIndex = 5;
            this.WelcomePanel_Text.Text = "Welcome";
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.ToolsPanel_Button_Variable);
            this.ToolsPanel.Controls.Add(this.ToolsPanel_Button_Add);
            this.ToolsPanel.Controls.Add(this.ToolsPanel_Button_Run);
            this.ToolsPanel.Controls.Add(this.ToolsPanel_Button_Screenshot);
            this.ToolsPanel.Controls.Add(this.ToolsPanel_Button_Build);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(882, 68);
            this.ToolsPanel.TabIndex = 6;
            this.ToolsPanel.Visible = false;
            // 
            // ToolsPanel_Button_Variable
            // 
            this.ToolsPanel_Button_Variable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ToolsPanel_Button_Variable.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolsPanel_Button_Variable.FlatAppearance.BorderSize = 0;
            this.ToolsPanel_Button_Variable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsPanel_Button_Variable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_Button_Variable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsPanel_Button_Variable.Image = global::BotMaker.Properties.Resources.variable;
            this.ToolsPanel_Button_Variable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolsPanel_Button_Variable.Location = new System.Drawing.Point(636, 0);
            this.ToolsPanel_Button_Variable.Name = "ToolsPanel_Button_Variable";
            this.ToolsPanel_Button_Variable.Size = new System.Drawing.Size(123, 68);
            this.ToolsPanel_Button_Variable.TabIndex = 9;
            this.ToolsPanel_Button_Variable.Text = "Variables";
            this.ToolsPanel_Button_Variable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolsPanel_Button_Variable.UseVisualStyleBackColor = false;
            this.ToolsPanel_Button_Variable.Click += new System.EventHandler(this.ToolsPanel_Button_Variable_Click);
            // 
            // ToolsPanel_Button_Add
            // 
            this.ToolsPanel_Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ToolsPanel_Button_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel_Button_Add.FlatAppearance.BorderSize = 0;
            this.ToolsPanel_Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsPanel_Button_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsPanel_Button_Add.Image = global::BotMaker.Properties.Resources.add;
            this.ToolsPanel_Button_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolsPanel_Button_Add.Location = new System.Drawing.Point(246, 0);
            this.ToolsPanel_Button_Add.Name = "ToolsPanel_Button_Add";
            this.ToolsPanel_Button_Add.Size = new System.Drawing.Size(123, 68);
            this.ToolsPanel_Button_Add.TabIndex = 5;
            this.ToolsPanel_Button_Add.Text = "Add Event";
            this.ToolsPanel_Button_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolsPanel_Button_Add.UseVisualStyleBackColor = false;
            this.ToolsPanel_Button_Add.Click += new System.EventHandler(this.ToolsPanel_Button_Add_Click);
            // 
            // ToolsPanel_Button_Run
            // 
            this.ToolsPanel_Button_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ToolsPanel_Button_Run.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel_Button_Run.FlatAppearance.BorderSize = 0;
            this.ToolsPanel_Button_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsPanel_Button_Run.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_Button_Run.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsPanel_Button_Run.Image = global::BotMaker.Properties.Resources.play;
            this.ToolsPanel_Button_Run.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolsPanel_Button_Run.Location = new System.Drawing.Point(123, 0);
            this.ToolsPanel_Button_Run.Name = "ToolsPanel_Button_Run";
            this.ToolsPanel_Button_Run.Size = new System.Drawing.Size(123, 68);
            this.ToolsPanel_Button_Run.TabIndex = 4;
            this.ToolsPanel_Button_Run.Text = "Run";
            this.ToolsPanel_Button_Run.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolsPanel_Button_Run.UseVisualStyleBackColor = false;
            this.ToolsPanel_Button_Run.Click += new System.EventHandler(this.ToolsPanel_Button_Play_Click);
            // 
            // ToolsPanel_Button_Screenshot
            // 
            this.ToolsPanel_Button_Screenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ToolsPanel_Button_Screenshot.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolsPanel_Button_Screenshot.FlatAppearance.BorderSize = 0;
            this.ToolsPanel_Button_Screenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsPanel_Button_Screenshot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_Button_Screenshot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsPanel_Button_Screenshot.Image = global::BotMaker.Properties.Resources.image;
            this.ToolsPanel_Button_Screenshot.Location = new System.Drawing.Point(759, 0);
            this.ToolsPanel_Button_Screenshot.Margin = new System.Windows.Forms.Padding(2);
            this.ToolsPanel_Button_Screenshot.Name = "ToolsPanel_Button_Screenshot";
            this.ToolsPanel_Button_Screenshot.Size = new System.Drawing.Size(123, 68);
            this.ToolsPanel_Button_Screenshot.TabIndex = 1;
            this.ToolsPanel_Button_Screenshot.Text = "Screenshot";
            this.ToolsPanel_Button_Screenshot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolsPanel_Button_Screenshot.UseVisualStyleBackColor = false;
            this.ToolsPanel_Button_Screenshot.Click += new System.EventHandler(this.ToolsPanel_Button_Screenshot_Click);
            // 
            // ToolsPanel_Button_Build
            // 
            this.ToolsPanel_Button_Build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ToolsPanel_Button_Build.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel_Button_Build.FlatAppearance.BorderSize = 0;
            this.ToolsPanel_Button_Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsPanel_Button_Build.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel_Button_Build.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsPanel_Button_Build.Image = global::BotMaker.Properties.Resources.build;
            this.ToolsPanel_Button_Build.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolsPanel_Button_Build.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel_Button_Build.Margin = new System.Windows.Forms.Padding(2);
            this.ToolsPanel_Button_Build.Name = "ToolsPanel_Button_Build";
            this.ToolsPanel_Button_Build.Size = new System.Drawing.Size(123, 68);
            this.ToolsPanel_Button_Build.TabIndex = 0;
            this.ToolsPanel_Button_Build.Text = "Build";
            this.ToolsPanel_Button_Build.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolsPanel_Button_Build.UseVisualStyleBackColor = false;
            this.ToolsPanel_Button_Build.Click += new System.EventHandler(this.ToolsPanel_Button_Build_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.PropertySideBar);
            this.SidePanel.Location = new System.Drawing.Point(0, 89);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(882, 541);
            this.SidePanel.TabIndex = 7;
            this.SidePanel.Visible = false;
            // 
            // PropertySideBar
            // 
            this.PropertySideBar.Controls.Add(this.tabPage1);
            this.PropertySideBar.Controls.Add(this.tabPage3);
            this.PropertySideBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PropertySideBar.Location = new System.Drawing.Point(0, 0);
            this.PropertySideBar.Margin = new System.Windows.Forms.Padding(2);
            this.PropertySideBar.Name = "PropertySideBar";
            this.PropertySideBar.SelectedIndex = 0;
            this.PropertySideBar.Size = new System.Drawing.Size(880, 544);
            this.PropertySideBar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.tabPage1.Controls.Add(this.ScreenshotPanel);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 518);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Workspace";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.tabPage3.Controls.Add(this.ProjectSettings_Label_Count);
            this.tabPage3.Controls.Add(this.ProjectSettings_TextField_Count);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(872, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Project Settings";
            // 
            // ProjectSettings_Label_Count
            // 
            this.ProjectSettings_Label_Count.AutoSize = true;
            this.ProjectSettings_Label_Count.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectSettings_Label_Count.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProjectSettings_Label_Count.Location = new System.Drawing.Point(21, 22);
            this.ProjectSettings_Label_Count.Name = "ProjectSettings_Label_Count";
            this.ProjectSettings_Label_Count.Size = new System.Drawing.Size(54, 21);
            this.ProjectSettings_Label_Count.TabIndex = 1;
            this.ProjectSettings_Label_Count.Text = "Count";
            // 
            // ProjectSettings_TextField_Count
            // 
            this.ProjectSettings_TextField_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ProjectSettings_TextField_Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectSettings_TextField_Count.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectSettings_TextField_Count.ForeColor = System.Drawing.SystemColors.Window;
            this.ProjectSettings_TextField_Count.Location = new System.Drawing.Point(84, 23);
            this.ProjectSettings_TextField_Count.Name = "ProjectSettings_TextField_Count";
            this.ProjectSettings_TextField_Count.Size = new System.Drawing.Size(100, 22);
            this.ProjectSettings_TextField_Count.TabIndex = 0;
            this.ProjectSettings_TextField_Count.Text = "1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.InfoPanel_FeedBack_Link);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 742);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(882, 30);
            this.InfoPanel.TabIndex = 8;
            this.InfoPanel.Visible = false;
            // 
            // InfoPanel_FeedBack_Link
            // 
            this.InfoPanel_FeedBack_Link.ActiveLinkColor = System.Drawing.Color.Blue;
            this.InfoPanel_FeedBack_Link.AutoSize = true;
            this.InfoPanel_FeedBack_Link.Location = new System.Drawing.Point(812, 8);
            this.InfoPanel_FeedBack_Link.Name = "InfoPanel_FeedBack_Link";
            this.InfoPanel_FeedBack_Link.Size = new System.Drawing.Size(58, 13);
            this.InfoPanel_FeedBack_Link.TabIndex = 0;
            this.InfoPanel_FeedBack_Link.TabStop = true;
            this.InfoPanel_FeedBack_Link.Text = "Contact us";
            this.InfoPanel_FeedBack_Link.VisitedLinkColor = System.Drawing.Color.Blue;
            this.InfoPanel_FeedBack_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoPanel_FeedBack_Link_LinkClicked);
            // 
            // TimelinePanel
            // 
            this.TimelinePanel.AllowDrop = true;
            this.TimelinePanel.AutoScroll = true;
            this.TimelinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimelinePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimelinePanel.Location = new System.Drawing.Point(0, 631);
            this.TimelinePanel.Name = "TimelinePanel";
            this.TimelinePanel.Size = new System.Drawing.Size(882, 111);
            this.TimelinePanel.TabIndex = 9;
            this.TimelinePanel.Visible = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(882, 772);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.TimelinePanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.ToolsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoTMakeR";
            this.ScreenshotPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotPanel_Image)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.PropertySideBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WelcomePanel_Button_Load;
        private System.Windows.Forms.Button WelcomePanel_Button_Create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel ScreenshotPanel;
        private System.Windows.Forms.Label WelcomePanel_Text;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.TabControl PropertySideBar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ToolsPanel_Button_Build;
        private System.Windows.Forms.Button ToolsPanel_Button_Screenshot;
        private System.Windows.Forms.ComboBox ToolsPanel_DropDown_Screenshot;
        private System.Windows.Forms.PictureBox ScreenshotPanel_Image;
        private System.Windows.Forms.Button ToolsPanel_Button_Run;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.LinkLabel InfoPanel_FeedBack_Link;
        private System.Windows.Forms.Button ToolsPanel_Button_Add;
        private System.Windows.Forms.Button ToolsPanel_Button_Variable;
        private System.Windows.Forms.FlowLayoutPanel TimelinePanel;
        private Label ProjectSettings_Label_Count;
        private TextBox ProjectSettings_TextField_Count;
        private TabPage tabPage1;
    }
}

