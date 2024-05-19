using System;
using System.Windows.Forms;

namespace ButtonTree
{
	///<Authority>
	///this control is created by Syed Md. Abul Bashar Milton
	///Software Engineer 
	///this is Version 3.4.2.4
	///Last Modification Date : 04/09/2006(dd/MM/yyyy)
	
	///</Authority>
	/// <summary>
	/// this is Milton created Button(MiButton) specially used for ButtonTree which contrains its Node information.
	/// </summary>
	public class MiButton:Button 
	{
		private ButtonNode _MiNode;
		/// <summary>
		/// MiButon is Button take argument ButtonNode as Container of Button
		/// </summary>
		/// <param name="btnNode">Node contain this button</param>
		public MiButton()
		{
			
			//
			// TODO: Add constructor logic here
			//
		}
		public MiButton(ButtonNode  btnNode)
		{
			_MiNode=btnNode;
			
			//
			// TODO: Add constructor logic here
			//
		}
/// <summary>
/// Get or Set Node Containing  Button
/// </summary>
		public ButtonNode MiNode
		{
			get
			{
				return _MiNode;
			}
			set
			{
				_MiNode=value;
			}
		}
		
	}
}
