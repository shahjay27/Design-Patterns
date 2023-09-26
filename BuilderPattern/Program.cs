

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xBuilder = new ProductXBuilder();
            xBuilder.AddFeatureB();
            xBuilder.AddFeatureA();
            xBuilder.AddFeatureC();
            ProductX xProduct = xBuilder.Build();
            xProduct.PrintIncludedFeatures();
        }
    }
}
