namespace BlazorApp1.Services
{
    public class EdadService : IEdadService
    {
        public int CalculateEdad()
        {
            Random random = new();
            return random.Next();
        }
    }
}
