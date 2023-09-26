using System;
using System.Collections.Generic;


namespace BuilderPattern
{
    internal class ProductX
    {
        List<string> _featureList;

        public ProductX()
        {
            this._featureList = new List<string>();
        }

        public void AddFeaturePart(string name)
        {
            this._featureList.Add(name);
        }

        public void PrintIncludedFeatures()
        {
            foreach(string feature in this._featureList)
            {
                Console.WriteLine(feature);
            }
        }
    }
}
