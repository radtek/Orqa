//************************************************************************************************
// Copyright � 2002-2006 Steven M. Cohn. All Rights Reserved.
//
// User preferences and program options.
//
// Revision History:
// -When---------- -What-------------------------------------------------------------------------
// 01-Jul-2005      New
//************************************************************************************************

namespace River.Orqa.Options
{
	using System;
	using System.Windows.Forms;
	using River.Orqa.Resources;


	//********************************************************************************************
	// class SheetBase
	//********************************************************************************************

	internal class SheetBase : UserControl
	{
		private string title;


		//========================================================================================
		// Constructor
		//========================================================================================

		public SheetBase ()
		{
			InitializeComponent();
		}


		//========================================================================================
		// Title
		//========================================================================================

		public string Title
		{
			get { return title; }
			set { title = value; }
		}


		//========================================================================================
		// InitializeComponent()
		//========================================================================================

		private void InitializeComponent ()
		{
			this.SuspendLayout();
			// 
			// SheetBase
			// 
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.Name = "SheetBase";
			this.Size = new System.Drawing.Size(430, 315);
			this.ResumeLayout(false);

		}


		//========================================================================================
		// Reset()
		//========================================================================================

		public virtual void Reset () { }


		//========================================================================================
		// SaveOptions()
		//========================================================================================

		public virtual void SaveOptions () { }
	}
}
