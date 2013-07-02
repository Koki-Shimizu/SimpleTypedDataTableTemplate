using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypedDataTableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new SimpleTypedDataTableTemplate<SimpleItem>();


            var list = new List<SimpleItem>();
            list.Add( new SimpleItem(){ Id = "5", Gender = 3 });
            list.Add( new SimpleItem(){ Id = "6", Time = DateTime.Today });



            dt.Fill(list.ToArray());

        }
    }
}
