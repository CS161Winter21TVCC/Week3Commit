using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Interfaces.Real_Estate_Project
{
    public interface RealEstateInterface
    {
        List<Residential> List();

        void Add(Residential obj);

        void Remove(Residential obj);

        List<Residential> Search(string searchText);

    }
}
