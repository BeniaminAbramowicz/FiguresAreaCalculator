namespace WebApplication1.Figures
{
    public class Rhombus: IFigure
    {
        public double SideA { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return (SideA * Height);
        }
    }
}