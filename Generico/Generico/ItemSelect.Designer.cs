namespace Generico
{
    partial class ItemSelect
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
            this.components = new System.ComponentModel.Container();
            this.quotedataDataSet = new Generico.quotedataDataSet();
            this.tBomItemsTableAdapter = new Generico.quotedataDataSetTableAdapters.tBomItemsTableAdapter();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tBomItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Part_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comp_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Of_Measurment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPrice = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotedataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBomItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quotedataDataSet
            // 
            this.quotedataDataSet.DataSetName = "quotedataDataSet";
            this.quotedataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBomItemsTableAdapter
            // 
            this.tBomItemsTableAdapter.ClearBeforeFill = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(255, 308);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(65, 39);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add Item(s)";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(104, 308);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(65, 39);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Unselect All";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBomItemsBindingSource2
            // 
            this.tBomItemsBindingSource2.DataMember = "tBomItems";
            this.tBomItemsBindingSource2.DataSource = this.quotedataDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.PartNumber,
            this.ComponentType,
            this.ComponentCost,
            this.Description,
            this.UOM});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 272);
            this.dataGridView1.TabIndex = 4;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "Part #";
            this.PartNumber.Name = "PartNumber";
            // 
            // ComponentType
            // 
            this.ComponentType.HeaderText = "Comp Type";
            this.ComponentType.Name = "ComponentType";
            // 
            // ComponentCost
            // 
            this.ComponentCost.HeaderText = "Comp Cost";
            this.ComponentCost.Name = "ComponentCost";
            // 
            // Description
            // 
            this.Description.HeaderText = "Descrip";
            this.Description.Name = "Description";
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Part_Number,
            this.Comp_Type,
            this.compcost,
            this.Description_,
            this.Unit_Of_Measurment,
            this.compqty,
            this.price});
            this.dataGridView2.Location = new System.Drawing.Point(12, 353);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(748, 228);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // Part_Number
            // 
            this.Part_Number.HeaderText = "Part #";
            this.Part_Number.Name = "Part_Number";
            // 
            // Comp_Type
            // 
            this.Comp_Type.HeaderText = "Comp Type";
            this.Comp_Type.Name = "Comp_Type";
            // 
            // compcost
            // 
            this.compcost.HeaderText = "Comp Cost";
            this.compcost.Name = "compcost";
            // 
            // Description_
            // 
            this.Description_.HeaderText = "Descrip";
            this.Description_.Name = "Description_";
            // 
            // Unit_Of_Measurment
            // 
            this.Unit_Of_Measurment.HeaderText = "UOM";
            this.Unit_Of_Measurment.Name = "Unit_Of_Measurment";
            // 
            // compqty
            // 
            this.compqty.HeaderText = "Comp Qty";
            this.compqty.Name = "compqty";
            // 
            // price
            // 
            this.price.HeaderText = "Comp Price";
            this.price.Name = "price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear All Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Item(s)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "Compute Quote";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Price ";
            // 
            // tBoxPrice
            // 
            this.tBoxPrice.Location = new System.Drawing.Point(29, 53);
            this.tBoxPrice.Name = "tBoxPrice";
            this.tBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.tBoxPrice.TabIndex = 12;
            this.tBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxPrice.TextChanged += new System.EventHandler(this.tBoxPrice_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Export to Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Save to DataBase";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha/Hora";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Generico.Properties.Resources._112427301;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.tBoxPrice);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(705, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 259);
            this.panel1.TabIndex = 19;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(27, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ItemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Generico.Properties.Resources.abstract_surface_textures_white_concrete_stone_wall_74190_8184;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Name = "ItemSelect";
            this.Text = "Quote_Setup";
            this.Load += new System.EventHandler(this.ItemSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotedataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBomItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private quotedataDataSet quotedataDataSet;
        private quotedataDataSetTableAdapters.tBomItemsTableAdapter tBomItemsTableAdapter;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.BindingSource tBomItemsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPrice;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comp_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn compcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Of_Measurment;
        private System.Windows.Forms.DataGridViewTextBoxColumn compqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
    }
}