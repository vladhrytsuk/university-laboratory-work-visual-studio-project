namespace Admin_Restoran
{
    partial class Clients_in_Restoran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_in_Restoran));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_RestoranDataSet1 = new Admin_Restoran.Admin_RestoranDataSet1();
            this.clients_in_RestoranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clients_in_RestoranTableAdapter = new Admin_Restoran.Admin_RestoranDataSet1TableAdapters.Clients_in_RestoranTableAdapter();
            this.tableAdapterManager = new Admin_Restoran.Admin_RestoranDataSet1TableAdapters.TableAdapterManager();
            this.clients_in_RestoranBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clients_in_RestoranBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clients_in_RestoranDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admin_RestoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranBindingNavigator)).BeginInit();
            this.clients_in_RestoranBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Журнал «Учета посещений клиентами ресторана»";
            // 
            // admin_RestoranDataSet1
            // 
            this.admin_RestoranDataSet1.DataSetName = "Admin_RestoranDataSet1";
            this.admin_RestoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clients_in_RestoranBindingSource
            // 
            this.clients_in_RestoranBindingSource.DataMember = "Clients_in_Restoran";
            this.clients_in_RestoranBindingSource.DataSource = this.admin_RestoranDataSet1;
            // 
            // clients_in_RestoranTableAdapter
            // 
            this.clients_in_RestoranTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Clients_in_RestoranTableAdapter = this.clients_in_RestoranTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.List_TableTableAdapter = null;
            this.tableAdapterManager.Order_SeatTableAdapter = null;
            this.tableAdapterManager.Plane_in_RestoranTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.TablessTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin_Restoran.Admin_RestoranDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clients_in_RestoranBindingNavigator
            // 
            this.clients_in_RestoranBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clients_in_RestoranBindingNavigator.BindingSource = this.clients_in_RestoranBindingSource;
            this.clients_in_RestoranBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clients_in_RestoranBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clients_in_RestoranBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clients_in_RestoranBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clients_in_RestoranBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clients_in_RestoranBindingNavigatorSaveItem});
            this.clients_in_RestoranBindingNavigator.Location = new System.Drawing.Point(0, 337);
            this.clients_in_RestoranBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clients_in_RestoranBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clients_in_RestoranBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clients_in_RestoranBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clients_in_RestoranBindingNavigator.Name = "clients_in_RestoranBindingNavigator";
            this.clients_in_RestoranBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clients_in_RestoranBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.clients_in_RestoranBindingNavigator.TabIndex = 20;
            this.clients_in_RestoranBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clients_in_RestoranBindingNavigatorSaveItem
            // 
            this.clients_in_RestoranBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clients_in_RestoranBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clients_in_RestoranBindingNavigatorSaveItem.Image")));
            this.clients_in_RestoranBindingNavigatorSaveItem.Name = "clients_in_RestoranBindingNavigatorSaveItem";
            this.clients_in_RestoranBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clients_in_RestoranBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clients_in_RestoranBindingNavigatorSaveItem.Click += new System.EventHandler(this.clients_in_RestoranBindingNavigatorSaveItem_Click);
            // 
            // clients_in_RestoranDataGridView
            // 
            this.clients_in_RestoranDataGridView.AutoGenerateColumns = false;
            this.clients_in_RestoranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients_in_RestoranDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clients_in_RestoranDataGridView.DataSource = this.clients_in_RestoranBindingSource;
            this.clients_in_RestoranDataGridView.Location = new System.Drawing.Point(0, 49);
            this.clients_in_RestoranDataGridView.Name = "clients_in_RestoranDataGridView";
            this.clients_in_RestoranDataGridView.Size = new System.Drawing.Size(843, 285);
            this.clients_in_RestoranDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_Посещения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_Посещения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_посещения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата_посещения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Время_начала_посещения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время_начала_посещения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата_завершения_посещения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата_завершения_посещения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Время_завершения_посещения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Время_завершения_посещения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Номер_Зала";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер_Зала";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Количество_мест";
            this.dataGridViewTextBoxColumn8.HeaderText = "Количество_мест";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Clients_in_Restoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 362);
            this.Controls.Add(this.clients_in_RestoranDataGridView);
            this.Controls.Add(this.clients_in_RestoranBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Clients_in_Restoran";
            this.Text = "Журнал «Учета посещений клиентами ресторана»";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_RestoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranBindingNavigator)).EndInit();
            this.clients_in_RestoranBindingNavigator.ResumeLayout(false);
            this.clients_in_RestoranBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients_in_RestoranDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Admin_RestoranDataSet1 admin_RestoranDataSet1;
        private System.Windows.Forms.BindingSource clients_in_RestoranBindingSource;
        private Admin_RestoranDataSet1TableAdapters.Clients_in_RestoranTableAdapter clients_in_RestoranTableAdapter;
        private Admin_RestoranDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clients_in_RestoranBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clients_in_RestoranBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clients_in_RestoranDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}