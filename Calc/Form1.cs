namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            this.ContextMenuStrip = contextMenuStrip4;
        }
        int Number { get; set; }
        int Result { get; set; }

        public delegate int CalculationDelegate(int x, int y);
        private CalculationDelegate CurrentOperation;

        TableLayoutPanel grid = new TableLayoutPanel();
        ClickCounter clickCounter = new ClickCounter(3, 3);


        private void InitializeGrid()
        {
            int gridSize = 3;
            grid.RowCount = gridSize;
            grid.ColumnCount = gridSize;
            grid.Dock = DockStyle.Fill;


            //styling (size)
            for (int i = 0; i < gridSize; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / gridSize));
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / gridSize));

            }

            //Add Buttons
            for (int i = 0; i < gridSize * gridSize; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Dock = DockStyle.Fill;
                btn.Click += NumberButtonClick;

                int column = i % gridSize;
                int row = i / gridSize;
                grid.Controls.Add(btn, column, row);
            }

            tableLayoutPanel1.BackColor = Color.LightBlue;
            grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tableLayoutPanel1.Controls.Add(grid, 0, 1);
        }

        private void NumberButtonClick(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            var position = grid.GetCellPosition(button);
            clickCounter.IncrementCount(position.Row, position.Column);
            label1.Text = $"Button {button.Text} clicked at position " +
                $"({position.Row} {position.Column})";

            int counter = clickCounter.GetCount(position.Row, position.Column);
            label1.Text += "was clicked x times: " + counter;
            button.BackColor = Color.FromArgb(counter * 10 % 256, counter * 10 % 256, 255);

            int input;
            if (int.TryParse(button.Text, out input))
            {
                Number = Number * 10 + input;
                UpdateCalcTextBox(input.ToString());
            }
        }

        private void UpdateCalcTextBox(String v)
        {
            richTextBox1.Text += v;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple calculator", "About", MessageBoxButtons.OK);
            AboutDialog dialog = new AboutDialog();
            dialog.changeLabel("MESSAGE FROM CALC");
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Result = 0;
            //label1.Text = "";
            richTextBox1.Text = "";
            CurrentOperation = null;

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close(); //this is optional

        }

        private void contextMenuStrip4_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeCalculation(CurrentOperation);
            CurrentOperation = null;

        }

        private void btnOperator_Click(object sender, EventArgs e)
        {

            if (sender is Button button)
            {

                string operatorSign = button.Text;

                switch (operatorSign)
                {
                    case "+":
                        // Point to plus method
                        CurrentOperation = (x, y) => x + y;
                        break;
                        //case ...
                }
                MakeCalculation(CurrentOperation);
                UpdateCalcTextBox($" {operatorSign} ");
            }

        }

        private void MakeCalculation(CalculationDelegate currentOperation)
        {
            Result = currentOperation(Result, Number);
            Number = 0;
            richTextBox1.Text = Result.ToString();
            //label1.Text = Result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple calculator", "About", MessageBoxButtons.OK);
            AboutDialog dialog = new AboutDialog();
            dialog.changeLabel("MESSAGE FROM CALC");
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result = 0;
            label1.Text = "";
            richTextBox1.Text = "";
            CurrentOperation = null;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
