namespace WebApplication1.Figures
{
    public class Trapezoid: IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return ((SideA + SideB) * Height) / 2;
        }
    }
}