/*
 * Created by SharpDevelop.
 * User: phutc
 * Date: 01/11/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HelloWorldWindows
{
	partial class frmThiSinh
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tbMaSo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbHoTen = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDiemToan = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbDiemLy = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbDiemHoa = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbDiemTrungBinh = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbKetQua = new System.Windows.Forms.TextBox();
			this.btAdd = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.dgThiSinh = new System.Windows.Forms.DataGrid();
			this.btSua = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgThiSinh)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ma So";
			// 
			// tbMaSo
			// 
			this.tbMaSo.Location = new System.Drawing.Point(96, 31);
			this.tbMaSo.Name = "tbMaSo";
			this.tbMaSo.Size = new System.Drawing.Size(131, 22);
			this.tbMaSo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(252, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ho Ten";
			// 
			// tbHoTen
			// 
			this.tbHoTen.Location = new System.Drawing.Point(325, 31);
			this.tbHoTen.Name = "tbHoTen";
			this.tbHoTen.Size = new System.Drawing.Size(315, 22);
			this.tbHoTen.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Diem Toan";
			// 
			// cbDiemToan
			// 
			this.cbDiemToan.FormattingEnabled = true;
			this.cbDiemToan.Items.AddRange(new object[] {
									"0",
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10"});
			this.cbDiemToan.Location = new System.Drawing.Point(123, 65);
			this.cbDiemToan.Name = "cbDiemToan";
			this.cbDiemToan.Size = new System.Drawing.Size(104, 24);
			this.cbDiemToan.TabIndex = 5;
			this.cbDiemToan.Text = "0";
			this.cbDiemToan.SelectedIndexChanged += new System.EventHandler(this.CbDiemToanSelectedIndexChanged);
			this.cbDiemToan.TextChanged += new System.EventHandler(this.CbDiemToanTextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(252, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Diem Ly";
			// 
			// cbDiemLy
			// 
			this.cbDiemLy.FormattingEnabled = true;
			this.cbDiemLy.Items.AddRange(new object[] {
									"0",
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10"});
			this.cbDiemLy.Location = new System.Drawing.Point(325, 65);
			this.cbDiemLy.Name = "cbDiemLy";
			this.cbDiemLy.Size = new System.Drawing.Size(88, 24);
			this.cbDiemLy.TabIndex = 7;
			this.cbDiemLy.Text = "0";
			this.cbDiemLy.SelectedIndexChanged += new System.EventHandler(this.CbDiemLySelectedIndexChanged);
			this.cbDiemLy.TextChanged += new System.EventHandler(this.CbDiemLyTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(432, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Diem Hoa";
			// 
			// cbDiemHoa
			// 
			this.cbDiemHoa.FormattingEnabled = true;
			this.cbDiemHoa.Items.AddRange(new object[] {
									"0",
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10"});
			this.cbDiemHoa.Location = new System.Drawing.Point(519, 65);
			this.cbDiemHoa.Name = "cbDiemHoa";
			this.cbDiemHoa.Size = new System.Drawing.Size(121, 24);
			this.cbDiemHoa.TabIndex = 9;
			this.cbDiemHoa.Text = "0";
			this.cbDiemHoa.SelectedIndexChanged += new System.EventHandler(this.CbDiemHoaSelectedIndexChanged);
			this.cbDiemHoa.TextChanged += new System.EventHandler(this.CbDiemHoaSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Diem Trung Binh";
			// 
			// tbDiemTrungBinh
			// 
			this.tbDiemTrungBinh.Location = new System.Drawing.Point(168, 99);
			this.tbDiemTrungBinh.Name = "tbDiemTrungBinh";
			this.tbDiemTrungBinh.Size = new System.Drawing.Size(160, 22);
			this.tbDiemTrungBinh.TabIndex = 11;
			this.tbDiemTrungBinh.Text = "0";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(356, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ket Qua";
			// 
			// tbKetQua
			// 
			this.tbKetQua.Location = new System.Drawing.Point(432, 103);
			this.tbKetQua.Name = "tbKetQua";
			this.tbKetQua.Size = new System.Drawing.Size(208, 22);
			this.tbKetQua.TabIndex = 13;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(40, 144);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(124, 38);
			this.btAdd.TabIndex = 14;
			this.btAdd.Text = "Them";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.BtAddClick);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(499, 144);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(125, 38);
			this.btClear.TabIndex = 15;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.BtClearClick);
			// 
			// dgThiSinh
			// 
			this.dgThiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgThiSinh.DataMember = "";
			this.dgThiSinh.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgThiSinh.Location = new System.Drawing.Point(40, 209);
			this.dgThiSinh.Name = "dgThiSinh";
			this.dgThiSinh.Size = new System.Drawing.Size(895, 237);
			this.dgThiSinh.TabIndex = 16;
			this.dgThiSinh.CurrentCellChanged += new System.EventHandler(this.DgThiSinhCurrentCellChanged);
			// 
			// btSua
			// 
			this.btSua.Location = new System.Drawing.Point(193, 144);
			this.btSua.Name = "btSua";
			this.btSua.Size = new System.Drawing.Size(124, 38);
			this.btSua.TabIndex = 17;
			this.btSua.Text = "Sua";
			this.btSua.UseVisualStyleBackColor = true;
			this.btSua.Click += new System.EventHandler(this.BtSuaClick);
			// 
			// btXoa
			// 
			this.btXoa.Location = new System.Drawing.Point(346, 144);
			this.btXoa.Name = "btXoa";
			this.btXoa.Size = new System.Drawing.Size(124, 38);
			this.btXoa.TabIndex = 18;
			this.btXoa.Text = "Xoa";
			this.btXoa.UseVisualStyleBackColor = true;
			this.btXoa.Click += new System.EventHandler(this.BtXoaClick);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(653, 144);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 38);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(807, 144);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(125, 38);
			this.btnLoad.TabIndex = 20;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// frmThiSinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 481);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btXoa);
			this.Controls.Add(this.btSua);
			this.Controls.Add(this.dgThiSinh);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.tbKetQua);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbDiemTrungBinh);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbDiemHoa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbDiemLy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbDiemToan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbHoTen);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbMaSo);
			this.Controls.Add(this.label1);
			this.Name = "frmThiSinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmThiSinh";
			this.Load += new System.EventHandler(this.FrmThiSinhLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgThiSinh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.Button btSua;
		private System.Windows.Forms.DataGrid dgThiSinh;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.TextBox tbKetQua;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbDiemTrungBinh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbDiemHoa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbDiemLy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbDiemToan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbHoTen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbMaSo;
		private System.Windows.Forms.Label label1;
	}
}
