namespace Csillagtérkép
{
    public partial class Form1 : Form
    {
        Models.hajosContext context = new Models.hajosContext();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void buttonRajz_Click(object sender, EventArgs e)
        {
            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            
            Graphics g = this.CreateGraphics();
            g.Clear(Color.DarkBlue);

            Color c = Color.White;
            Pen toll = new Pen(c, 1);
            Brush brush = new SolidBrush(c);

            double nagyitás = 300;
            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;

            foreach (var star in stars)
            {
                if (star.Magnitude > 6) continue;
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;

                float x = (float)(star.X * nagyitás + cx);
                float y = (float)(star.Y * nagyitás + cy); 
                double size = 20 * Math.Pow(10, (star.Magnitude) / -2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();

            foreach (var line in lines)
            {
                var star1 = (from x in stars
                            where x.Hip == line.Star1
                            select x).FirstOrDefault();
                var star2 = (from x in stars
                             where x.Hip == line.Star2
                             select x).FirstOrDefault();

                if(star1 == null || star2 == null) continue;

                float x1 = (float)(star1.X * nagyitás + cx);
                float y1 = (float)(star1.Y * nagyitás + cy);

                float x2 = (float)(star2.X * nagyitás + cx);
                float y2 = (float)(star2.Y * nagyitás + cy);

                g.DrawLine(toll, x1, y1, x2, y2);
            }

        }
    }
}