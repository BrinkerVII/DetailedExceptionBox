using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BrinkerVII
{
	enum ImageButtonSizeMode
	{
		AutoSize,
		CenterImage,
		Normal,
		StrechImage,
		Zoom
	}
	class ImageButton : Button
	{
		private Rectangle imageDrawingBounds = new Rectangle();
		private Rectangle imageSourceBounds = new Rectangle();
		public ImageButton()
		{
			this.Text = "";
		}
		private Image image = Properties.Resources.cross;
		public new Image Image
		{
			get { return this.image; }
			set
			{
				this.image = value;
				this.UpdateImageBounds();
				this.Refresh();
			}
		}

		private void UpdateImageBounds()
		{
			this.imageSourceBounds = new Rectangle(new Point(), this.image.Size);

			Point imageLocation = new Point();
			Size imageSize = this.image.Size;

			switch (this.sizeMode)
			{
				case ImageButtonSizeMode.AutoSize:
					this.Size = this.image.Size;
					break;
				case ImageButtonSizeMode.CenterImage:
					break;
				case ImageButtonSizeMode.Normal:
					imageSize = this.Size;
					break;
				case ImageButtonSizeMode.StrechImage:
					imageSize = this.Size;
					break;
				case ImageButtonSizeMode.Zoom:
					double ratio = this.image.Width / this.Width;
					imageSize = new Size(this.Width, (int)(Math.Floor(this.image.Height * ratio)));
					break;
				default: break;
			}

			switch (this.ImageAlign)
			{
				case ContentAlignment.TopLeft:
					imageLocation = new Point(0, 0);
					break;
				case ContentAlignment.TopCenter:
					imageLocation = new Point((this.Width / 2) - (imageSize.Width / 2), 0);
					break;
				case ContentAlignment.TopRight:
					imageLocation = new Point(this.Width - imageSize.Width, 0);
					break;
				case ContentAlignment.MiddleCenter:
					imageLocation = new Point(
						(this.Width / 2) - (imageSize.Width / 2),
						(this.Height / 2) - (imageSize.Height / 2)
					);
					break;
				default:
					imageLocation = new Point();
					break;
			}

			this.imageDrawingBounds = new Rectangle(imageLocation, imageSize);
		}

		public new ContentAlignment ImageAlign
		{
			get { return base.ImageAlign; }
			set
			{
				base.ImageAlign = value;
				this.UpdateImageBounds();
				this.Refresh();
			}
		}
		private ImageButtonSizeMode sizeMode = ImageButtonSizeMode.Normal;
		public ImageButtonSizeMode SizeMode
		{
			get { return this.sizeMode; }
			set
			{
				this.sizeMode = value;
				this.UpdateImageBounds();
				this.Refresh();
			}
		}
		public new Size Size
		{
			get { return base.Size; }
			set
			{
				base.Size = value;
			}
		}
		public new Point Location
		{
			get { return base.Location; }
			set
			{
				base.Location = value;
			}
		}
		public new Rectangle Bounds
		{
			get { return base.Bounds; }
			set
			{
				base.Bounds = value;
			}
		}
		public new string Text
		{
			get { return base.Text; }
			set { base.Text = ""; }
		}
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			pevent.Graphics.DrawImage(this.image, this.imageDrawingBounds, this.imageSourceBounds, GraphicsUnit.Pixel);
		}
		protected override void OnResize(EventArgs e)
		{
			this.UpdateImageBounds();
			base.OnResize(e);
		}
	}
}
