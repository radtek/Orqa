namespace River.Orqa.Dialogs
{
	partial class ExceptionDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionDialog));
			this.exceptionDetails = new River.Orqa.Dialogs.ExceptionDetails();
			this.SuspendLayout();
			// 
			// exceptionDetails
			// 
			resources.ApplyResources(this.exceptionDetails, "exceptionDetails");
			this.exceptionDetails.Name = "exceptionDetails";
			// 
			// ExceptionDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.exceptionDetails);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ExceptionDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.ResumeLayout(false);

		}

		#endregion

		private ExceptionDetails exceptionDetails;

	}
}