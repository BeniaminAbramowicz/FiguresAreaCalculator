namespace WebApplication1.Figures
{
    public class Rectangle: IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double GetArea()
        {
            return (SideA * SideB);
        }
    }
}