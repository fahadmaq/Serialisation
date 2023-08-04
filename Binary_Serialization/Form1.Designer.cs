namespace Binary_Serialization
{
    partial class Form1
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
            this.lbpid = new System.Windows.Forms.Label();
            this.lbPName = new System.Windows.Forms.Label();
            this.lbPPrice = new System.Windows.Forms.Label();
            this.teId = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.bBinaryWrite = new System.Windows.Forms.Button();
            this.bXMLWrite = new System.Windows.Forms.Button();
            this.bSOAPWrite = new System.Windows.Forms.Button();
            this.bJSONWrite = new System.Windows.Forms.Button();
            this.bBinaryRead = new System.Windows.Forms.Button();
            this.bXMLRead = new System.Windows.Forms.Button();
            this.bSOAPRead = new System.Windows.Forms.Button();
            this.bJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpid
            // 
            this.lbpid.AutoSize = true;
            this.lbpid.Location = new System.Drawing.Point(59, 38);
            this.lbpid.Name = "lbpid";
            this.lbpid.Size = new System.Drawing.Size(64, 16);
            this.lbpid.TabIndex = 0;
            this.lbpid.Text = "ProductId";
            // 
            // lbPName
            // 
            this.lbPName.AutoSize = true;
            this.lbPName.Location = new System.Drawing.Point(59, 125);
            this.lbPName.Name = "lbPName";
            this.lbPName.Size = new System.Drawing.Size(93, 16);
            this.lbPName.TabIndex = 1;
            this.lbPName.Text = "Product Name";
            // 
            // lbPPrice
            // 
            this.lbPPrice.AutoSize = true;
            this.lbPPrice.Location = new System.Drawing.Point(49, 212);
            this.lbPPrice.Name = "lbPPrice";
            this.lbPPrice.Size = new System.Drawing.Size(87, 16);
            this.lbPPrice.TabIndex = 2;
            this.lbPPrice.Text = "Product Price";
            // 
            // teId
            // 
            this.teId.Location = new System.Drawing.Point(182, 38);
            this.teId.Name = "teId";
            this.teId.Size = new System.Drawing.Size(165, 22);
            this.teId.TabIndex = 3;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(182, 125);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(165, 22);
            this.txName.TabIndex = 4;
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(182, 212);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(165, 22);
            this.txPrice.TabIndex = 5;
            // 
            // bBinaryWrite
            // 
            this.bBinaryWrite.Location = new System.Drawing.Point(400, 32);
            this.bBinaryWrite.Name = "bBinaryWrite";
            this.bBinaryWrite.Size = new System.Drawing.Size(145, 49);
            this.bBinaryWrite.TabIndex = 6;
            this.bBinaryWrite.Text = "BinaryWrite";
            this.bBinaryWrite.UseVisualStyleBackColor = true;
            this.bBinaryWrite.Click += new System.EventHandler(this.bBinaryWrite_Click);
            // 
            // bXMLWrite
            // 
            this.bXMLWrite.Location = new System.Drawing.Point(400, 103);
            this.bXMLWrite.Name = "bXMLWrite";
            this.bXMLWrite.Size = new System.Drawing.Size(145, 44);
            this.bXMLWrite.TabIndex = 7;
            this.bXMLWrite.Text = "XML Write";
            this.bXMLWrite.UseVisualStyleBackColor = true;
            this.bXMLWrite.Click += new System.EventHandler(this.bXMLWrite_Click);
            // 
            // bSOAPWrite
            // 
            this.bSOAPWrite.Location = new System.Drawing.Point(400, 179);
            this.bSOAPWrite.Name = "bSOAPWrite";
            this.bSOAPWrite.Size = new System.Drawing.Size(145, 49);
            this.bSOAPWrite.TabIndex = 8;
            this.bSOAPWrite.Text = "SOAP Write";
            this.bSOAPWrite.UseVisualStyleBackColor = true;
            this.bSOAPWrite.Click += new System.EventHandler(this.bSOAPWrite_Click);
            // 
            // bJSONWrite
            // 
            this.bJSONWrite.Location = new System.Drawing.Point(400, 258);
            this.bJSONWrite.Name = "bJSONWrite";
            this.bJSONWrite.Size = new System.Drawing.Size(145, 49);
            this.bJSONWrite.TabIndex = 9;
            this.bJSONWrite.Text = "JSON Write";
            this.bJSONWrite.UseVisualStyleBackColor = true;
            this.bJSONWrite.Click += new System.EventHandler(this.bJSONWrite_Click);
            // 
            // bBinaryRead
            // 
            this.bBinaryRead.Location = new System.Drawing.Point(595, 32);
            this.bBinaryRead.Name = "bBinaryRead";
            this.bBinaryRead.Size = new System.Drawing.Size(145, 49);
            this.bBinaryRead.TabIndex = 10;
            this.bBinaryRead.Text = "Binary Read";
            this.bBinaryRead.UseVisualStyleBackColor = true;
            this.bBinaryRead.Click += new System.EventHandler(this.bBinaryRead_Click);
            // 
            // bXMLRead
            // 
            this.bXMLRead.Location = new System.Drawing.Point(595, 103);
            this.bXMLRead.Name = "bXMLRead";
            this.bXMLRead.Size = new System.Drawing.Size(145, 49);
            this.bXMLRead.TabIndex = 11;
            this.bXMLRead.Text = "XML Read";
            this.bXMLRead.UseVisualStyleBackColor = true;
            this.bXMLRead.Click += new System.EventHandler(this.bXMLRead_Click);
            // 
            // bSOAPRead
            // 
            this.bSOAPRead.Location = new System.Drawing.Point(595, 179);
            this.bSOAPRead.Name = "bSOAPRead";
            this.bSOAPRead.Size = new System.Drawing.Size(145, 49);
            this.bSOAPRead.TabIndex = 12;
            this.bSOAPRead.Text = "SOAP Read";
            this.bSOAPRead.UseVisualStyleBackColor = true;
            this.bSOAPRead.Click += new System.EventHandler(this.bSOAPRead_Click);
            // 
            // bJSONRead
            // 
            this.bJSONRead.Location = new System.Drawing.Point(595, 258);
            this.bJSONRead.Name = "bJSONRead";
            this.bJSONRead.Size = new System.Drawing.Size(145, 49);
            this.bJSONRead.TabIndex = 13;
            this.bJSONRead.Text = "JSON Read";
            this.bJSONRead.UseVisualStyleBackColor = true;
            this.bJSONRead.Click += new System.EventHandler(this.bJSONRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bJSONRead);
            this.Controls.Add(this.bSOAPRead);
            this.Controls.Add(this.bXMLRead);
            this.Controls.Add(this.bBinaryRead);
            this.Controls.Add(this.bJSONWrite);
            this.Controls.Add(this.bSOAPWrite);
            this.Controls.Add(this.bXMLWrite);
            this.Controls.Add(this.bBinaryWrite);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.teId);
            this.Controls.Add(this.lbPPrice);
            this.Controls.Add(this.lbPName);
            this.Controls.Add(this.lbpid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbpid;
        private System.Windows.Forms.Label lbPName;
        private System.Windows.Forms.Label lbPPrice;
        private System.Windows.Forms.TextBox teId;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Button bBinaryWrite;
        private System.Windows.Forms.Button bXMLWrite;
        private System.Windows.Forms.Button bSOAPWrite;
        private System.Windows.Forms.Button bJSONWrite;
        private System.Windows.Forms.Button bBinaryRead;
        private System.Windows.Forms.Button bXMLRead;
        private System.Windows.Forms.Button bSOAPRead;
        private System.Windows.Forms.Button bJSONRead;
    }
}

