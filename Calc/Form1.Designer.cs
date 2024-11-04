namespace Calc;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        btnMult = new Button();
        btnDiv = new Button();
        btnSub = new Button();
        btnAdd = new Button();
        btnEqual = new Button();
        richTextBox1 = new RichTextBox();
        contextMenuStrip4 = new ContextMenuStrip(components);
        aboutToolStripMenuItem1 = new ToolStripMenuItem();
        clearToolStripMenuItem1 = new ToolStripMenuItem();
        closeToolStripMenuItem1 = new ToolStripMenuItem();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        contextMenuStrip4.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.5F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5F));
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
        tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.11111F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.8888855F));
        tableLayoutPanel1.Size = new Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(btnMult);
        flowLayoutPanel1.Controls.Add(btnDiv);
        flowLayoutPanel1.Controls.Add(btnSub);
        flowLayoutPanel1.Controls.Add(btnAdd);
        flowLayoutPanel1.Controls.Add(btnEqual);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(695, 143);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(102, 304);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // btnMult
        // 
        btnMult.Location = new Point(3, 3);
        btnMult.Name = "btnMult";
        btnMult.Size = new Size(94, 29);
        btnMult.TabIndex = 2;
        btnMult.Text = "*";
        btnMult.UseVisualStyleBackColor = true;
        btnMult.Click += btnOperator_Click;
        // 
        // btnDiv
        // 
        btnDiv.Location = new Point(3, 38);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(94, 29);
        btnDiv.TabIndex = 1;
        btnDiv.Text = "/";
        btnDiv.UseVisualStyleBackColor = true;
        btnDiv.Click += btnOperator_Click;
        // 
        // btnSub
        // 
        btnSub.Location = new Point(3, 73);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(94, 29);
        btnSub.TabIndex = 0;
        btnSub.Text = "-";
        btnSub.UseVisualStyleBackColor = true;
        btnSub.Click += btnOperator_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(3, 108);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnOperator_Click;
        // 
        // btnEqual
        // 
        btnEqual.Location = new Point(3, 143);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new Size(94, 29);
        btnEqual.TabIndex = 4;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = true;
        btnEqual.Click += button6_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Fill;
        richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        richTextBox1.Location = new Point(3, 3);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(686, 134);
        richTextBox1.TabIndex = 2;
        richTextBox1.Text = "";
        // 
        // contextMenuStrip4
        // 
        contextMenuStrip4.ImageScalingSize = new Size(20, 20);
        contextMenuStrip4.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1, clearToolStripMenuItem1, closeToolStripMenuItem1 });
        contextMenuStrip4.Name = "contextMenuStrip4";
        contextMenuStrip4.Size = new Size(120, 76);
        contextMenuStrip4.Opening += contextMenuStrip4_Opening;
        // 
        // aboutToolStripMenuItem1
        // 
        aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
        aboutToolStripMenuItem1.Size = new Size(119, 24);
        aboutToolStripMenuItem1.Text = "About";
        aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
        // 
        // clearToolStripMenuItem1
        // 
        clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
        clearToolStripMenuItem1.Size = new Size(119, 24);
        clearToolStripMenuItem1.Text = "Clear";
        clearToolStripMenuItem1.Click += clearToolStripMenuItem1_Click;
        // 
        // closeToolStripMenuItem1
        // 
        closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
        closeToolStripMenuItem1.Size = new Size(119, 24);
        closeToolStripMenuItem1.Text = "Close";
        closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        contextMenuStrip4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ContextMenuStrip contextMenuStrip4;
    private ToolStripMenuItem aboutToolStripMenuItem1;
    private ToolStripMenuItem clearToolStripMenuItem1;
    private ToolStripMenuItem closeToolStripMenuItem1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnSub;
    private Button btnDiv;
    private Button btnMult;
    private Button btnAdd;
    private Button btnEqual;
    private RichTextBox richTextBox1;
}
