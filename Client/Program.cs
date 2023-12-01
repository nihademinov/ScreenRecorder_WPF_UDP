using System.Drawing;

int screenWidth = 1920;
int screenHeight = 1080;

using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
{
    using (Graphics graphics = Graphics.FromImage(bitmap))
    {
        graphics.CopyFromScreen(0, 0, 0, 0, new System.Drawing.Size(screenWidth, screenHeight));
    }

    string fileName = $"EkranGoruntusu_{DateTime.Now:yyyyMMddHHmmss}.png";
    bitmap.Save(fileName);
}