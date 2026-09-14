namespace Assignment3._4
{
    public partial class Form1 : Form
    {
        private int selectedRow = -1; //new
        private BindingSource bindingSource = new BindingSource(); //new
        public Form1()
        {
            InitializeComponent();
        }

        private void orderGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            //orderGrid1.DataSource = null;
            //orderGrid1.DataSource = Data.orders;
            bindingSource.ResetBindings(false); //new, for refresh

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = Data.orders; //new
            orderGrid1.DataSource = bindingSource; //new
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            //if (orderGrid1.SelectedRows.Count > 0)
            //{
            //    var result = MessageBox.Show("Are you sure you want to delete this order?", "Warning", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {

            //        Data.orders.RemoveAt(orderGrid.CurrentRow.Index);

            //    }
            //    orderGrid1.DataSource = null;
            //    orderGrid1.DataSource = Data.orders;
            //    orderGrid1.Refresh();

            //}
            //else
            //{
            //    MessageBox.Show("Please select an order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (selectedRow >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this order?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BeverageOrder order = (BeverageOrder)orderGrid1.Rows[selectedRow].DataBoundItem; //new
                    Data.orders.Remove(order); //new
                    bindingSource.ResetBindings(false); //new
                    selectedRow = -1; //new
                }
            }
        }
    }
}
