using System;
using System.Drawing;
using System.Windows.Forms;
using MealsApp.Interfaces;

namespace MealsApp.UI
{
    public partial class ElementCtrl: UserControl
    {

		Action<ElementCtrl> OnElementClick;

		public Action<Image> OnThumbChange;

		public IElement Element;

		public Image Thumb;


        public ElementCtrl(IElement element , Action<ElementCtrl> OnClick)
        {
            InitializeComponent();

			Element = element;

			this.OnElementClick = OnClick;
        }

		public ElementCtrl()  
		{

		}

		private void ElementCtrl_Load(object sender, EventArgs e)
		{
			lblElementName.Text = Element.Name;

		}

		public  void SetImage()
		{
			pbElementPic.Image = Thumb;

			OnThumbChange?.Invoke(Thumb);
		}

		private void ElementCtrl_MouseEnter(object sender, EventArgs e)
		{
			BackColor = Color.Orange;
		}

		private void ElementCtrl_MouseLeave(object sender, EventArgs e)
		{
			BackColor = Color.Moccasin;
		}

		private void ElementCtrl_Click(object sender, EventArgs e)
		{
			OnElementClick?.Invoke(this);
		}
	}
}
