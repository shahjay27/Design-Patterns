

namespace BuilderPattern
{
    internal class ProductXBuilder:IBuilder
    {
        ProductX _productX;
        public ProductXBuilder() {
            this.Reset();
        }

        public void AddFeatureA()
        {
            this._productX.AddFeaturePart("Feature A");
        }

        public void AddFeatureB()
        {
            this._productX.AddFeaturePart("Feature B");
        }

        public void AddFeatureC()
        {
            this._productX.AddFeaturePart("Feature C");
        }

        public ProductX Build()
        {
            ProductX tempProduct = this._productX;
            this._productX = null;
            return tempProduct;
        }

        public void Reset()
        {
            _productX = new ProductX();
        }
    }
}
