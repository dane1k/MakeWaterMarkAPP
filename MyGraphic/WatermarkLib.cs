using System.Drawing;

namespace MyGraphic
{
	public class WatermarkLib
	{
		public static Image AddWatermark(Image img, Image watermark)
		{
			Image image = img;

			Image watermarkImage = watermark;

			using (Graphics imageGraphics = Graphics.FromImage(image))
			{
				using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
				{
					int x = (image.Width / 2 - watermarkImage.Width / 2);
					int y = (image.Height / 2 - watermarkImage.Height / 2);
					watermarkBrush.TranslateTransform(x, y);
					imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
					return image;
				}
			}
		}
	}
}
