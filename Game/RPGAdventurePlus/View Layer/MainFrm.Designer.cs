namespace RPGAdventurePlus.View_Layer
{
    partial class MainFrm
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
        ///        
        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cbo_Weapons = new System.Windows.Forms.ComboBox();
            this.cbo_Potions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnCompleteQuest = new System.Windows.Forms.Button();
            this.cbo_Spells = new System.Windows.Forms.ComboBox();
            this.lblCurrentMana = new System.Windows.Forms.Label();
            this.radialMenu1 = new Syncfusion.Windows.Forms.Tools.RadialMenu();
            this.btn_East = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.btn_South = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.btn_West = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.btn_North = new Syncfusion.Windows.Forms.Tools.RadialMenuItem();
            this.mantext = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UseSpell = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_UsePotion = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btn_UseWeapon = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.radialMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitPoints.Location = new System.Drawing.Point(112, 24);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 16);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.Location = new System.Drawing.Point(112, 50);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 16);
            this.lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperience.Location = new System.Drawing.Point(112, 78);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 16);
            this.lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(112, 104);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 16);
            this.lblLevel.TabIndex = 7;
            // 
            // cbo_Weapons
            // 
            this.cbo_Weapons.BackColor = System.Drawing.Color.Gainsboro;
            this.cbo_Weapons.FormattingEnabled = true;
            this.cbo_Weapons.Location = new System.Drawing.Point(278, 504);
            this.cbo_Weapons.Name = "cbo_Weapons";
            this.cbo_Weapons.Size = new System.Drawing.Size(121, 21);
            this.cbo_Weapons.TabIndex = 9;
            this.cbo_Weapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // cbo_Potions
            // 
            this.cbo_Potions.BackColor = System.Drawing.Color.Gainsboro;
            this.cbo_Potions.FormattingEnabled = true;
            this.cbo_Potions.Location = new System.Drawing.Point(278, 531);
            this.cbo_Potions.Name = "cbo_Potions";
            this.cbo_Potions.Size = new System.Drawing.Size(121, 21);
            this.cbo_Potions.TabIndex = 10;
            this.cbo_Potions.SelectedIndexChanged += new System.EventHandler(this.cboPotions_SelectedIndexChanged);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(917, 238);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(54, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Använd";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(770, 238);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(54, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Använd";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(917, 367);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 30);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.Text = "Norr";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(998, 394);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 30);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "Öst";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(917, 422);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 30);
            this.btnSouth.TabIndex = 15;
            this.btnSouth.Text = "Söder";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(836, 394);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 30);
            this.btnWest.TabIndex = 16;
            this.btnWest.Text = "Väst";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLocation.Font = new System.Drawing.Font("Rockwell", 10F);
            this.rtbLocation.Location = new System.Drawing.Point(268, 20);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(439, 132);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Rockwell", 10F);
            this.rtbMessages.Location = new System.Drawing.Point(268, 158);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(439, 276);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 158);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(246, 276);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 440);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(246, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // btnCompleteQuest
            // 
            this.btnCompleteQuest.Location = new System.Drawing.Point(860, 287);
            this.btnCompleteQuest.Name = "btnCompleteQuest";
            this.btnCompleteQuest.Size = new System.Drawing.Size(10, 10);
            this.btnCompleteQuest.TabIndex = 21;
            this.btnCompleteQuest.Text = "Slutför Uppdrag";
            this.btnCompleteQuest.UseVisualStyleBackColor = true;
            this.btnCompleteQuest.Visible = false;
            this.btnCompleteQuest.Click += new System.EventHandler(this.btnCompleteQuest_Click);
            // 
            // cbo_Spells
            // 
            this.cbo_Spells.BackColor = System.Drawing.Color.Gainsboro;
            this.cbo_Spells.FormattingEnabled = true;
            this.cbo_Spells.Location = new System.Drawing.Point(278, 560);
            this.cbo_Spells.Name = "cbo_Spells";
            this.cbo_Spells.Size = new System.Drawing.Size(121, 21);
            this.cbo_Spells.TabIndex = 23;
            // 
            // lblCurrentMana
            // 
            this.lblCurrentMana.AutoSize = true;
            this.lblCurrentMana.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMana.Location = new System.Drawing.Point(112, 126);
            this.lblCurrentMana.Name = "lblCurrentMana";
            this.lblCurrentMana.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentMana.TabIndex = 25;
            // 
            // radialMenu1
            // 
            this.radialMenu1.BackColor = System.Drawing.Color.Black;
            this.radialMenu1.CenterCircleRimColor = System.Drawing.Color.DarkGray;
            this.radialMenu1.CloseOnTab = false;
            this.radialMenu1.Controls.Add(this.btn_East);
            this.radialMenu1.Controls.Add(this.btn_South);
            this.radialMenu1.Controls.Add(this.btn_West);
            this.radialMenu1.Controls.Add(this.btn_North);
            this.radialMenu1.DrillDown = Syncfusion.Windows.Forms.Tools.DrillDown.Both;
            this.radialMenu1.DrillDownArrowColor = System.Drawing.Color.DarkRed;
            this.radialMenu1.EnableTransition = false;
            this.radialMenu1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radialMenu1.HighlightedArcColor = System.Drawing.Color.DodgerBlue;
            this.radialMenu1.InnerCircleColor = System.Drawing.Color.Gainsboro;
            this.radialMenu1.Items.Add(this.btn_East);
            this.radialMenu1.Items.Add(this.btn_South);
            this.radialMenu1.Items.Add(this.btn_West);
            this.radialMenu1.Items.Add(this.btn_North);
            this.radialMenu1.Location = new System.Drawing.Point(512, 450);
            this.radialMenu1.MaximumSize = new System.Drawing.Size(700, 700);
            this.radialMenu1.MenuVisibility = true;
            this.radialMenu1.MinimumSize = new System.Drawing.Size(150, 150);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Opacity = 5;
            this.radialMenu1.OuterArcColor = System.Drawing.Color.DodgerBlue;
            this.radialMenu1.OuterArcGap = 5;
            this.radialMenu1.OuterArcHighLightedColor = System.Drawing.Color.SteelBlue;
            this.radialMenu1.OuterRimThickness = 3;
            this.radialMenu1.RimBackground = System.Drawing.Color.Gray;
            this.radialMenu1.Size = new System.Drawing.Size(179, 179);
            this.radialMenu1.TabIndex = 26;
            this.radialMenu1.TransitionSpeed = 30;
            this.radialMenu1.Visible = false;
            this.radialMenu1.WedgeCount = 4;
            // 
            // btn_East
            // 
            this.btn_East.BackColor = System.Drawing.Color.LightGray;
            this.btn_East.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_East.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.btn_East.ForeColor = System.Drawing.Color.Black;
            this.btn_East.Location = new System.Drawing.Point(0, 0);
            this.btn_East.Name = "btn_East";
            this.btn_East.Size = new System.Drawing.Size(0, 0);
            this.btn_East.TabIndex = 2;
            this.btn_East.Text = "Öster";
            this.btn_East.Click += new System.EventHandler(this.btn_East_CLick);
            // 
            // btn_South
            // 
            this.btn_South.BackColor = System.Drawing.Color.LightGray;
            this.btn_South.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_South.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.btn_South.ForeColor = System.Drawing.Color.Black;
            this.btn_South.Location = new System.Drawing.Point(0, 0);
            this.btn_South.Name = "btn_South";
            this.btn_South.Size = new System.Drawing.Size(0, 0);
            this.btn_South.TabIndex = 2;
            this.btn_South.Text = "Söder";
            this.btn_South.Click += new System.EventHandler(this.btn_South_Click);
            // 
            // btn_West
            // 
            this.btn_West.BackColor = System.Drawing.Color.LightGray;
            this.btn_West.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_West.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.btn_West.ForeColor = System.Drawing.Color.Black;
            this.btn_West.Location = new System.Drawing.Point(0, 0);
            this.btn_West.Name = "btn_West";
            this.btn_West.Size = new System.Drawing.Size(0, 0);
            this.btn_West.TabIndex = 2;
            this.btn_West.Text = "Väst";
            this.btn_West.Click += new System.EventHandler(this.btn_West_Click);
            // 
            // btn_North
            // 
            this.btn_North.BackColor = System.Drawing.Color.LightGray;
            this.btn_North.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_North.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.btn_North.ForeColor = System.Drawing.Color.Black;
            this.btn_North.Location = new System.Drawing.Point(0, 0);
            this.btn_North.Name = "btn_North";
            this.btn_North.Size = new System.Drawing.Size(0, 0);
            this.btn_North.TabIndex = 2;
            this.btn_North.Text = "Norr";
            this.btn_North.Click += new System.EventHandler(this.btn_North_Click);
            // 
            // mantext
            // 
            this.mantext.AutoSize = true;
            this.mantext.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantext.Location = new System.Drawing.Point(13, 126);
            this.mantext.Name = "mantext";
            this.mantext.Size = new System.Drawing.Size(43, 16);
            this.mantext.TabIndex = 31;
            this.mantext.Text = "Mana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nivå:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Erfarenhet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Guld:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hälsa:";
            // 
            // btn_UseSpell
            // 
            this.btn_UseSpell.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btn_UseSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_UseSpell.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btn_UseSpell.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UseSpell.IsBackStageButton = false;
            this.btn_UseSpell.Location = new System.Drawing.Point(405, 560);
            this.btn_UseSpell.Name = "btn_UseSpell";
            this.btn_UseSpell.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_UseSpell.Size = new System.Drawing.Size(75, 21);
            this.btn_UseSpell.TabIndex = 32;
            this.btn_UseSpell.Text = "Använd";
            this.btn_UseSpell.UseVisualStyle = true;
            this.btn_UseSpell.Click += new System.EventHandler(this.btn_UseSpell_Click);
            // 
            // btn_UsePotion
            // 
            this.btn_UsePotion.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btn_UsePotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_UsePotion.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btn_UsePotion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.btn_UsePotion.IsBackStageButton = false;
            this.btn_UsePotion.Location = new System.Drawing.Point(405, 531);
            this.btn_UsePotion.Name = "btn_UsePotion";
            this.btn_UsePotion.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_UsePotion.Size = new System.Drawing.Size(75, 21);
            this.btn_UsePotion.TabIndex = 33;
            this.btn_UsePotion.Text = "Använd";
            this.btn_UsePotion.UseVisualStyle = true;
            this.btn_UsePotion.Click += new System.EventHandler(this.btn_UsePotion_Click);
            // 
            // btn_UseWeapon
            // 
            this.btn_UseWeapon.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.btn_UseWeapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btn_UseWeapon.BeforeTouchSize = new System.Drawing.Size(75, 21);
            this.btn_UseWeapon.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.btn_UseWeapon.IsBackStageButton = false;
            this.btn_UseWeapon.Location = new System.Drawing.Point(405, 504);
            this.btn_UseWeapon.Name = "btn_UseWeapon";
            this.btn_UseWeapon.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.btn_UseWeapon.Size = new System.Drawing.Size(75, 21);
            this.btn_UseWeapon.TabIndex = 34;
            this.btn_UseWeapon.Text = "Använd";
            this.btn_UseWeapon.UseVisualStyle = true;
            this.btn_UseWeapon.Click += new System.EventHandler(this.btn_UseWeapon_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 637);
            this.ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.Controls.Add(this.cbo_Weapons);
            this.Controls.Add(this.btn_UseWeapon);
            this.Controls.Add(this.cbo_Potions);
            this.Controls.Add(this.mantext);
            this.Controls.Add(this.btn_UsePotion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Spells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_UseSpell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radialMenu1);
            this.Controls.Add(this.lblCurrentMana);
            this.Controls.Add(this.btnCompleteQuest);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(734, 674);
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.Text = "Text Adventure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdventurePlus_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdventurePlus_FormClosed);
            this.Load += new System.EventHandler(this.FormAdventurePlus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.radialMenu1.ResumeLayout(false);
            this.radialMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cbo_Weapons;
        private System.Windows.Forms.ComboBox cbo_Potions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Button btnCompleteQuest;
        private System.Windows.Forms.ComboBox cbo_Spells;
        private System.Windows.Forms.Label lblCurrentMana;
        private Syncfusion.Windows.Forms.Tools.RadialMenu radialMenu1;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem btn_South;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem btn_East;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem btn_West;
        private Syncfusion.Windows.Forms.Tools.RadialMenuItem btn_North;
        private System.Windows.Forms.Label mantext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv btn_UseSpell;
        private Syncfusion.Windows.Forms.ButtonAdv btn_UsePotion;
        private Syncfusion.Windows.Forms.ButtonAdv btn_UseWeapon;
    }
}