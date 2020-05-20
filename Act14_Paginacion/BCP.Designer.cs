namespace Act14_Paginacion
{
  partial class BCP
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
      if(disposing && (components != null)) {
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tblBCP = new System.Windows.Forms.DataGridView();
      this.bcpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpOpe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Lle = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Ret = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bcpT_Bloq = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.tblBCP)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Estados proceso:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(388, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "1 = Nuevo, 2 = Admitido, 3 = Ejecucion, 4 = Bloqueado, 5 = Terminado, -1 = N/A";
      // 
      // tblBCP
      // 
      this.tblBCP.AllowUserToAddRows = false;
      this.tblBCP.AllowUserToDeleteRows = false;
      this.tblBCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblBCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bcpId,
            this.bcpEstado,
            this.bcpOpe,
            this.bcpRes,
            this.bcpT_Lle,
            this.bcpT_Fin,
            this.bcpT_Ret,
            this.bcpT_Resp,
            this.bcpT_Esp,
            this.bcpT_Ser,
            this.bcpT_Rest,
            this.bcpT_Bloq});
      this.tblBCP.Location = new System.Drawing.Point(12, 53);
      this.tblBCP.Name = "tblBCP";
      this.tblBCP.ReadOnly = true;
      this.tblBCP.RowHeadersVisible = false;
      this.tblBCP.Size = new System.Drawing.Size(797, 385);
      this.tblBCP.TabIndex = 2;
      // 
      // bcpId
      // 
      this.bcpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpId.HeaderText = "Id";
      this.bcpId.Name = "bcpId";
      this.bcpId.ReadOnly = true;
      this.bcpId.Width = 41;
      // 
      // bcpEstado
      // 
      this.bcpEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpEstado.HeaderText = "Estado";
      this.bcpEstado.Name = "bcpEstado";
      this.bcpEstado.ReadOnly = true;
      this.bcpEstado.Width = 65;
      // 
      // bcpOpe
      // 
      this.bcpOpe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpOpe.HeaderText = "Operación";
      this.bcpOpe.Name = "bcpOpe";
      this.bcpOpe.ReadOnly = true;
      this.bcpOpe.Width = 81;
      // 
      // bcpRes
      // 
      this.bcpRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpRes.HeaderText = "Resultado";
      this.bcpRes.Name = "bcpRes";
      this.bcpRes.ReadOnly = true;
      this.bcpRes.Width = 80;
      // 
      // bcpT_Lle
      // 
      this.bcpT_Lle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Lle.HeaderText = "T Lle";
      this.bcpT_Lle.Name = "bcpT_Lle";
      this.bcpT_Lle.ReadOnly = true;
      this.bcpT_Lle.Width = 56;
      // 
      // bcpT_Fin
      // 
      this.bcpT_Fin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Fin.HeaderText = "T Fin";
      this.bcpT_Fin.Name = "bcpT_Fin";
      this.bcpT_Fin.ReadOnly = true;
      this.bcpT_Fin.Width = 56;
      // 
      // bcpT_Ret
      // 
      this.bcpT_Ret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Ret.HeaderText = "T Ret";
      this.bcpT_Ret.Name = "bcpT_Ret";
      this.bcpT_Ret.ReadOnly = true;
      this.bcpT_Ret.Width = 59;
      // 
      // bcpT_Resp
      // 
      this.bcpT_Resp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Resp.HeaderText = "T Resp";
      this.bcpT_Resp.Name = "bcpT_Resp";
      this.bcpT_Resp.ReadOnly = true;
      this.bcpT_Resp.Width = 67;
      // 
      // bcpT_Esp
      // 
      this.bcpT_Esp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Esp.HeaderText = "T Esp";
      this.bcpT_Esp.Name = "bcpT_Esp";
      this.bcpT_Esp.ReadOnly = true;
      this.bcpT_Esp.Width = 60;
      // 
      // bcpT_Ser
      // 
      this.bcpT_Ser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Ser.HeaderText = "T Ser";
      this.bcpT_Ser.Name = "bcpT_Ser";
      this.bcpT_Ser.ReadOnly = true;
      this.bcpT_Ser.Width = 58;
      // 
      // bcpT_Rest
      // 
      this.bcpT_Rest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Rest.HeaderText = "T Rest";
      this.bcpT_Rest.Name = "bcpT_Rest";
      this.bcpT_Rest.ReadOnly = true;
      this.bcpT_Rest.Width = 64;
      // 
      // bcpT_Bloq
      // 
      this.bcpT_Bloq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.bcpT_Bloq.HeaderText = "T Bloq";
      this.bcpT_Bloq.Name = "bcpT_Bloq";
      this.bcpT_Bloq.ReadOnly = true;
      this.bcpT_Bloq.Width = 63;
      // 
      // BCP
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(821, 450);
      this.Controls.Add(this.tblBCP);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "BCP";
      this.Text = "BCP";
      ((System.ComponentModel.ISupportInitialize)(this.tblBCP)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView tblBCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpOpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Lle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Ret;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcpT_Bloq;
    }
}