namespace WebApplication1.Figures
{
    public class Square: IFigure
    {
        public double SideA { get; set; }
        public double GetArea()
        {
            return (SideA * SideA);
        }
    }
}